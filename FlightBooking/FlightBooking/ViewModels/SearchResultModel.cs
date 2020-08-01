using FlightBooking.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightBooking.ViewModels
{
    public class SearchResultModel: BaseViewModel
    {
        public string FromCity { get; set; }
        public string ToCity { get; set; }
        public DateTime Departure { get; set; } = DateTime.Now;
        public DateTime Return { get; set; } = DateTime.Now;
        public PassengersModel Passengers { get; set; } = new PassengersModel();
        public bool IsTouristClass { get; set; } = true;
    }
}
