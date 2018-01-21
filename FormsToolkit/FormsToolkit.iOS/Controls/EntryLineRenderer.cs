using System;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using Xamarin.Forms;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using FormsToolkit;
using FormsToolkit.iOS;

//Via: https://gist.github.com/davidtavarez/e3580c98357edd89de6f
[assembly: ExportRenderer(typeof(EntryLine), typeof(EntryLineRenderer))]
namespace FormsToolkit.iOS
{
    /// <summary>
    /// Entry line renderer.
    /// </summary>
    public class EntryLineRenderer : EntryRenderer
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
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderStyle = UITextBorderStyle.None;

                if (Element is EntryLine view)
                {
                    SetFontSize(view);
                    SetPlaceholderTextColor(view);
                    DrawBorder(view);
                }
            }
        }

        /// <summary>
        /// Raises the element property changed event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            var view = (EntryLine)Element;

            if (e.PropertyName == nameof(view.BorderColor))
                DrawBorder(view);
            if (e.PropertyName == nameof(view.FontSize))
                SetFontSize(view);
            if (e.PropertyName == nameof(view.PlaceholderColor))
                SetPlaceholderTextColor(view);
        }

        void DrawBorder(EntryLine view)
        {
            var borderLayer = new CALayer
            {
                MasksToBounds = true,
                Frame = new CoreGraphics.CGRect(0f, Frame.Height / 2, Frame.Width, 1f),
                BorderColor = view.BorderColor.ToCGColor(),
                BorderWidth = 1.0f
            };

            Control.Layer.AddSublayer(borderLayer);
            Control.Layer.MasksToBounds = true;
            Control.BorderStyle = UITextBorderStyle.None;
        }

        void SetFontSize(EntryLine view)
        {
            if (view.FontSize != Font.Default.FontSize)
                Control.Font = UIFont.SystemFontOfSize((System.nfloat)view.FontSize);
            else if (view.FontSize == Font.Default.FontSize)
                Control.Font = UIFont.SystemFontOfSize(17f);
        }

        void SetPlaceholderTextColor(EntryLine view)
        {
            if (string.IsNullOrEmpty(view.Placeholder) == false && view.PlaceholderColor != Color.Default)
            {
                var placeholderString = new NSAttributedString(view.Placeholder,
                    new UIStringAttributes { ForegroundColor = view.PlaceholderColor.ToUIColor() });
                Control.AttributedPlaceholder = placeholderString;
            }
        }
    }
}
