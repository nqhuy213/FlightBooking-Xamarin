using FlightBooking.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FlightBooking.ViewModels
{
    public class ValidationPopupViewModel: BaseViewModel
    {
        public bool MissingDeparture { get; set; } = false;
        public bool MissingDestination { get; set; } = false;
        public ICommand ClosePopupCommand => new Command(async () => {
            await _navigationService.ClosePopupAsync();
        });
        public override Task InitializeAsync(object navigationData)
        {
            var data = (ValidationPopupViewModel)navigationData;
            MissingDeparture = data.MissingDeparture;
            MissingDestination = data.MissingDestination;
            return base.InitializeAsync(navigationData);
        }
    }
}
