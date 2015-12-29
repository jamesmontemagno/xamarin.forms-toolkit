using System;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using FormsToolkit;
using FormsToolkit.iOS;
using Xamarin.Forms;

[assembly: ExportRenderer (typeof(ListViewGrouped), typeof(ListViewGroupedRenderer))]
namespace FormsToolkit.iOS
{
    /// <summary>
    /// List view grouped renderer.
    /// </summary>
    public class ListViewGroupedRenderer: ListViewRenderer
    {
        /// <summary>
        /// Init this instance.
        /// </summary>
        public static void Init()
        {
            var time = DateTime.UtcNow;
        }

        /// <summary>
        /// Raises the element changed event.
        /// </summary>
        /// <param name="e">E.</param>
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

