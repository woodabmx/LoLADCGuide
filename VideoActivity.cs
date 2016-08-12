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
    [Activity(Label = "VideoActivity", Theme = "@android:style/Theme.NoTitleBar")]
    public class VideoActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.VideoLayout);

            var videoView = (VideoView)FindViewById<VideoView>(Resource.Id.videoViewMontage);
            var uri = Android.Net.Uri.Parse("https://www.youtube.com/watch?v=5F2-DSQODvE");
            videoView.SetVideoURI(uri);
            videoView.Start();




        }

    }
}
