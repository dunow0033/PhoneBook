using Microsoft.EntityFrameworkCore;

namespace PhoneBook;

internal class ContactContext: DbContext
{
    public DbSet<Contact> Contacts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer(@"Server=DESKTOP-9B4RFHG\\SQLEXPRESS\;Database=Phonebook;Trusted_Connection=True;Encrypt=False");
        optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Integrated Security=true;Database=Phonebook;Trusted_Connection=True;TrustServerCertificate=True;");
     }
}

