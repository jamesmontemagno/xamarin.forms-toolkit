using System;
using FormsToolkit;
using Xamarin.Forms;

namespace ToolkitTests
{
    public class App : Application
    {
        public App()
        {
            
            var messagingCenter = new Button
            {
                Text = "Messaging Center",
                Command = new Command(()=>MainPage.Navigation.PushAsync(new MessagingServicePage()))
            };

			var line = new EntryLine
			{
				Placeholder = "This nifty place for entering text!",
				HorizontalTextAlignment = TextAlignment.Center,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Text = "",
                FontSize = 30,
				BorderColor = Color.Red
			};

            var trigger = new Trigger(typeof(EntryLine));
            trigger.Property = EntryLine.IsFocusedProperty;
            trigger.Value = true;
            Setter setter = new Setter();
            setter.Property = EntryLine.BorderColorProperty;
            setter.Value = Color.Yellow;

            trigger.Setters.Add(setter);

            line.Triggers.Add(trigger);

            var line2 = new EntryLine
            {
                PlaceholderColor = Color.Orange,
                Placeholder = "This nifty place for entering text!",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = "",
                FontSize = 10,
                BorderColor = Color.Red
            };

            // The root page of your application
            MainPage = new NavigationPage(new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
					Padding = new Thickness(32,32,32,32),
                    Children =
                    {
                        messagingCenter,
						line,
                        line2
                    }
                }
            });
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

