using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_inheritance_OOPS_1
{
    // chid class of appliances
    public class Microwave : Appliance
    {
        // declaring private variables
        private double capacity;
        private string roomtype;

        // Parameterized constructor
        public Microwave(long itemNumber, string brand, int quantity, double wattage, string color, double price, double capacity, string roomtype) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            Capacity = capacity;
            Roomtype = roomtype;
        }

        // tostring method
        public override string ToString()
        {
            return $"Item_Number:{ItemNumber}\n" + $"Brand:{Brand}\n" + $"Quantity:{Quantity}\n" + $"Wattage:{Wattage}\n" + $"Color:{Color}\n" + $"Price:{Price}\n" + $"Capacity:{Capacity}\n" + $"RoomType:{Roomtype}\n";
        }
        // getters and setters
        public double Capacity { get => capacity; set => capacity = value; }
        public string Roomtype
        {
            get => roomtype; set
            {
                {
                    if (value == "K")
                    {
                        roomtype = "Kitchen";
                    }
                    else
                    {
                        roomtype = "work site";
                    }
                }
            }
        }
        // method for formatting text
        public override string Formatforfile()
        {
            if(roomtype=="Kitchen")
            {
                roomtype = "K";
            }
            else
            {
                roomtype = "W";
            }
            string[] args =
            {
                base.Formatforfile(),capacity.ToString(),roomtype
            };
            return string.Join(";",args);
        }
    }
}
