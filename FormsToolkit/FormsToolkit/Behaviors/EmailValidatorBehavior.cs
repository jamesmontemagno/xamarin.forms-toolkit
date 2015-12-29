using System;
using Xamarin.Forms;
using System.Text.RegularExpressions;

namespace FormsToolkit
{
    /// <summary>
    /// Email validator behavior.
    /// </summary>
    public class EmailValidatorBehavior : Behavior<Entry>
    {
        /// <summary>
        /// Init this instance.
        /// </summary>
        public static void Init()
        {
            var time = DateTime.UtcNow;
        }
        bool colorSet;
        Color color = Color.Default;
        const string emailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";


        /// <summary>
        /// The text color invalid property.
        /// </summary>
        public static readonly BindableProperty TextColorInvalidProperty = 
            BindableProperty.Create<EmailValidatorBehavior,Color>(
                p => p.TextColorInvalid, default(Color));

        /// <summary>
        /// Gets or sets the text color invalid.
        /// </summary>
        /// <value>The text color invalid.</value>
        public Color TextColorInvalid
        {
            get { return (Color)GetValue(TextColorInvalidProperty); }
            set { SetValue(TextColorInvalidProperty, value); }
        }

        static readonly BindablePropertyKey IsValidPropertyKey = BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(EmailValidatorBehavior), false);

        /// <summary>
        /// The is valid property.
        /// </summary>
        public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

        /// <summary>
        /// Gets a value indicating whether this instance is valid.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public bool IsValid
        {
            get { return (bool)base.GetValue(IsValidProperty); }
            private set { base.SetValue(IsValidPropertyKey, value); }
        }

        /// <param name="bindable">To be added.</param>
        /// <summary>
        /// Raises the attached to event.
        /// </summary>
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += HandleTextChanged;
        }

        void HandleTextChanged(object sender, TextChangedEventArgs e)
        {
            IsValid = (Regex.IsMatch(e.NewTextValue, emailRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)));
            if (!colorSet)
            {
                colorSet = true;
                color = ((Entry)sender).TextColor;
            }

            ((Entry)sender).TextColor = IsValid ? color : TextColorInvalid;
        }

        /// <param name="bindable">To be added.</param>
        /// <summary>
        /// Raises the detaching from event.
        /// </summary>
        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= HandleTextChanged;

        }
    }
}

