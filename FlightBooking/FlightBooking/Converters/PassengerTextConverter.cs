using FlightBooking.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace FlightBooking.Converters
{
    public class PassengerTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var searchModel = (PassengersModel)value;
            string Text = "";
            string adult = "";
            string child = "";
            string baby = "";
            if(searchModel.Adults > 0)
            {
                if(searchModel.Adults == 1)
                {
                    adult = "1 Adult";
                }
                else
                {
                    adult = $"{searchModel.Adults} Adults";
                }
            }
            if(searchModel.Childs > 0)
            {
                if (searchModel.Childs == 1)
                {
                    child = "1 Child";
                }
                else
                {
                    child = $"{searchModel.Childs} Childs";
                }
            }
            if (searchModel.Babies > 0)
            {
                if (searchModel.Babies == 1)
                {
                    baby = "1 Baby";
                }
                else
                {
                    baby = $"{searchModel.Babies} Babies";
                }
            }
            Text += adult + " " + child + " " + baby;
            return Text;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string text = (string)value;
            string[] num = Regex.Split(text, @"\D+");
            var passenger = new PassengersModel();
            for (int i = 0; i < num.Length; i++)
            {
                if(i == 0)
                {
                    passenger.Adults = int.Parse(num[i]);
                }else if(i == 1)
                {
                    passenger.Childs = int.Parse(num[i]);
                }
                else if (i == 2)
                {
                    passenger.Childs = int.Parse(num[i]);
                }
            }
            
            return passenger;
        }
    }
}
