using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetail
{

	public class ContractsPage : ContentPage
	{
		Button TestButton,TestButton2;

		public ContractsPage ()
		{

			Title = "Contracts";
			Icon = "Contracts";

			TestButton = new Button () {
				Text="Details"
			};
			TestButton.Clicked+= OnTestButtonClicked;

			TestButton2 = new Button () {
				Text="ListView Example"
			};
			TestButton2.Clicked += (s,e)=>{
				Navigation.PushAsync(new ListViewExamplePage());
			};

			var stackLayout = new StackLayout () {
				Children = {
					TestButton,
					TestButton2
				}
			};

			this.Content = stackLayout;
		}


		public async void OnTestButtonClicked(object sender, EventArgs e) {

			var Page = new ContractDetailsPage();

			/*
			 * Forma de subsribirnos al evento PageDissapearing , este evento sera lanzado  
			 * cuando la pagina Details haya sido cerrada, lo pueden observar en el OnPageDissapearing de ContractDetailsPage
			 * el Action callback " () => {} " sera invocado , siempre que el evento sea lanzado.
			*/
			Page.PageDissapearing += () => {
				DisplayAlert ("Alert", "Has cerrado Details", "OK");	
			};

			//
			//			var NavPage = new NavigationPage (Page) {
			//				Title= "Details",
			//				Icon="Accounts.png"
			//			};
			////			Page.Icon = "accounts";
			//			NavigationPage.SetHasBackButton(Page,true);
			//			NavigationPage.SetBackButtonTitle (Page, "Home");
			//			NavigationPage.SetTitleIcon (NavPage, "accounts");

			await Navigation.PushAsync(Page);
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

		}
	}

}