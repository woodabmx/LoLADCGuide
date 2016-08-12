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
    [Activity(Label = "ProInfo", Theme = "@android:style/Theme.NoTitleBar")]
    public class ProInfo : Activity
    {
        WebView web_view;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.pray);
            string ProName = Intent.GetStringExtra("ProName") ?? "Data not available";
            web_view = FindViewById<WebView>(Resource.Id.webview);
            web_view.Settings.JavaScriptEnabled = true;
            

            if (ProName.Equals("PraY"))
            {
                web_view.LoadUrl("http://www.op.gg/summoner/matches/userName=%EC%82%B4%EA%B8%B0%EC%9E%A5%EC%9D%B8");
            }
            else if (ProName.Equals("Deft"))
            {
                web_view.LoadUrl("http://www.op.gg/summoner/matches/userName=EDG%20%EB%94%94%ED%94%84%ED%8A%B8");
            }
            else if (ProName.Equals("Bang"))
            {
                web_view.LoadUrl("http://www.op.gg/summoner/matches/userName=sktt1bang");
            }
            else if (ProName.Equals("Pilot"))
            {
                web_view.LoadUrl("http://www.op.gg/summoner/matches/userName=jinairpilot");
            }
            else if (ProName.Equals("Sneaky"))
            {
                web_view.LoadUrl("http://na.op.gg/summoner/matches/userName=c9sneaky");
            }
            else
            {
                web_view.LoadUrl("http://www.op.gg/spectate/list/");
            }

        }
    }
}