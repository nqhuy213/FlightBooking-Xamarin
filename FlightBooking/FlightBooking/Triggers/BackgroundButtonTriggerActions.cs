using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FlightBooking.Triggers
{
    public class BackgroundButtonTriggerActions : TriggerAction<VisualElement>
    {
        public Color BackgroundColor { get; set; }
        protected override void Invoke(VisualElement sender)
        {
            var button = sender as Button;
            if (button == null) return;
            if (BackgroundColor != null) button.BackgroundColor = BackgroundColor;
        }
    }
}
