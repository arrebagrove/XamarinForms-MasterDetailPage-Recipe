using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetail
{

	public class OpportunitiesPage : ContentPage
	{
		PromocionesVM _vm;
		public OpportunitiesPage ()
		{
			Title = "Opportunities";
			Icon = "Opportunities.png";

			_vm = new PromocionesVM();
			BindingContext = _vm;

			ListView listaDePromociones = new ListView
			{
				//RowHeight = 50,
				BackgroundColor = Color.White,
				HasUnevenRows = true
			};

			listaDePromociones.BindingContext = _vm;
			listaDePromociones.ItemsSource = _vm.ListaDePromociones;
			listaDePromociones.ItemTemplate = new DataTemplate(CrearCelda);

			Content = listaDePromociones;
		}

		Cell CrearCelda()
		{
			var celda = new CeldaDePromocion();
			celda.BindingContext = _vm.ListaDePromociones;
			celda.Title.SetBinding(Label.TextProperty, nameof(Promocion.Nombre));
			celda.Detail.SetBinding(Label.TextProperty, nameof(Promocion.Precio));

			return celda;
		}
	}
	
}