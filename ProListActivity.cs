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
    [Activity(Label = "ProListActivity", Theme = "@android:style/Theme.NoTitleBar")]
    public class ProListActivity : Activity
    {
        string[] items;
        ListView listView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ProListActivityLayout);
            listView = FindViewById<ListView>(Resource.Id.listPro);
            items = new string[] { "PraY", "Deft", "Pilot", "Bang", "Sneaky"};
            listView.Adapter = new ProArrayAdapter(this, items);
            listView.ItemClick += OnListItemClick;

            // Create your application here
        }
        void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {

            var listView = sender as ListView;
            String item = items[e.Position];
            var infoActivity = new Intent(this, typeof(ProInfo));
            infoActivity.PutExtra("ProName", item);
            StartActivity(infoActivity);

        }
    }
}