using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_inheritance_OOPS_1
{
    // child class of appliances
    public class Vacuum : Appliance
    {
        // declaring private variables
        private string grade;
        private string batteryVoltage;
        // Parameterized constructor
        public Vacuum(long itemNumber, string brand, int quantity, double wattage, string color, double price, string grade, string batteryVoltage) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            Grade = grade;
            BatteryVoltage = batteryVoltage;
        }
        // tostring method
        public override string ToString()
        {
            return $"Item_Number:{ItemNumber}\n" + $"Brand:{Brand}\n" + $"Quantity:{Quantity}\n" + $"Wattage:{Wattage}\n" + $"Color:{Color}\n" + $"Price:{Price}\n" + $"Grade:{Grade}\n" + $"BatteryVoltage:{BatteryVoltage}\n";
        }
        // getters and setters
        public string Grade { get => grade; set => grade = value; }
        public string BatteryVoltage
        {
            get => batteryVoltage; set
            {
                if (value == "18")
                { batteryVoltage = "Low"; }
                else
                {
                    batteryVoltage = "High";
                }
                
            }

        }
        // method for formatting text
        public override string Formatforfile()
        {
            if(batteryVoltage== "Low")
            {
                batteryVoltage= "18";
            }
            else
            {
                batteryVoltage = "24";
            }
            string[] args =
            {
                base.Formatforfile(),grade,batteryVoltage
            };
            return string.Join(";", args);
        }
    }
}