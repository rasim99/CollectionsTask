using System.Text.RegularExpressions;

namespace SocialMediaTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SocialMedia sm=new SocialMedia();
          while (true)
            {
                DisplayMenu();
                string input =Console.ReadLine();
                int operation;
                bool isSuccessed=int.TryParse(input, out operation);
                if (isSuccessed)
                {
                    switch (operation)
                    {
                        case 0:
                        return;
                        case 1:
                            AddFriend(sm);
                        break;
                        case 2:
                           Console.WriteLine("enter user Name");
                            string usName=Console.ReadLine();
                            Console.WriteLine("enter friend Name");
                            string frName =Console.ReadLine();
                            sm.RemoveFriend(usName,frName);
                        break;
                        case 3:
                            Console.WriteLine(" enter user name for see user's all friends");
                            string uName=Console.ReadLine();
                                sm.GetAllFriendsByUsername(uName);
                        break;
                        case 4:
                            sm.DisplayUsers();
                        break;
                        default:
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("invalid input!!!");
                }
            }

        }

        static void DisplayMenu()
        {
            Console.WriteLine("--- MENU ---");
            Console.WriteLine("1 - AddFriend \n 2 - RemoveFriend \n 3 - GetAllFriendsByUsername \n 4 -DisplayUserse \n 0 -Exit");
        }
        static void AddFriend(SocialMedia sm)
        {
        userNameDesc: Console.WriteLine("enter user name");
            string userName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("userName cannot be empty or whitespace");
                goto userNameDesc;
            }
            if (!Regex.IsMatch(userName, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("please enter only letters");
                goto userNameDesc;
            }
        friendNameDesc: Console.WriteLine("enter friend name");
            string friendName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("Friend Name cannot be empty or whitespace");
                goto friendNameDesc;
            }
            if (!Regex.IsMatch(friendName, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("please enter only letters");
                goto friendNameDesc;
            }
            
            sm.AddFriend(userName.ToLower(), friendName.ToLower());
        }
    }
}
