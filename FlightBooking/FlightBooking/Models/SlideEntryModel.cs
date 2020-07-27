using FlightBooking.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightBooking.Models
{
    public class SlideEntryModel: BaseViewModel
    {

        public List<string> FromCity { get; set; }
        public List<string> ToCity { get; set; }
        public DateTime Departure { get; set; } = new DateTime();
        public DateTime Return { get; set; } = new DateTime();
    }
}
