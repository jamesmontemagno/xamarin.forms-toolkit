using System;
using Xamarin.Forms;

//Via: https://gist.github.com/davidtavarez/e3580c98357edd89de6f

namespace FormsToolkit
{
    /// <summary>
    /// Entry line controls
    /// </summary>
    public class EntryLine : Entry
    {
        /// <summary>
        /// The border color property.
        /// </summary>
        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create(
                nameof(BorderColor),
                typeof(Color),
                typeof(EntryLine),
                Color.Black
            );

        /// <summary>
        /// Gets or sets the color of the border.
        /// </summary>
        /// <value>The color of the border.</value>
        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <remarks>To be added.</remarks>
        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create(
                nameof(FontSize),
                typeof(double),
                typeof(EntryLine),
                Font.Default.FontSize
            );

        /// <summary>
        /// Gets the size of the font for the Entry element text.
        /// </summary>
        /// <value>To be added.</value>
        /// <remarks>To be added.</remarks>
        public double FontSize
        {
            get => (double)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <remarks>To be added.</remarks>
        public static readonly BindableProperty PlaceholderColorProperty =
            BindableProperty.Create(
                nameof(PlaceholderColor),
                typeof(Color),
                typeof(EntryLine),
                Color.Default
            );

        /// <summary>
        /// To be added.
        /// </summary>
        /// <value>To be added.</value>
        /// <remarks>To be added.</remarks>
        public Color PlaceholderColor
        {
            get => (Color)GetValue(PlaceholderColorProperty);
            set => SetValue(PlaceholderColorProperty, value);
        }


    }
}
