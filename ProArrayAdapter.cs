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
    class ProArrayAdapter : BaseAdapter<String>
    {
        string[] items;
        Activity context;

        public ProArrayAdapter(Activity context, string[] items)
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

            View rowView = inflator.Inflate(Resource.Layout.ProListLayout, parent, false);

            TextView textView = (TextView)rowView.FindViewById<TextView>(Resource.Id.labelPro);
            ImageView imageView = (ImageView)rowView.FindViewById<ImageView>(Resource.Id.imageViewPro);

            textView.Text = (items[position]);


            String s = items[position];

            if (s.StartsWith("PraY"))
            {
                imageView.SetImageResource(Resource.Drawable.PraY);
            }
            else if (s.StartsWith("Bang"))
            {
                imageView.SetImageResource(Resource.Drawable.Bang);
            }
            else if (s.StartsWith("Sneaky"))
            {
                imageView.SetImageResource(Resource.Drawable.Sneaky);
            }
            else if (s.StartsWith("Pilot"))
            {
                imageView.SetImageResource(Resource.Drawable.Pilot);  
            }
            else if (s.StartsWith("Deft"))
            {
                imageView.SetImageResource(Resource.Drawable.Deft);
            }
         
            return rowView;
        }
    }
}