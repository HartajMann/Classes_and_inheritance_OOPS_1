using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_inheritance_OOPS_1
{
    //child class of appliances
    public class Dishwasher : Appliance
    {
        // declaring private variables
        private string feature;
        private string soundRating;

        // parameterized constructor
        public Dishwasher(long itemNumber, string brand, int quantity, double wattage, string color, double price, string feature, string soundRating) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            Feature = feature;
            SoundRating = soundRating;
        }

        // tostring method
        public override string ToString()
        {
            return $"Item_Number:{ItemNumber}\n" + $"Brand:{Brand}\n" + $"Quantity:{Quantity}\n" + $"Wattage:{Wattage}\n" + $"Color:{Color}\n" + $"Price:{Price}\n" + $"Feature:{Feature}\n" + $"SoundRating:{SoundRating}\n";
        }
        // getters and setters
        public string Feature { get => feature; set => feature = value; }
        public string SoundRating
        {
            get => soundRating; set
            {
                if (value == "Qt")
                {
                    soundRating = "Quietest";
                }
                else if(value=="Qr")
                {
                    soundRating = "Quieter";
                }
                else if (value == "Qu")
                {
                    soundRating = "Quiet";
                }
                else if (value == "M")
                {
                    soundRating = "Moderate";
                }
            }

        }
        // method for formatting text
        public override string Formatforfile()
        {
            if(soundRating== "Quietest")
            {
                soundRating = "Qt";
            }
            else if(soundRating== "Quieter")
            {
                soundRating = "Qr";
            }
            else if(soundRating== "Quiet")
            {
                soundRating = "Qu";
            }
            else
            {
                soundRating = "M";
            }
            string[] args =
            {
                base.Formatforfile(),feature,soundRating
            };
            return string.Join(";", args);
    }
    }
}