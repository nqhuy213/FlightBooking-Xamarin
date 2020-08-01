using FlightBooking.ViewModels.Base;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightBooking.Base
{
    public class BasePopupPage<T>: PopupPage where T: BaseViewModel
    {
        public T ViewModel { get; private set; }
        public BasePopupPage()
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
