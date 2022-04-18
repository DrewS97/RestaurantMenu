using System;

namespace RestaurantMenu
{
    public class MenuItems
    {
        public string Name {get; set;}
	    public string Description {get; set;}
	    public string Category {get; set;}
	    public double Price {get; set;}
	    public DateTime TimeAdded {get; set;}

        public MenuItems(string name, string desc, string cat, double price, DateTime timeAdded)
        {
            Name = name;
		    Description = desc;
		    Category = cat;
		    Price = price;
		    TimeAdded = timeAdded;
        }

        public MenuItems(string name, string desc, string cat, double price)
            : this(name, desc, cat, price, DateTime.Now) {}
    }
}
