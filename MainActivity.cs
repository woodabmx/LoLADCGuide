using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace LoLADCGuide
{
    [Activity(Label = "LoLADCGuide", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.NoTitleBar")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button btnChampions = FindViewById<Button>(Resource.Id.btnChampions);
            Button btnMontage = FindViewById<Button>(Resource.Id.btnMontages);
            Button btnPros = FindViewById<Button>(Resource.Id.btnBuilds);
            Button btnTips = FindViewById<Button>(Resource.Id.btnTips);
            Button btnWinRate = FindViewById<Button>(Resource.Id.btnWinRates);
           // ImageButton imgBtnLogo = FindViewById<ImageButton>(Resource.Id.imgBtnLogo);
            
            btnChampions.Click += delegate { StartActivity(typeof(ChampionListActivity)); };
            btnWinRate.Click += delegate { StartActivity(typeof(WinRateActivity)); };
            btnTips.Click += delegate { StartActivity(typeof(TipsActivity)); };
            btnPros.Click += delegate { StartActivity(typeof(ProListActivity)); };
            btnMontage.Click += delegate { StartActivity(typeof(VideoActivity)); };
           /* imgBtnLogo.Click += delegate {
                var uri = Android.Net.Uri.Parse("http://oce.leagueoflegends.com");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };*/
        }
    }
}

