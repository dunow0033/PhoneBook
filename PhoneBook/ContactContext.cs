using Microsoft.EntityFrameworkCore;

namespace PhoneBook;

internal class ContactContext: DbContext
{
    public DbSet<Contact> Contacts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost\\SQLEXPRESS\;Database=Phonebook;Trusted_Connection=True;");
     }
}
