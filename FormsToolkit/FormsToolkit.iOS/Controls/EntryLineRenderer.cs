using System;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using Xamarin.Forms;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using FormsToolkit;
using FormsToolkit.iOS;
using CoreGraphics;

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

        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            var start = new CGPoint(rect.GetMinX(), rect.GetMaxY());
            var end = new CGPoint(rect.GetMaxX(), rect.GetMaxY());

            var path = new UIBezierPath();
            path.MoveTo(start);
            path.AddLineTo(end);
            path.LineWidth = 2.0f;

            ((EntryLine)Element).BorderColor.ToUIColor().SetStroke();
            path.Stroke();
        }

        void DrawBorder(EntryLine view)
        {
            SetNeedsDisplay();
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
