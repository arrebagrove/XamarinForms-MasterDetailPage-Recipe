using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MasterDetail
{
	public class PromocionesVM : BaseViewModel
	{

		List<Promocion> _listaPromociones;

		public PromocionesVM()
		{
			_listaPromociones = new List<Promocion>();

			LlenarList();

			_listaDePromociones = new ObservableCollection<Promocion>(_listaPromociones);
			ListaDePromociones = _listaDePromociones;

		}

		ObservableCollection<Promocion> _listaDePromociones;
		public ObservableCollection<Promocion> ListaDePromociones
		{
			get
			{
				return _listaDePromociones;
			}
			set
			{
				_listaDePromociones = value;
				OnPropertyChanged(nameof(ListaDePromociones));
			}
		}

		void LlenarList()
		{
			_listaPromociones.Add(new Promocion
			{
				Fecha = DateTime.Now,
				Nombre = "Promoción 1",
				Precio = "55",
				Rating = 4
			});

			_listaPromociones.Add(new Promocion
			{
				Fecha = DateTime.Now,
				Nombre = "Promoción 2",
				Precio = "100",
				Rating = 3
			});

			_listaPromociones.Add(new Promocion
			{
				Fecha = DateTime.Now,
				Nombre = "Promoción 3",
				Precio = "550",
				Rating = 2
			});

			_listaPromociones.Add(new Promocion
			{
				Fecha = DateTime.Now,
				Nombre = "Promoción 4",
				Precio = "45",
				Rating = 3
			});

			_listaPromociones.Add(new Promocion
			{
				Fecha = DateTime.Now,
				Nombre = "Promoción 5",
				Precio = "15",
				Rating = 1
			});
		}
	}
}

