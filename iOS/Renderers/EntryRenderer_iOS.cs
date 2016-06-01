using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;

using MasterDetail;
using MasterDetail.iOS;
using MonoTouch.UIKit;

[assembly: ExportRenderer(typeof(CustomEntryRenderer), typeof(EntryRenderer_iOS))]
namespace MasterDetail.iOS
{
	//public class EntryRenderer_iOS : EntryRenderer
	//{
	//	protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
	//	{
	//		base.OnElementChanged(e);

	//		if (Control != null)
	//		{
	//			//Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
	//			//Control.BorderStyle = UITextBorderStyle.Line;

	//			if ((Element as CustomEntryRenderer).HasBorder)
	//			{
	//				Control.BorderStyle = UITextBorderStyle.RoundedRect;
	//				Control.Layer.BorderWidth = 2.0f;
	//				Control.Layer.CornerRadius = 2.0f;
	//				Control.Layer.BorderColor = Element.TextColor.ToCGColor();
	//			}
	//			else
	//			{
	//				Control.BorderStyle = UITextBorderStyle.None;
	//			}
	//		}
	//	}
	//}

	public class EntryRenderer_iOS : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

				if (Control != null)
				{
					Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);

					//Control.LayoutMargins< = (float)Element.TextMargin;
					//Control.BorderStyle = UITextBorderStyle.Line;

					if ((Element as CustomEntryRenderer).HasBorder)
					{
						Control.BorderStyle = UITextBorderStyle.RoundedRect;
						Control.Layer.BorderWidth = 2.0f;
						Control.Layer.CornerRadius = 2.0f;
						Control.Layer.BorderColor = Element.TextColor.ToCGColor();
					}
					else
					{
						Control.BorderStyle = UITextBorderStyle.None;
					}
				}
			}
	}
}

