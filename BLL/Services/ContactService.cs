using BLL.Dto;
using DAL.DataBase;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class ContactService
    {
        DataBaseContext dataBase = new DataBaseContext();

        /// <summary>
        /// دریافت لیست مخاطبان
        /// </summary>
        /// <returns></returns>
        public List<ContactListDto> GetContactLists()
        {
            var contacts = dataBase.Contacts.Select(c => new ContactListDto
            {
                Id = c.Id,
                FullName = $"{c.Name} {c.LastName}",
                PhoneNumber = c.PhoneNumber
            }).ToList();
            return contacts;
        }

        /// <summary>
        /// جستجو
        /// </summary>
        /// <param name="SearchKey"></param>
        /// <returns></returns>
        public List<ContactListDto> SearchContact(string SearchKey)
        {
            var contactQuery = dataBase.Contacts.AsQueryable();

            if (!string.IsNullOrEmpty(SearchKey))
            { 
                contactQuery = contactQuery.Where(c => 
                c.Name.Contains(SearchKey) ||
                c.LastName.Contains(SearchKey) ||
                c.PhoneNumber.Contains(SearchKey) ||
                c.Company.Contains(SearchKey)
                );
            }
            var data = contactQuery.Select(c => new ContactListDto
            {
                Id = c.Id,
                FullName = $"{c.Name} {c.LastName}",
                PhoneNumber = c.PhoneNumber
            }).ToList();
            return data;
        }

        /// <summary>
        /// حذف
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ResultDto DeleteContact(int Id)
        {
            var contact = dataBase.Contacts.Find(Id);
            if (contact != null)
            {
                dataBase.Remove(contact);
                dataBase.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "مخاطب با موفقیت حذف شد."
                };
            }
            else
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "مخاطب یافت نشد."
                };
            }

        }

        /// <summary>
        /// جزئیات مخاطب
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ResultDto<ContactDetailDto> GetContactDetail(int Id)
        {
            var contact = dataBase.Contacts.Find(Id);
            if (contact == null)
            {
                return new ResultDto<ContactDetailDto>
                {
                    IsSuccess = false,
                    Message = "مخاطب یافت نشد.",
                    Data = null
                };
            }

            var data = new ContactDetailDto
            {
                Id = contact.Id,
                Name = contact.Name,
                LastName = contact.LastName,
                PhoneNumber = contact.PhoneNumber,
                Company = contact.Company,
                Description = contact.Description,
                CreateAt = contact.CreateAt,
            };
            return new ResultDto<ContactDetailDto>
            {
                IsSuccess = true,
                Data = data
            };
        }

        /// <summary>
        /// افزودن مخاطب جدید
        /// </summary>
        /// <param name="NewContact"></param>
        /// <returns></returns>
        public ResultDto AddNewContact(AddNewContactDto NewContact)
        {
            if (string.IsNullOrEmpty(NewContact.PhoneNumber)) 
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "شماره موبایل اجباری می باشد. لطفا شماره موبایل هم وارد کنید."
                };
            }
            Contact contact = new Contact()
            {
                Name = NewContact.Name,
                LastName = NewContact.LastName,
                PhoneNumber = NewContact.PhoneNumber,
                Company = NewContact.Company,
                Description = NewContact.Description,
                CreateAt = DateTime.Now,
            };
            dataBase.Contacts.Add(contact);
            dataBase.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = $"مخاطب {contact.Name} {contact.LastName} با موفقیت در دیتابیس ذخیره شد.",
            };        }

        public ResultDto EditContact(EditContactDto editContactDto)
        {
            var contact = dataBase.Contacts.Find(editContactDto.Id);

            if (contact == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "مخاطب پیدا نشد."
                };
            }
            contact.Name = editContactDto.Name;
            contact.LastName = editContactDto.LastName;
            contact.Company = editContactDto.Company;
            contact.PhoneNumber = editContactDto.PhoneNumber;
            contact.Description = editContactDto.Description;
            contact.CreateAt = DateTime.Now;

            dataBase.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "اطلاعات مخاطب با موفقیت ویرایش شد."
            };
        }
    }
}
