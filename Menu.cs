using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantMenu
{
    public class Menu
    {
        public static List<MenuItems> Items = new List<MenuItems>();
        public static List<string> CategoryList = new List<string>() {"Appetizer", "Burger", "Seafood", "Sides", "Dessert"};

        public static void AddItemPrompt()
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Description:");
            string desc = Console.ReadLine();

            //Ensure that only approves categories get chosen
            bool correctCat = false;
            string cat = "";

            while(correctCat == false)
            {
                Console.WriteLine("Category (Appetizer, Burger, Seafood, Sides, or Dessert):");
                cat = Console.ReadLine();
                foreach(string cats in CategoryList)
                {
                    if(cat == cats)
                    {
                        correctCat = true;
                        break;
                    }
                }
            }
            
            Console.WriteLine("Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            AddItem(name, desc, cat, price);
        }

        public static void AddItem(string name, string desc, string cat, double price)
        {
            Items.Add(new MenuItems(name, desc, cat, price));
        }

        public static void RemoveItemPrompt()
        {
            Console.WriteLine("Write the name of the item you would like to remove.");
            string item = Console.ReadLine();
            RemoveItem(item);
        }

        public static void RemoveItem(string name)
        {
            var item = Items.Find(x=>x.Name == name);
            Items.Remove(item);
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Welcome to ???\n\n");
            
            foreach(string category in CategoryList)
            {
                Console.WriteLine(category);
                Console.WriteLine($"-----------------------");
                foreach(MenuItems item in Items)
                {
                    if(item.Category == category)
                    {
                        Console.WriteLine($"Name: {item.Name}");
                        Console.WriteLine($"Description: {item.Description}");
                        Console.WriteLine($"Price: {item.Price}");
                    }
                }
                Console.WriteLine($"-----------------------\n");
            }
        }
    }
}
