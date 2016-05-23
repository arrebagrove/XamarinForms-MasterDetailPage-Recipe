using System;
using Xamarin.Forms;

namespace MasterDetail
{
	public class App : Application
	{
		public static App MainApp { get; set; }

		public App ()
		{
			MainApp = this;

			// The root page of your Application
			MainPage= new RootPage();
		}


//		public static Page GetMainPage ()
//		{	
//			return new RootPage ();
//		}


	}
}