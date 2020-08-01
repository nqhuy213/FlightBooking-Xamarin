using FlightBooking.Base;
using FlightBooking.ViewModels;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlightBooking.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PassengerPopupView : BasePopupPage<PassengerPopupViewModel>
    {
        public PassengerPopupView()
        {
            InitializeComponent();
        }
        
    }
}