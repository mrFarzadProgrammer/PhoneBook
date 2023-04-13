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
        /// سرچ بین مخاطبان
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
    }
}
