using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_inheritance_OOPS_1
{
    //Parent class
    public class Appliance
    {
        // declaring private variables 
        private long itemNumber;
        private string brand;
        private int quantity;
        private double wattage;
        private string color;
        private double price;

        // parameterized constructor
        public Appliance(long itemNumber, string brand, int quantity, double wattage, string color, double price)
        {
            ItemNumber = itemNumber;
            Brand = brand;
            Quantity = quantity;
            Wattage = wattage;
            Color = color;
            Price = price;
        }

        public Appliance()
        {
        }

        //getters and setters
        public long ItemNumber { get => itemNumber; set => itemNumber = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Wattage { get => wattage; set => wattage = value; }
        public string Color { get => color; set => color = value; }
        public double Price { get => price; set => price = value; }
        
        // bool method to check quantity
        public bool isAvaliable()
        {
            return Quantity>0;
        }
        // method for checking out certaing item
        public void checkout(long number)
        {
            if (isAvaliable())
            {
                Quantity--;
                Console.WriteLine("Appliance "+ itemNumber +" has been checked out.");
            }
            else
            {
                Console.WriteLine("The appliance is not available to be checked out.");
            }
        }
        // method for formatting text
        public virtual string Formatforfile()
        {
            string[] args =
            {
                itemNumber.ToString(),brand,quantity.ToString(),wattage.ToString(),color,price.ToString()
            };
            return string.Join(";", args);
        }
        // tostring method
        public override string ToString()
        {
            return $"Item_Number:{ItemNumber}\n" + $"Brand:{Brand}\n" + $"Quantity:{Quantity}\n" + $"Wattage:{Wattage}\n" + $"Color:{Color}\n" + $"Price:{Price}\n";
        }
    }
}
