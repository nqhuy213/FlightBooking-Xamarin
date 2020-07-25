using FlightBooking.Base;
using FlightBooking.ViewModels;
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
    public partial class CheckInView : BaseContentPage<CheckInViewModel>
    {
        public CheckInView()
        {
            InitializeComponent();
        }
    }
}