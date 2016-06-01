using System;
using MasterDetail;
using MasterDetail.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntryRenderer), typeof(EntryRenderer_Android))]

namespace MasterDetail.Android
{
	public class EntryRenderer_Android : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.SetBackgroundColor(global::Android.Graphics.Color.Yellow);
			}
		}
	}
}

