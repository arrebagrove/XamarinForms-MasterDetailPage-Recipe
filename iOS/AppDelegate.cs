using System;
using System.Collections.Generic;
using System.Linq;
using ImageCircle.Forms.Plugin.iOS;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace MasterDetail.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : FormsApplicationDelegate
	{
//		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Forms.Init ();

//			window = new UIWindow (UIScreen.MainScreen.Bounds);
//			window.RootViewController = App.GetMainPage ().CreateViewController ();
//			window.MakeKeyAndVisible ();

			LoadApplication (new App ());
			ImageCircleRenderer.Init();

			return base.FinishedLaunching (app, options);
		}
	}
}

