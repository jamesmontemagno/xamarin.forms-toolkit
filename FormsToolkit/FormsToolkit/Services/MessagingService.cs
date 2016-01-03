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

    /// <summary>
    /// Messaging service question.
    /// </summary>
    public class MessagingServiceQuestion
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title {get;set;}
        /// <summary>
        /// Gets or sets the question.
        /// </summary>
        /// <value>The question.</value>
        public string Question { get; set; }
        /// <summary>
        /// Gets or sets the positive button text.
        /// </summary>
        /// <value>The positive.</value>
        public string Positive { get; set; }

        /// <summary>
        /// Gets or sets the negative button text
        /// </summary>
        /// <value>The negative.</value>
        public string Negative { get; set; }
    }

    /// <summary>
    /// Messaging service alert.
    /// </summary>
    public class MessagingServiceAlert
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title {get;set;}
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance cancel/OK text.
        /// </summary>
        /// <value><c>true</c> if this instance cancel; otherwise, <c>false</c>.</value>
        public string Cancel { get; set; }
    }
}

