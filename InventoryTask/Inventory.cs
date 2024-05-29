using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTask
{
    internal class Inventory
    {
        public Dictionary<string,int> Products { get; private set; }
        public Inventory()
        { 
         Products = new Dictionary<string,int>();
        }

        public void AddProduct( string productName,int quantity)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                Console.WriteLine("product name can not empty");
                return;
            }
            if (quantity<1)
            {
                Console.WriteLine("quantity must be minimum 1");
                return; 
            }
            if (!Products.ContainsKey(productName))
            {
                Products.Add(productName, quantity);
                Console.WriteLine($" {quantity} {productName} added");
            }
            else
            {
                Products[productName] += quantity;
            }
        }

        public void RemoveProduct( string productName )
        {
            if (Products.ContainsKey(productName))
            {
                Products.Remove(productName);
            }
            else
            {
                Console.WriteLine($"{productName} is not found");
            }
        }
         
        public void UpdateQuantity(string productName, int quantity )
        {
            if (!Products.ContainsKey(productName))
            {
                Console.WriteLine($"{productName} is not found");
                return;
            }
            else
            {
                Products[productName] = quantity;
                Console.WriteLine($"{productName} updated . Now  quantity :{quantity}");
            }
        }

        public void GetQuantityByProduct(string productName)
        {
            if (Products.ContainsKey(productName))
            {
                Console.WriteLine($"{productName} have : " +Products[productName]);
            }
            else
            {
                Console.WriteLine("have not that product");
            }
        }

    }
}
