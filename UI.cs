using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantMenu
{
    public class UI
    {
        public static void UIFunction()
        {
            PrintOptions();
            string choice = Convert.ToString(Console.ReadLine());
            while(choice != "q")
            {
                switch(choice)
                {
                    case "1":
                        Menu.PrintMenu();
                        break;
                    case "2":
                        Menu.AddItemPrompt();
                        break;
                    case "3":
                        Menu.RemoveItemPrompt();
                        break;
                    case "q":
                        Console.WriteLine("Have a Wonderful Day!");
                        break;
                    default:
                        Console.WriteLine("Please enter either 1, 2, 3, or q");
                        break;
                }
                
                if(choice != "q")
                {
                    PrintOptions();
                    choice = Convert.ToString(Console.ReadLine());
                }
            }
        }

        public static void PrintOptions()
        {
            Console.WriteLine("[1] Show Menu");
            Console.WriteLine("[2] Add New Item");
            Console.WriteLine("[3] Remove Item");
            Console.WriteLine("Enter q to quit");
        }
    }
}