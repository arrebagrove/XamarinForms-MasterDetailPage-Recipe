using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetail
{

	public class AccountsPage : ContentPage
	{
		void Button_Clicked(object sender, EventArgs e)
		{
			DependencyService.Get<ITextToSpeech>().Speak("Hello guys!");
		}

		public AccountsPage ()
		{
			Title = "Accounts";
			Icon = "Accounts.png";

			Button button = new Button
			{
				Text = "Tap para hablar",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};

			button.Clicked += Button_Clicked;

			Content = new StackLayout
			{
				Children = { button }
			};
		}
	}
	
}