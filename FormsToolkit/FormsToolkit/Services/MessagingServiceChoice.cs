using System;

namespace FormsToolkit
{
    /// <summary>
    /// Messaging service choice.
    /// </summary>
    public class MessagingServiceChoice
    {
        /// <summary>
        /// Init this instance.
        /// </summary>
        public static void Init()
        {
            var time = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title {get;set;}

        /// <summary>
        /// Gets or sets a value indicating whether this instance cancel. can be null
        /// </summary>
        /// <value><c>true</c> if this instance cancel; otherwise, <c>false</c>.</value>
        public string Cancel { get; set;}

        /// <summary>
        /// Gets or sets the destruction. can be null
        /// </summary>
        /// <value>The destruction.</value>
        public string Destruction { get; set;}

        /// <summary>
        /// Gets or sets the items to display in the list
        /// </summary>
        /// <value>The items.</value>
        public string[] Items { get; set; }

        /// <summary>
        /// Gets or sets the on completed action
        /// </summary>
        /// <value>The on completed.</value>
        public Action<string> OnCompleted { get; set; }
    }
}

