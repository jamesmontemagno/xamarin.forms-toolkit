using Xamarin.Forms.Platform.iOS;
using UIKit;

namespace FormsToolkit.iOS
{
    public class NavigationPageNoLineRenderer : NavigationRenderer
    {
        public static void Init()
        {

        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // remove lower border and shadow of the navigation bar
            NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
            NavigationBar.ShadowImage = new UIImage ();
        }
    }
}

