using System;
using Xamarin.Forms;

namespace MasterDetail
{
	public class CustomEntryRenderer : Entry
	{
		public bool HasBorder { get; set; }
		public bool Justified { get; set; }
		//public Keyboard KeyBoardType { get; set; }
	}
	
	//public class CustomEntryRenderer : Entry
	//{
	//	public CustomEntryRenderer()
	//	{
	//	}

	//	public bool HasBorder { get; set; }

	//	public static readonly BindableProperty HasBorderProperty =
	//		BindableProperty.Create<CustomEntryRenderer, bool>(p => p.HasBorder, false);

	//}
}

