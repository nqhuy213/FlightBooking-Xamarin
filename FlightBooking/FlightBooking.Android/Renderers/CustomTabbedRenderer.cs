using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

namespace FlightBooking.Droid.Renderers
{
    class CustomTabbedRenderer: TabbedRenderer
    {
        public CustomTabbedRenderer(Context context): base(context) { }
        protected override void DispatchDraw(Canvas canvas)
        {
            base.DispatchDraw(canvas);
            SetTabIcon();
        }

        private void SetTabIcon()
        {
            var element = this.Element;
            if (Element == null) return;
            Activity activity = this.Context as Activity;
            if ((null != activity) && (null != activity.ActionBar) && (activity.ActionBar.TabCount > 0))
            {
                for (int i = 0; i < element.Children.Count; i++)
                {
                    var tab = activity.ActionBar.GetTabAt(i);
                    var page = element.Children[i];
                }
            }
        }
    }
}