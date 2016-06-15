using System;
using Xamarin.Forms;

namespace MasterDetail
{
	public class CeldaDePromocion : ViewCell
	{
		public Image mainImage;
		public Label Title;
		public Label Detail;
		public Image logo;
		
		public CeldaDePromocion()
		{
			StackLayout mainContainer = new StackLayout{};

			mainImage = new Image
			{
				Source = "http://www.garuyo.com/web/media/images/images/Alitas%20Chili's%20baja%201.png",
				WidthRequest = 100,
				HeightRequest = 80
			};

			StackLayout infoContainer = new StackLayout
			{
				Orientation = StackOrientation.Horizontal
			};

			StackLayout labelContainer = new StackLayout
			{
			};

			Title = new Label
			{
				TextColor = Color.Black
			};
			Detail = new Label
			{
				TextColor = Color.Black
			};

			logo = new Image
			{
				Source = "https://pbs.twimg.com/profile_images/572579141879205888/1gKHgoX2.jpeg",
				WidthRequest = 20,
				HeightRequest = 20
			};

			labelContainer.Children.Add(Title);
			labelContainer.Children.Add(Detail);

			infoContainer.Children.Add(logo);
			infoContainer.Children.Add(labelContainer);

			mainContainer.Children.Add(mainImage);
			mainContainer.Children.Add(infoContainer);

			View = mainContainer;

		}
	}
}

