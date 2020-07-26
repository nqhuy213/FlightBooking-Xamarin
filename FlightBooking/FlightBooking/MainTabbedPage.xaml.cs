using FlightBooking.Base;
using FlightBooking.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace FlightBooking
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : Xamarin.Forms.TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            var SearchPage = new BaseNavigationPage(Resolver.Resolve<MainView>()) {
                IconImageSource = (ImageSource) App.Current.Resources["AirplaneIcon"],
                Title = "Search"
            };
            var BoardingPage = new BaseNavigationPage(Resolver.Resolve<BoardingPassView>())
            {
                IconImageSource = (ImageSource)App.Current.Resources["BoardingPassIcon"],
                Title = "Boarding"
            }; 
            var CheckInPage = new BaseNavigationPage(Resolver.Resolve<CheckInView>())
            {
                IconImageSource = (ImageSource)App.Current.Resources["CheckinIcon"],
                Title = "Check-in"
            }; 
            var MorePage = new BaseNavigationPage(Resolver.Resolve<MoreView>())
            {
                IconImageSource = (ImageSource)App.Current.Resources["MoreIcon"],
                Title = "More"
            };
            Children.Add(SearchPage);
            Children.Add(BoardingPage);
            Children.Add(CheckInPage);
            Children.Add(MorePage);
        }
    }
}