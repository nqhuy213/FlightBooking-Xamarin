using FlightBooking.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FlightBooking.Base
{
    public abstract class BaseContentPage<T> : ContentPage where T : BaseViewModel
    {
        public T ViewModel { get; private set; }
        public BaseContentPage()
        {
            var viewModel = Resolver.Resolve<T>() as BaseViewModel;
            BindingContext = viewModel;
            ViewModel = (T)viewModel;
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ViewModel.OnDisappearing();
        }
    }
}
