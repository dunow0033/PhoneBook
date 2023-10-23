using Spectre.Console;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook;

internal class Program
{
    private static readonly ContactContext db = new ContactContext();

    internal static void Main()
    {
        bool closeApp = false;

        while (closeApp == false)
        {
            AnsiConsole.Clear();
            Console.Write("Please enter your selection:  ");
            string selectedOption = Console.ReadLine();

            switch (selectedOption)
            {
                //case 0:
                //    ListContacts();
                //    break;
                case "1":
                    AddContact();
                    break;
            }
        }
    }

    private static void AddContact()
    {
        AnsiConsole.Clear();
        string personName = AnsiConsole.Ask<string>("Enter the name of the contact: ");
        string personPhone = AnsiConsole.Ask<string>("Enter the phonenumber of the contact: ");

        db.Add(new Contact(personName, personPhone));

        Console.WriteLine("hello0");

        db.SaveChanges();

        Console.WriteLine("hello1");

        ListContacts();

        Console.WriteLine("hello2");
    }

    private static void ListContacts()
    {
        Console.WriteLine("List of contacts");
        var contacts = db.Contacts.OrderBy(c => c.Id);

        Table table = new Table();
        table.Expand();
        table.AddColumns("Name", "Phonenumber");

        foreach (var contact in contacts)
        {
            table.AddRow($"{contact.Name}", $"{contact.PhoneNumber}");
        }
        AnsiConsole.Write(table);

        AnsiConsole.WriteLine("Press any key to return to main menu");
        Console.ReadLine();
    }
}

enum MenuOptions
{
    AddContact,
    DeleteContact,
    UpdateContact,
    ViewContact,
    ViewAllContacts,
    Quit
}
