// See https://aka.ms/new-console-template for more information
using AddressBook_Programs;
using static AddressBook_Programs.AddressBookEntry;

Console.WriteLine("====Welcome to Address Book Program====");
Console.WriteLine("==========Welcome To Address Book Program==========");
Console.Write("Select Number:\n1)AddContacts\n2)EditContact\n");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        new Contact();
        break;
    case 2:
        EditEntry.NewContact();
        EditEntry.ListAllContact();
        EditEntry.Update();
        break;
    default:
        Console.Write("Please Select Correct Number");
        break;

}