// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace timyao.iOS
{
    [Register ("MasterViewController")]
    partial class MasterViewController
    {
        [Outlet]
        UIKit.UITableView MasterTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbMessage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lbMessage != null) {
                lbMessage.Dispose ();
                lbMessage = null;
            }

            if (MasterTableView != null) {
                MasterTableView.Dispose ();
                MasterTableView = null;
            }
        }
    }
}