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
    [Activity(Label = "ChampionListActivity", Theme = "@android:style/Theme.NoTitleBar")]
    public class ChampionListActivity : Activity
    {
        string[] items;
        ListView listView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ChampionListActivityLayout);
            listView = FindViewById<ListView>(Resource.Id.list);
            items = new string[] { "Ashe", "Caitlyn", "Corki", "Jinx", "Sivir", "Vayne"  };
            listView.Adapter = new ChampionArrayAdapter(this, items);
            listView.ItemClick += OnListItemClick;
           
        }
     
        void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            
            var listView = sender as ListView;
            String item = items[e.Position];
            var infoActivity = new Intent(this, typeof(ChampionInfo));
            infoActivity.PutExtra("ChampionName", item);
            StartActivity(infoActivity);

        }
    }
}