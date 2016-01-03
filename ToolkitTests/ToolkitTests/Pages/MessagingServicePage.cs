using System;

using Xamarin.Forms;
using FormsToolkit;

namespace ToolkitTests
{
    public class MessagingServicePage : ContentPage
    {
        public MessagingServicePage()
        {
            var question = new Button 
            {
                Text = "Ask Question"
            };

            question.Clicked += (object sender, EventArgs e) =>
            {
                MessagingService.Current.SendMessage("question", new MessagingServiceQuestion
                {
                    Title = "Question",
                    Question = "Is this awesome?",
                    Positive = "YES",
                    Negative = "NO"
                });
            };

            var alert = new Button 
            {
                Text = "Send Alert"
            };
            alert.Clicked += (object sender, EventArgs e) =>
            {
                MessagingService.Current.SendMessage("alert", new MessagingServiceAlert
                {
                    Title = "Alert",
                    Message = "This is is coming form messaging service",
                    Cancel = "OK",
                });
            };

            var message = new Button 
            {
                Text = "Send Message"
            };

            message.Clicked += (object sender, EventArgs e) =>
            {
                MessagingService.Current.SendMessage("message");
            };

            var stack = new StackLayout
            {
                Children =
                {
                    question, alert, message
                }
            };

            Content = stack;
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingService.Current.Subscribe<MessagingServiceQuestion> ("question", async (arg1, arg2) => 
            {
                var result = await DisplayAlert (arg2.Title, arg2.Question, arg2.Positive, arg2.Negative);

                await DisplayAlert ("Result", result.ToString(), "OK");
            });

            MessagingService.Current.Subscribe<MessagingServiceAlert> ("alert", async (arg1, arg2) => 
            {
               await DisplayAlert (arg2.Title, arg2.Message, arg2.Cancel);
            });

            MessagingService.Current.Subscribe ("message", async (e) => 
            {
                await DisplayAlert ("Received", "Got message from Messaging Service", "OK");
            });

        }

        protected override void OnDisappearing ()
        {
            base.OnDisappearing ();
            MessagingService.Current.Unsubscribe<MessagingServiceQuestion> ("question");
            MessagingService.Current.Unsubscribe<MessagingServiceAlert> ("alert");
            MessagingService.Current.Unsubscribe ("message");
        }
    }
}


