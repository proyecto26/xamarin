﻿using System;

using UIKit;

namespace iOSApp
{
    public partial class MainController : UIViewController
    {
        public MainController() : base("MainController", null)
        {
		}

		public MainController(IntPtr p) : base(p)
        {
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
		}

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

		/// <summary>
		/// Navigate to other screen without Segue
		/// </summary>
        public static UIStoryboard CallsStoryboard = UIStoryboard.FromName("Calls", null);
		partial void CallsButton_TouchUpInside(UIButton sender)
        {
            var controller = CallsStoryboard.InstantiateInitialViewController() as CallsController;
            this.NavigationController.PushViewController(controller, true);
        }

        public static UIStoryboard FormsStoryboard = UIStoryboard.FromName("Forms", null);
        partial void ValidateButton_TouchUpInside(UIButton sender)
        {
			var controller = FormsStoryboard.InstantiateInitialViewController() as FormsController;
			this.NavigationController.PushViewController(controller, true);
        }
    }
}

