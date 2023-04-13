using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataBase
{
    public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-QM4GS45;Initial Catalog=DbContact;Integrated Security=True;");
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
