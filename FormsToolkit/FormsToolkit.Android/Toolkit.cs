using System;

namespace FormsToolkit.Droid
{
    /// <summary>
    /// Static toolkit Initialization class
    /// </summary>
    public static class Toolkit
    {
        /// <summary>
        /// Init so nothing gets linked out
        /// </summary>
        public static void Init()
        {
            EmailValidatorBehavior.Init();
            EmptyValidatorBehavior.Init();
            BooleanToObjectConverter<string>.Init();
            HexToColorConverter.Init();
            InvertedBooleanConverter.Init();
            UpperTextConverter.Init();
            LowerTextConverter.Init();
            HasDataConverter.Init();
            MessagingService.Init();
            MessagingServiceAlert.Init();
            MessagingServiceQuestion.Init();
            MessagingServiceChoice.Init();
        }
    }
}

