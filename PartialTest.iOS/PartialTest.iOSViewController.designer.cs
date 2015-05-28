// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PartialTest.iOS
{
	[Register ("PartialTest_iOSViewController")]
	partial class PartialTest_iOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel HelloLbl { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (HelloLbl != null) {
				HelloLbl.Dispose ();
				HelloLbl = null;
			}
		}
	}
}
