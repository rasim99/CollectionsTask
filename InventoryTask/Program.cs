namespace InventoryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            while (true)
            {
                 DisplayMenu();
                string input=Console.ReadLine();
                int opeartion;
                bool isSuccessed=int.TryParse(input, out opeartion);
                if (isSuccessed)
                {
                    switch (opeartion)
                    {
                        case 0:
                            return;
                            case 1:
                            productNameDESC: Console.WriteLine("enter product Name");
                              string productName=Console.ReadLine();
                            if (productName.Replace(" ","").Length>2)
                            {
                                QuantityDesc: Console.WriteLine("enter quantity");
                                string qunatityInput=Console.ReadLine();
                                int quantity;
                                isSuccessed=int.TryParse(qunatityInput, out quantity);
                                if (isSuccessed)
                                {
                                    inventory.AddProduct(productName.Replace(" ",""),quantity);
                                }
                                else
                                {
                                    Console.WriteLine("invalid input enter correct input");
                                    goto QuantityDesc;
                                }
                            }
                            else
                            {
                                Console.WriteLine("please enter minimum 3 character");
                                goto productNameDESC;
                            }
                            break;
                            case 2:
                              Console.WriteLine("enter product name of removed");
                              string productNameOfRemoved= Console.ReadLine();
                             inventory.RemoveProduct(productNameOfRemoved);
                                break;
                            case 3:
                            Console.WriteLine("enter name of update quantity");
                             string prodName=Console.ReadLine();
                            Console.WriteLine("enter quantity");
                            string updteInput=Console.ReadLine();
                            int updateQuantity;
                            if (int.TryParse(updteInput,out updateQuantity))
                            {
                                inventory.UpdateQuantity(prodName,updateQuantity);
                            }
                            else
                            {
                                Console.WriteLine("invalid input!!");
                            }
                            break;

                            case 4:
                            Console.WriteLine("enter product name of Displaying");
                            string prodNameDisplaying = Console.ReadLine();
                            inventory.GetQuantityByProduct(prodNameDisplaying);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(" Wrong Operation!");
                }
            }

        }
        static void DisplayMenu()
        {
            Console.WriteLine("___ MENU ___ \n");
            Console.WriteLine("1- AddProduct \n 2 - RemoveProduct" +
                " \n 3 - UpdateQuantity \n 4 - GetQuantityByProduct \n 0 - Exit");
        }
    }
}
