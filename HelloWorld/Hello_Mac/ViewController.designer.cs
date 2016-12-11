// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Hello_Mac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField ClickedLabel { get; set; }

		[Outlet]
		AppKit.NSTableColumn CueNumberColumn { get; set; }

		[Outlet]
		AppKit.NSTableView CueTable { get; set; }

		[Outlet]
		AppKit.NSTableColumn CueTimeColumn { get; set; }

		[Action ("ClickedButton:")]
		partial void ClickedButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ClickedLabel != null) {
				ClickedLabel.Dispose ();
				ClickedLabel = null;
			}

			if (CueTable != null) {
				CueTable.Dispose ();
				CueTable = null;
			}

			if (CueTimeColumn != null) {
				CueTimeColumn.Dispose ();
				CueTimeColumn = null;
			}

			if (CueNumberColumn != null) {
				CueNumberColumn.Dispose ();
				CueNumberColumn = null;
			}
		}
	}
}
