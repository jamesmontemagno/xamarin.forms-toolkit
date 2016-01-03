using System;

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


            // The root page of your application
            MainPage = new NavigationPage(new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        messagingCenter
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

