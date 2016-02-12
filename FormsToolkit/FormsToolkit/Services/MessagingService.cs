using System;
using Xamarin.Forms;

namespace FormsToolkit
{
    /// <summary>
    /// Messaging service implementation
    /// </summary>
    public class MessagingService : IMessagingService
    {
        /// <summary>
        /// Init this instance.
        /// </summary>
        public static void Init()
        {
            var time = DateTime.UtcNow;
        }

        /// <summary>
        /// Subscribe the specified message and callback.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="callback">Callback.</param>
        public void Subscribe(string message, Action<IMessagingService> callback) =>
            MessagingCenter.Subscribe<MessagingService>(this, message, callback);


        /// <summary>
        /// Subscribe the specified message and callback.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="callback">Callback.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public void Subscribe<TArgs>(string message, Action<IMessagingService, TArgs> callback) =>
            MessagingCenter.Subscribe<MessagingService, TArgs>(this, message, callback);


        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">Message.</param>
        public void SendMessage(string message) =>
            MessagingCenter.Send<MessagingService>(this, message);


        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="args">Arguments.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public void SendMessage<TArgs>(string message, TArgs args) =>
        MessagingCenter.Send<MessagingService, TArgs>(this, message, args);


        /// <summary>
        /// Unsubscribe the specified message.
        /// </summary>
        /// <param name="message">Message.</param>
        public void Unsubscribe (string message) =>
            MessagingCenter.Unsubscribe<MessagingService>(this, message);


        /// <summary>
        /// Unsubscribe the specified message and args.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="args">Arguments.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public void Unsubscribe<TArgs> (string message) =>
            MessagingCenter.Unsubscribe<MessagingService, TArgs>(this, message);


        static MessagingService instance = null;

        /// <summary>
        /// Gets the instance of the Messaging Service
        /// </summary>
        public static MessagingService Current => (instance ?? (instance = new MessagingService()));

    }

   
}

