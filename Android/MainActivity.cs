using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Util;


namespace MasterDetail.Droid
{
	[Activity (Label = "MasterDetail.Android.Android", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity//FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			
			// set the layout resources first
			FormsAppCompatActivity.ToolbarResource = Android.Resource.Layout.toolbar;
			FormsAppCompatActivity.TabLayoutResource = Android.Resource.Layout.tabs;

			// then call base.OnCreate and the Xamarin.Forms methods
			//Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
//			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
//			{
//				// Kill status bar underlay added by FormsAppCompatActivity for status bar coloring
//				// Must be done before calling FormsAppCompatActivity.OnCreate()
//				var statusBarHeightInfo = typeof(FormsAppCompatActivity).GetField("statusBarHeight", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
//				statusBarHeightInfo.SetValue(this, 0);
//			}
//
//			base.OnCreate(bundle);
//
//			// Set status bar to the correct themed color
//			// Must be done after calling FormsAppCompatActivity.OnCreate()
//			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
//			{
//				Window.DecorView.SystemUiVisibility = StatusBarVisibility.Visible;
//
//				var themeValue = new TypedValue();
//				Theme.ResolveAttribute (Resource.Attribute.colorPrimaryDark, themeValue, true);
//				Window.SetStatusBarColor(new Android.Graphics.Color(themeValue.Data));
//			}

			Forms.Init(this, bundle);
			base.OnCreate(bundle);
			LoadApplication(new App());

		}
	}
}

