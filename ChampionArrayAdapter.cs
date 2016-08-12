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
    class ChampionArrayAdapter : BaseAdapter<String>
    {
        string[] items;
        Activity context;

        public ChampionArrayAdapter(Activity context, string[] items)
		{
			this.context = context;
			this.items = items;
		}
		public override long GetItemId(int position)
		{
			return position;
		}
		public override string this[int position]
		{
			get { return items[position]; }
		}
		public override int Count
		{
			get { return items.Length; }
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			LayoutInflater inflator = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);

			View rowView = inflator.Inflate(Resource.Layout.ChampionListLayout, parent, false);

			TextView textView = (TextView)rowView.FindViewById<TextView>(Resource.Id.label);
			ImageView imageView = (ImageView)rowView.FindViewById<ImageView>(Resource.Id.imageViewIcon);

			textView.Text = (items[position]);


			String s = items[position];

			if (s.StartsWith("Ashe"))
			{
				imageView.SetImageResource(Resource.Drawable.ashe);
			}
			else if (s.StartsWith("Jinx"))
			{
				imageView.SetImageResource(Resource.Drawable.jinx);
			}
			else if (s.StartsWith("Vayne"))
			{
				imageView.SetImageResource(Resource.Drawable.vayne);
			}
			else if (s.StartsWith("Corki"))
			{
				imageView.SetImageResource(Resource.Drawable.corki);
			}
			else if (s.StartsWith("Sivir"))
			{
				imageView.SetImageResource(Resource.Drawable.sivir);
			}
			else if (s.StartsWith("Caitlyn"))
			{
				imageView.SetImageResource(Resource.Drawable.caitlyn);
			}
			return rowView;
		}


    }
}