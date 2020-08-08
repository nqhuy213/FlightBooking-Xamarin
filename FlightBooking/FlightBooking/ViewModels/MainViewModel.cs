using FlightBooking.Models;
using FlightBooking.Models.NavigationData;
using FlightBooking.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FlightBooking.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        #region Properties
        public bool IsRoundTrip { get; set; } = true;
        public bool IsOneWay
        {
            get { return !IsRoundTrip; }
        }
        public SlideEntryModel EntryModel { get; set; }
        public SearchResultModel SearchResult { get; set; }
        public ValidationPopupViewModel validation { get; set; } 
        public ICommand ToggleRoundTrip => new Command(() =>
        {
            IsRoundTrip = true;
        });
        public ICommand ToggleOneWay => new Command(() =>
        {
            IsRoundTrip = false;
        });
        public ICommand OpenPassengerEntryCommand => new Command(async () =>
        {
            await _navigationService.NavigateToAsync<PassengerPopupViewModel>(SearchResult.Passengers);
            
        });
        public ICommand SearchFlightCommand => new Command(async () =>
        {
            if (IsValidated())
            {

            }
            else
            {
                await _navigationService.NavigateToAsync<ValidationPopupViewModel>(validation);
            }
        });
        private bool IsValidated()
        {
            validation = new ValidationPopupViewModel();
            bool result = true;
            if (SearchResult.FromCity == null)
            {
                validation.MissingDeparture = true;
                result = false;
            }
            if (SearchResult.ToCity == null)
            {
                validation.MissingDestination = true;
                result = false;
            }
            return result;
        }
        #endregion
        #region Constructor
        public MainViewModel()
        {
            EntryModel = Resolver.Resolve<SlideEntryModel>();
            SearchResult = Resolver.Resolve<SearchResultModel>();
        }
        #endregion
    }
}
