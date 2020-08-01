using FlightBooking.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightBooking.ViewModels
{
    public class PassengersModel: BaseViewModel
    {
        public int Adults { get; set; } = 1;
        public int Childs { get; set; } = 0;
        public int Babies { get; set; } = 0;
        public string PassengerText
        {
            get
            {
                string Text = "";
                string adult = "";
                string child = "";
                string baby = "";
                if (Adults > 0)
                {
                    if (Adults == 1)
                    {
                        adult = "1 Adult";
                    }
                    else
                    {
                        adult = $"{Adults} Adults";
                    }
                }
                if (Childs > 0)
                {
                    if (Childs == 1)
                    {
                        child = "  -  1 Child";
                    }
                    else
                    {
                        child = $"  -  {Childs} Childs";
                    }
                }
                if (Babies > 0)
                {
                    if (Babies == 1)
                    {
                        baby = "  -  1 Baby";
                    }
                    else
                    {
                        baby = $"  -  {Babies} Babies";
                    }
                }
                Text += adult + child  + baby;
                return Text.Trim() ;
            }
        }
    }
}
