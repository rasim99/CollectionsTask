using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaTask
{
    internal class SocialMedia
    {
       public Dictionary<string, List<string>> Friends {  get;private set; }
        public SocialMedia()
        {
            Friends = new Dictionary<string, List<string>>();
        }
        public void AddFriend(string userName,string friendName)
        {
            if (Friends.ContainsKey(userName))
            {
               if (!Friends[userName].Contains(friendName))
               {
                    Friends[userName].Add(friendName);
               }
                else
                {
                    Console.WriteLine($"{friendName} is already exists");
                }
            }
            else
            {
                Friends[userName] = new List<string> {friendName};
            }
        }
        public void RemoveFriend(string userName,string friendName)
        {
           if(Friends.ContainsKey(userName))
           {
                if (Friends[userName].Contains(friendName))
                {
                  Friends[userName].Remove(friendName);
                }
                else
                {
                    Console.WriteLine($"{userName} has not friend  with name of {friendName}");
                }
           }
           else
           {
                Console.WriteLine($"{userName} is not found");
           }
        }

       public void GetAllFriendsByUsername(string userName)
        {
            if (Friends.ContainsKey(userName.ToLower()))
            {
                Console.WriteLine($"{userName} ' s friend(s)");
                foreach (var friend in Friends[userName])
                {
                    Console.WriteLine(friend);
                }
            }
            else
            {
                Console.WriteLine($" dont have user with name of  {userName}");
            }
        }
        public void DisplayUsers()
        {
            if (Friends.Keys.Count==0)
            {
                Console.WriteLine(" have not any users");

            }
            foreach (var user in Friends)
            {
                
                Console.WriteLine(user.Key);
            }
        }
    }
}
