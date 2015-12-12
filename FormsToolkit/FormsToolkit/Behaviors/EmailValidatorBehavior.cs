using System;
using Xamarin.Forms;
using System.Text.RegularExpressions;

namespace FormsToolkit
{
    public class EmailValidatorBehavior : Behavior<Entry>
    {
        public static void Init()
        {

        }
        bool colorSet;
        Color color = Color.Default;
        const string emailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";


        public static readonly BindableProperty TextColorInvalidProperty = 
            BindableProperty.Create<EmailValidatorBehavior,Color>(
                p => p.TextColorInvalid, default(Color));

        public Color TextColorInvalid
        {
            get { return (Color)GetValue(TextColorInvalidProperty); }
            set { SetValue(TextColorInvalidProperty, value); }
        }

        static readonly BindablePropertyKey IsValidPropertyKey = BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(EmailValidatorBehavior), false);

        public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

        public bool IsValid
        {
            get { return (bool)base.GetValue(IsValidProperty); }
            private set { base.SetValue(IsValidPropertyKey, value); }
        }

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

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= HandleTextChanged;

        }
    }
}

