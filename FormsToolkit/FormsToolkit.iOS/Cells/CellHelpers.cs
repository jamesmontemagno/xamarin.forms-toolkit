using System;
using UIKit;

namespace FormsToolkit.iOS
{
    public static class CellHelpers
    {
        public static void SetDisclosure(this UITableViewCell cell, string id)
        {
            switch (id)
            {
                case "none":
                    cell.Accessory = UITableViewCellAccessory.None;
                    break;
                case "checkmark":
                    cell.Accessory = UITableViewCellAccessory.Checkmark;
                    break;
                case "detail-button":
                    cell.Accessory = UITableViewCellAccessory.DetailButton;
                    break;
                case "detail-disclosure-button":
                    cell.Accessory = UITableViewCellAccessory.DetailDisclosureButton;
                    break;
                case "disclosure":
                    cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
                    break;
                default:
                    cell.Accessory = UITableViewCellAccessory.None;
                    break;
            }
        }
    }
}

