using System;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using ImageCircle.Forms.Plugin.Abstractions;

namespace MasterDetail
{
	public class ListViewExamplePage : ContentPage
	{

		ObservableCollection<Empleado> _ListData { get; set; }
		public ObservableCollection<Empleado> ListData {
			get {
				
				return _ListData;
			}
			set {
				_ListData = value;

				OnPropertyChanged (nameof(ListData));
			}
		}

		ListView EmpledosListView;

		public ListViewExamplePage ()
		{
			EmpledosListView = new ListView
			{
				RowHeight = 60,
			};
			ListData= new ObservableCollection<Empleado>();

			ListData.Add(new Empleado(){
				Nombre="Cesar",
				Apellido= "Turrubiates",
				FotoPerfil= "leads"
			});
			ListData.Add(new Empleado(){
				Nombre="Mario",
				Apellido= "Galvan",
				FotoPerfil= "leads"
			});

			/*
			* Asignamos nuestra fuente de datos a la propiedad ItemSource
			*/
			EmpledosListView.ItemsSource= ListData;
			/*
			*Asignamos el template de nuestra listView
			*/
			EmpledosListView.ItemTemplate= new DataTemplate(EmpleadoCellTemplate);

			/*
			*Asignamos el evento ItemSelected,este evento  responde a un tap o click.
			*/
			EmpledosListView.ItemSelected+= (object sender, SelectedItemChangedEventArgs e) => {

				if (e.SelectedItem != null) {
					var itemSelected = e.SelectedItem as Empleado;
					DisplayAlert("ListView Example","Seleccionaste: "+itemSelected.Nombre+ " " + itemSelected.Apellido,"OK");

					((ListView)sender).SelectedItem = null;

				}
			};

			Content = new StackLayout { 
				Children = {
					EmpledosListView
				}
			};
		}



		#region viewcell
		public ViewCell EmpleadoCellTemplate()
		{
			var TemplateEmpleado = new ViewCell();

//			Labels del template
			var nombreLabel = new Label ();
			var apellidoLabel = new Label();
			var fotoPerfilImage = new CircleImage
			{
				Aspect = Aspect.AspectFit,
				BorderColor = Color.Black,
				BorderThickness = 3,
				HeightRequest = 25,
				WidthRequest = 25,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Start,
				FillColor = Color.Black
			};

//			Asignamos las propiedades bindeables, estas propiedades son las del BindingContext,
//			el cual es el modelo de nuestra Collection en este caso es Empleado.

			nombreLabel.SetBinding (Label.TextProperty,"Nombre");
			apellidoLabel.SetBinding (Label.TextProperty,"Apellido");
			fotoPerfilImage.SetBinding (Image.SourceProperty,"FotoPerfil");

			/*
			*Creamos Context Actions, los cuales responderan a un swipe sobre un item  en IOS  
			*y long press en Android
			*/
			Xamarin.Forms.MenuItem delete = new Xamarin.Forms.MenuItem ();
			delete.Text = "Eliminar";
			delete.IsDestructive = true;
			delete.SetBinding (Xamarin.Forms.MenuItem.CommandParameterProperty,".");
			delete.Clicked += (object sender, EventArgs e) => 
			{
				var mi = ((Xamarin.Forms.MenuItem)sender);
				var item = mi.CommandParameter as Empleado;
				ListData.Remove(item);
			};
			TemplateEmpleado.ContextActions.Add (delete);

			Xamarin.Forms.MenuItem edit = new Xamarin.Forms.MenuItem ();
			edit.SetBinding (Xamarin.Forms.MenuItem.CommandParameterProperty, ".");
			edit.Clicked+= (object sender, EventArgs e) => 
			{
				var mi = (Xamarin.Forms.MenuItem)sender;
				var item = mi.CommandParameter as Empleado;
//				Aqui podriamos Abrir unPage ParamArrayAttribute edicion de datos del Empleado
//				Navigation.PushModalAsync(new EmpleadoInfo(item));
			};
			edit.Text = "Editar";

			TemplateEmpleado.ContextActions.Add (edit);	

			var stack = new StackLayout {
				Orientation= StackOrientation.Horizontal,
				Spacing = 10,
				Padding = 5,
				Children= {
					fotoPerfilImage,
					new StackLayout{
						Orientation= StackOrientation.Vertical,
						Spacing = 2,
						Children={
							nombreLabel,
							apellidoLabel
						}
					}
				}
			};

			TemplateEmpleado.View = stack;
			return TemplateEmpleado;
		}
		#endregion
	}
}


