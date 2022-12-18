using Microsoft.EntityFrameworkCore;
using TrainWebAPI.Models;

namespace TrainWebAPI.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Contact> Contacts { get; set; }
    }
}
