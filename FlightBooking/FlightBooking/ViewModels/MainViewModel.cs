using FlightBooking.Models;
using FlightBooking.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FlightBooking.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        #region Fields
        private bool isRoundTrip = true;

        #endregion

        #region Properties
        public bool IsRoundTrip
        {
            get
            {
                return isRoundTrip;
            }
            set
            {
                isRoundTrip = value;
                OnPropertyChanged();
            }
        }
        public SlideEntryModel EntryModel { get; set; } = Resolver.Resolve<SlideEntryModel>();
        public ICommand ToggleRoundTrip => new Command(() =>
        {
            IsRoundTrip = true;
        });
        public ICommand ToggleOneWay => new Command(() =>
        {
            IsRoundTrip = false;
        });
        #endregion
    }
}
