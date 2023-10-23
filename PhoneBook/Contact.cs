namespace PhoneBook;

internal class Contact
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Email { get; set; }
    public string PhoneNumber { get; set; }

    public Contact(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
    }
}
