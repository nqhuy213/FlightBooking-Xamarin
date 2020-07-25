using FlightBooking.Services.Navigation;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlightBooking
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var navigationService = Resolver.Resolve<INavigationService>();
            navigationService.InitializeAsync();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
