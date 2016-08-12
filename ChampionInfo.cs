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
    [Activity(Label = "ChampionInfo", Theme = "@android:style/Theme.NoTitleBar")]
    public class ChampionInfo : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            string ChampName = Intent.GetStringExtra("ChampionName") ?? "Data not available";
            

            if (ChampName.Equals("Caitlyn"))
            {
                SetContentView(Resource.Layout.caitlyn);
            }
            else if (ChampName.Equals("Jinx"))
            {
                SetContentView(Resource.Layout.jinx);
            }
            else if (ChampName.Equals("Sivir"))
            {
                SetContentView(Resource.Layout.sivir);
            }
            else if (ChampName.Equals("Ashe"))
            {
                SetContentView(Resource.Layout.ashe);
            }
            else if (ChampName.Equals("Corki"))
            {
                SetContentView(Resource.Layout.corki);
            }
            else if (ChampName.Equals("Vayne"))
            {
                SetContentView(Resource.Layout.vayne);
            }
            else
            {
                SetContentView(Resource.Layout.ashe);
            }



        }
    }
}