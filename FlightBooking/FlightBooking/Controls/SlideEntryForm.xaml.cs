using FlightBooking.Models;
using FlightBooking.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlightBooking.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SlideEntryForm : ContentView
    {
        public static readonly BindableProperty EntryModelProperty = BindableProperty.Create(nameof(EntryModel), typeof(SlideEntryModel), 
            typeof(SlideEntryForm),null, BindingMode.TwoWay);
        public static readonly BindableProperty ShouldSwitchViewProperty = BindableProperty.Create(nameof(ShouldSwitchView), typeof(bool), 
            typeof(SlideEntryForm), false, BindingMode.TwoWay);
        public static readonly BindableProperty SearchResultModelProperty = BindableProperty.Create(nameof(SearchResultModel), typeof(SearchResultModel),
            typeof(SlideEntryForm), null, BindingMode.TwoWay);
        public bool ShouldSwitchView
        {
            get { return (bool)GetValue(ShouldSwitchViewProperty); }
            set 
            {
                SetValue(ShouldSwitchViewProperty, value);
            }
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == nameof(ShouldSwitchView))
            {
                if (ShouldSwitchView)
                {
                    Device.BeginInvokeOnMainThread( () => TranslateLeftAsync());
                }
                else
                {
                    Device.BeginInvokeOnMainThread( () => TranslateRightAsync());
                }
            }
        }
        public SlideEntryForm()
        {
            InitializeComponent();

        }

        private void TranslateRightAsync()
        {
            RoundTripEntriesLayout.TranslateTo(0, 0, 250, Easing.SinIn);
            OneWayEntriesLayout.TranslateTo(0, 0, 250, Easing.SinIn);
        }

        private void TranslateLeftAsync()
        {
            RoundTripEntriesLayout.TranslateTo(-600, 0, 250, Easing.SinIn);
            OneWayEntriesLayout.TranslateTo(-600, 0, 250, Easing.SinIn);

        }

        public SlideEntryModel EntryModel 
        { 
            get { return (SlideEntryModel)GetValue(EntryModelProperty); }
            set { SetValue(EntryModelProperty, value); OnPropertyChanged(); } 
        }
        public SearchResultModel SearchResultModel
        {
            get { return (SearchResultModel)GetValue(SearchResultModelProperty); }
            set { SetValue(SearchResultModelProperty, value); OnPropertyChanged(); }
        }
    }
}