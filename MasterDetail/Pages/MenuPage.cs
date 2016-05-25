using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace MasterDetail
{
	public class MenuPage : ContentPage
	{
		public ListView Menu { get; set; }

		public MenuPage ()
		{
			Icon = "settings";
			Title = "menu"; // The Title property must be set.
			BackgroundColor = Color.FromHex ("333333");

			Menu = new MenuListView ();

			var menuLabel = new ContentView {
				Padding = new Thickness (10, 36, 0, 5),
				Content = new Label {
					TextColor = Color.FromHex ("AAAAAA"),
					Text = "MENU", 
				}
			};

			var layout = new StackLayout {
				Spacing = 0, 
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			var BottomLabel = new Label () {
				TextColor= Color.White
			};

			/* 
			 * Ejemplo para subscribirnos a un evento por medio de MessagingCenter, lanzado desde RootPage, 
			 * con paso de Parametros a traves de la clase MenuItemSelectedEventArgs.
			 * En la Clase RootPage encontraran que al momento de hacer la seleccion de un elemento del Flyout Menu 
			 * será lanzado el Evento MessagingCenter.Send<RootPage, MenuItemSelectedEventArgs> (this,"OnMenuItemSelected",.....
			 * 
			*/
			MessagingCenter.Subscribe<RootPage, MenuItemSelectedEventArgs> (this,
																			"OnMenuItemSelected",
																			(sender, evArgs)=> {
//																				var menuItem =((List<MenuItem>)(Menu.ItemsSource)).Where ((x) =>  
//																									x.Title.Equals(evArgs.ItemSelected.Title)
//																								).FirstOrDefault();
//																				if (menuItem!= null)
																				BottomLabel.Text= "Last Visited Page: "+ evArgs.ItemSelected.Title;

																			});
			layout.Children.Add (menuLabel);
			layout.Children.Add (Menu);
			layout.Children.Add (BottomLabel);



			Content = layout;
		}


	}
}