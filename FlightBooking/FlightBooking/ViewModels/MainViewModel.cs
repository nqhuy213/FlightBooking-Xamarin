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
