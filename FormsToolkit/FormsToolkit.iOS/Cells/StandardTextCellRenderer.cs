using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using FormsToolkit.iOS;

[assembly: ExportRenderer (typeof(TextCell), typeof(StandardTextCellRenderer))]
namespace FormsToolkit.iOS
{
    public class StandardTextCellRenderer : TextCellRenderer
    {
        public static void Init()
        {

        }
        public override UIKit.UITableViewCell GetCell (Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
        {
            var cell = base.GetCell (item, reusableCell, tv);
            cell.SetDisclosure(item.StyleId);
            return cell;
        }
    }
}

