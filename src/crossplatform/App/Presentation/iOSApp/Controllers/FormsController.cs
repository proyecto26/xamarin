﻿using System;

using UIKit;

namespace iOSApp
{
    public partial class FormsController : UIViewController
    {
        public FormsController() : base("FormsController", null)
        {
        }

		public FormsController(IntPtr p) : base(p)
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
    }
}

