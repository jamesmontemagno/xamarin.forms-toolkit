using System;

namespace FormsToolkit
{
    /// <summary>
    /// Messaging service question.
    /// </summary>
    public class MessagingServiceQuestion
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

        /// <summary>
        /// Gets or sets the OnCompleted Action&lt;bool&gt;.
        /// </summary>
        /// <value>The OnCompleted Action&lt;bool&gt;.</value>
        public Action<bool> OnCompleted { get; set; }
    }
}

