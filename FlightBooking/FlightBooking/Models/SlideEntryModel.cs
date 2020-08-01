using FlightBooking.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightBooking.Models
{
    public class SlideEntryModel: BaseViewModel
    {

        public List<string> FromCity { get; set; } = new List<string>()
        {
            "Tokyo"
        };
        public List<string> ToCity { get; set; }

    }
}
