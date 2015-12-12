using System;

namespace FormsToolkit.iOS
{
    public static class Toolkit
    {
        public static void Init()
        {
            StandardImageCellRenderer.Init();
            StandardTextCellRenderer.Init();
            StandardViewCellRenderer.Init();
            EntryLineRenderer.Init();
            ListViewGroupedRenderer.Init();
            EmailValidatorBehavior.Init();
            EmptyValidatorBehavior.Init();
            BooleanToObjectConverter<string>.Init();
            HexToColorConverter.Init();
            InvertedBoolenConverter.Init();
        }
    }
}

