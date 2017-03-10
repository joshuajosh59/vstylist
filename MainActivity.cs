using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;


namespace AndroidCustomGridView
{
    [Activity(Label = "vstylist", MainLauncher = false, Icon = "@drawable/splash", Theme = "@style/MyTheme")]
    public class MainActivity : AppCompatActivity
    {
        GridView gridView;
        string[] gridViewString = {
            "Camera","image","model","photos",
            
        };

        int[] imageId = {
            Resource.Drawable.camera,Resource.Drawable.image,Resource.Drawable.model,Resource.Drawable.photos
        };
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Vstylist";

            CustomGridViewAdapter adapter = new CustomGridViewAdapter(this, gridViewString, imageId);
            gridView = FindViewById<GridView>(Resource.Id.grid_view_image_text);
            gridView.Adapter = adapter;
            gridView.ItemClick += (s, e) => {
                Toast.MakeText(this, "Vstylist: " + gridViewString[e.Position], ToastLength.Short).Show();
            };
        }
    }
}