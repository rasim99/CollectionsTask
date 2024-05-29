using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_Task
{
    internal class PhoneBook
    {
        
        public Dictionary<string,string> Contacts { get; private set; }
        public PhoneBook()
        {
            Contacts = new Dictionary<string,string>();
        }
        public void  AddContact(string name,string phoneNumber)
        {
            if (!Contacts.Any(n=>n.Key.ToLower()==name.ToLower()))
            {
                Contacts[name] = phoneNumber;
                Console.WriteLine($"Success ! {name} added to Contacts ");
            }
            else
            {
                Console.WriteLine($"{name} already exists");
            }
        }

        public void RemoveContact(string name)
        {
            if (Contacts.ContainsKey(name))
            {
                Contacts.Remove(name);
                Console.WriteLine($"Success! {name}  is removed");
            }
            else
            {
                Console.WriteLine($"{name} is not found");
            }
        }
       
        public void  GetAllContacts()
        {
            if (!Contacts.Any())
            {
                Console.WriteLine("lis is empty");

            }
            foreach (var contact in Contacts)
            {
                Console.WriteLine($"Name : {contact.Key} Number : {contact.Value}"); 
            }
        }
        public void FindContactByName(string name)
        {
            if (Contacts.ContainsKey(name))
            {
                Console.WriteLine($"Name : {name} Phone Number : {Contacts[name]}");
            }
            else
            {
                Console.WriteLine(" do not have contact");
            }
        }
    }
}
