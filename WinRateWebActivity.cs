using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Webkit;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace LoLADCGuide
{
    [Activity(Label = "WinRateWebActivity", Theme = "@android:style/Theme.NoTitleBar")]
    public class WinRateWebActivity : Activity
    {
        WebView web_view1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.WebViewWinRate);
            web_view1 = FindViewById<WebView>(Resource.Id.webview1);
            web_view1.Settings.JavaScriptEnabled = true;
            web_view1.LoadUrl("https://champion.gg/champion/Jinx");
        }
    }
}