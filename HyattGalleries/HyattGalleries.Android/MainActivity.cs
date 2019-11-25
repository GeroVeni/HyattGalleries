using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.Content;
using MediaManager;

namespace HyattGalleries.Droid
{
    [Activity(Label = "HyattGalleries", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            // Init Barcode Scanner
            ZXing.Mobile.MobileBarcodeScanner.Initialize(Application);
            // Init media player
            CrossMediaManager.Current.Init();
            // Add flags for collection view
            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            // Change the application status bar color (Android ONLY)
            SetStatusBarColor(new Android.Graphics.Color(ContextCompat.GetColor(this, Resource.Color.colorPrimaryDark)));
        }
    }
}