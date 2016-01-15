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
        }
    }
}

