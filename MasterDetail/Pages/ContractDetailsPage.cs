using System;

using Xamarin.Forms;

namespace MasterDetail
{
	public class ContractDetailsPage : ContentPage
	{
		public event Action PageDissapearing;

		public ContractDetailsPage ()
		{
			Title="Contract Details";
//			Icon = "Accounts";
//			NavigationPage.SetHasNavigationBar (this, true);
//			NavigationPage.SetHasBackButton (this, true);
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
//			NavigationPage.SetHasNavigationBar (this, true);
//			NavigationPage.SetHasBackButton (this, true);
//			NavigationPage.SetHasNavigationBar (this, false);
//			NavigationPage.SetHasBackButton (this, true);

		}


		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();
			if (PageDissapearing != null)
				PageDissapearing ();
		}
	}
}


