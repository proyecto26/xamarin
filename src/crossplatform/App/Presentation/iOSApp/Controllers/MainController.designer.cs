// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOSApp
{
    [Register ("MainController")]
    partial class MainController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton callsButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton formsButton { get; set; }

        [Action ("CallsButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CallsButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("ValidateButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ValidateButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (callsButton != null) {
                callsButton.Dispose ();
                callsButton = null;
            }

            if (formsButton != null) {
                formsButton.Dispose ();
                formsButton = null;
            }
        }
    }
}