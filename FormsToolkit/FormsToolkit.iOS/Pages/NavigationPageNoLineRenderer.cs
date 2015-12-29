using Xamarin.Forms.Platform.iOS;
using UIKit;
using System;
using Xamarin.Forms;
using FormsToolkit;
using FormsToolkit.iOS;


[assembly: ExportRenderer (typeof(NavigationPageNoLine), typeof(NavigationPageNoLineRenderer))]
namespace FormsToolkit.iOS
{
    /// <summary>
    /// Navigation page no line renderer.
    /// </summary>
    public class NavigationPageNoLineRenderer : NavigationRenderer
    {
        /// <summary>
        /// Init this instance.
        /// </summary>
        public static void Init()
        {
            var time = DateTime.UtcNow;
        }
        /// <summary>
        /// Views the did load.
        /// </summary>
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // remove lower border and shadow of the navigation bar
            NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
            NavigationBar.ShadowImage = new UIImage ();
        }
    }
}

