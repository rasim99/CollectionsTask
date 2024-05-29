using System.Text.RegularExpressions;

namespace PhoneBook_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            while (true)
            {
                DisplayMenu();
                string input =Console.ReadLine();
                int operation;
                bool isSuccessed = int.TryParse(input, out operation);
                if (isSuccessed)
                {
                    switch(operation)
                    {
                        case 0:
                            return;
                        case 1:
                            AddContactToPhoneBook(phoneBook);
                            break;
                            case 2:
                            string contactName=Console.ReadLine();
                            phoneBook.RemoveContact(contactName);
                            break;
                            case 3:
                            phoneBook.GetAllContacts();
                            break;
                            case 4:
                            Console.WriteLine("enter name of find contact");
                            contactName = Console.ReadLine();
                            phoneBook.FindContactByName(contactName);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! please valid number input");
                }


            }
        }
        static void DisplayMenu()
        {
            Console.WriteLine(" Choose one : \n 1 - AddContact " +
                " \n 2 - RemoveContact  \n 3 GetAllContacts \n 4 FindContactByName \n 0 -exit");
        }

        static void AddContactToPhoneBook(PhoneBook phoneBook)
        {
           
        ContactNameDesc: Console.WriteLine(" enter Contact Name : ");
            string contactName = Console.ReadLine();
            if (contactName.Replace(" ", "").Length < 3)
            {
                Console.WriteLine("please enter minimum 3");
                goto ContactNameDesc;
            }
        PrefixDesc: Console.WriteLine("enter prefix (any one 050/051/070/077/055/010/099)");
            string prefix = Console.ReadLine();
            if
                (prefix != "050" && prefix != "051" && prefix != "070"
                && prefix != "077" && prefix != "055" && prefix != "010" && prefix != "099")
            {
                Console.WriteLine("invalid prefix");
                goto PrefixDesc;
            }
        ContactNumberDesc: Console.WriteLine("enter contact number");
            string contactNumber = Console.ReadLine();
            char firstNumber = contactNumber[0];
            if (!Regex.IsMatch(contactNumber, @"^\d+$"))
            {
                Console.WriteLine("invalid number please normal number");
                goto ContactNumberDesc;
            }
            if (firstNumber == '1')
            {
                Console.WriteLine("cannot first number is 1");
                goto ContactNumberDesc;
            }
            if (contactNumber.Length != 7)
            {
                Console.WriteLine("please enter correct number  example: 2345678");
                goto ContactNumberDesc;
            }
            var resultNumber = prefix + contactNumber;
            phoneBook.AddContact(resultNumber, contactNumber);
        }
    }
}
