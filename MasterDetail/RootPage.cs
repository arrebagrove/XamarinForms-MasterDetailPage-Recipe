using System;
using Xamarin.Forms;
namespace MasterDetail
{
	public class RootPage : MasterDetailPage
	{
		readonly MenuPage menuPage;

		public RootPage ()
		{
			menuPage = new MenuPage ();


			menuPage.Menu.ItemSelected += (sender, e) => {

				if (e.SelectedItem != null) {
					var PageSelected = e.SelectedItem as MenuItem;

					((ListView)sender).SelectedItem = null;

					/*
					 * Lanzamos el evento OnMenuItemSelected, en MenuPage tendran un ejemplo para subscribirse a este evento
					*/
					MessagingCenter.Send<RootPage, MenuItemSelectedEventArgs> (this, 
						"OnMenuItemSelected",
						new MenuItemSelectedEventArgs() {
							ItemSelected= PageSelected

						});


					NavigateTo (PageSelected);
				}						



										};

			Master = menuPage;
			Detail = new NavigationPage (new ContractsPage ());
		}

		void NavigateTo (MenuItem menu)
		{
			if (menu == null)
				return;
			
			Page displayPage = (Page)Activator.CreateInstance (menu.TargetType);

			Detail = new NavigationPage (displayPage);

			menuPage.Menu.SelectedItem = null;
			IsPresented = false;
		}
	}

	public class MenuItemSelectedEventArgs : EventArgs 
	{
		public MenuItem ItemSelected { get; set;}

	}
}