using FlightBooking.Services.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking.ViewModels.Base
{
    public abstract class BaseViewModel: INotifyPropertyChanged
    {
        protected readonly INavigationService _navigationService;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public BaseViewModel()
        {
            _navigationService = Resolver.Resolve<INavigationService>();
        }
        public virtual void OnAppearing()
        {

        }
        public virtual void OnDisappearing()
        {

        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}
