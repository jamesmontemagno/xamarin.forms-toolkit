using System;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using FormsToolkit;
using FormsToolkit.iOS;
using Xamarin.Forms;

[assembly: ExportRenderer (typeof(ListViewGrouped), typeof(ListViewGroupedRenderer))]
namespace FormsToolkit.iOS
{
    public class ListViewGroupedRenderer: ListViewRenderer
    {
        public static void Init()
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);


            if (e.OldElement != null || Element == null || Control == null)
                return;

            SetNativeControl(new UITableView(this.Bounds, UITableViewStyle.Grouped)
                {
                    Source = Control.Source
                });
        }
    }
}

