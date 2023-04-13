using BLL.Dto;
using DAL.DataBase;
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
    }
}
