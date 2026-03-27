
List<Contact> contacts = new List<Contact>();

 void AddContact()
{
    Console.Write("Enter name: ");
    string name = Console.ReadLine();
    Console.Write("Enter phone: ");
    string phone = Console.ReadLine();
    Console.Write("Enter email: ");
    string email = Console.ReadLine();
    Contact newContact = new Contact(name, phone, email);
    contacts.Add(newContact);
    Console.WriteLine("Contact added successfully!");
}

void DisplayAll()
{
    if(contacts.Count == 0)
    {
        Console.WriteLine("No contacts found.");
    }
    else
    {
        foreach (Contact contact in contacts)
        {

            contact.DisplayInfo();
        }
    }     
}

void SearchContact()
{
    Console.Write("Enter name to search: ");
    string searchName = Console.ReadLine();

    Contact found = contacts.Find(c => c.Name == searchName);

    if (found != null)
        found.DisplayInfo();
    else
        Console.WriteLine("Contact not found.");
}

while (true)
{
    Console.WriteLine("\n=== Contact Manager ===");
    Console.WriteLine("1. Add Contact");
    Console.WriteLine("2. Display All Contacts");
    Console.WriteLine("3. Search Contact");
    Console.WriteLine("4. Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine();

    if (choice == "1")
        AddContact();
    else if (choice == "2")
        DisplayAll();
    else if (choice == "3")
        SearchContact();
    else if (choice == "4")
        break;
    else
        Console.WriteLine("Invalid option, try again.");
}

Console.WriteLine("Goodbye!");

public class Contact
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public Contact(string name, string phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name} | Phone: {Phone} | Email: {Email}");
    }
   
}