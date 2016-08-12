using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace LoLADCGuide
{
    [Activity(Label = "WinRateActivity", Theme = "@android:style/Theme.NoTitleBar")]
    public class WinRateActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.WinRateLayout);
            ImageButton jinxPic = FindViewById<ImageButton>(Resource.Id.imgBtnJinx);
            jinxPic.Click += delegate { StartActivity(typeof(WinRateWebActivity)); } ;
            // Create your application here
        }
    }
}