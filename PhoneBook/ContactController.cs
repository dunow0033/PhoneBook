using Spectre.Console;

namespace PhoneBook;

internal class ContactController
{
    internal static void AddContact()
    {
        var name = AnsiConsole.Ask<string>("Contact's name: ");
        var phone_number = AnsiConsole.Ask<string>("Contact's phone number: ");
        using var db = new ContactContext();
        db.Add(new Contact (name, phone_number ));

    }
}
