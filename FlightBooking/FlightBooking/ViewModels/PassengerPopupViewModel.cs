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
    public class PassengerPopupViewModel: BaseViewModel
    {
        #region Fields
        private int initialAdult;
        private int initialChild;
        private int initialBaby;
        #endregion
        #region Properties
        public PassengersModel Passengers { get; set; }

        public ICommand CancelCommand => new Command(async() =>
        {
            Passengers.Adults = initialAdult;
            Passengers.Childs = initialChild;
            Passengers.Babies = initialBaby;
            await _navigationService.ClosePopupAsync();
        });
        public ICommand DoneCommand => new Command(async () =>
        {
            await _navigationService.ClosePopupAsync();
        });

        public ICommand IncreaseAdultsCommand => new Command(() =>
        {
            Passengers.Adults += 1;
            
        });
        public ICommand DecreaseAdultsCommand => new Command(() =>
        {
            if(Passengers.Adults > 0) { Passengers.Adults -= 1; }
        });

        public ICommand IncreaseChildsCommand => new Command(() =>
        {
            Passengers.Childs += 1;
            
        });
        public ICommand DecreaseChildsCommand => new Command(() =>
        {
            if (Passengers.Childs > 0) { Passengers.Childs -= 1; }
        });

        public ICommand IncreaseBabiesCommand => new Command(() =>
        {
            Passengers.Babies += 1;
            
        });
        public ICommand DecreaseBabiesCommand => new Command(() =>
        {
            if (Passengers.Babies > 0) { Passengers.Babies -= 1;  }
        });
        #endregion
        #region Contructors
        public PassengerPopupViewModel()
        {
            
        }
        #endregion

        #region Methods
        public override Task InitializeAsync(object navigationData)
        {
            Passengers = (PassengersModel)navigationData;
            initialAdult = Passengers.Adults;
            initialChild = Passengers.Childs;
            initialBaby = Passengers.Babies;
            return base.InitializeAsync(navigationData);
        }
        #endregion
    }
}
