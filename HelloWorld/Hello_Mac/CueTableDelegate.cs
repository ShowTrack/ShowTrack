using System;
using AppKit;

namespace Hello_Mac
{
	public class CueTableDelegate : NSTableViewDelegate
	{
		private CueDataSource cueDataSource; 

		public CueTableDelegate(CueDataSource cueSource)
		{
			this.cueDataSource = cueSource; 

		}

		private const string CellIdentifier = "CueView"; 

		#region Override Methods
		public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
		{
			// This pattern allows you reuse existing views when they are no-longer in use.
			// If the returned view is null, you instance up a new view
			// If a non-null view is returned, you modify it enough to reflect the new data
			NSTextField view = (NSTextField)tableView.MakeView(CellIdentifier, this);
			if (view == null)
			{
				view = new NSTextField();
				view.Identifier = CellIdentifier;
				view.BackgroundColor = NSColor.Clear;
				view.Bordered = false;
				view.Selectable = false;
				view.Editable = false;
			}

			// Setup view based on the column selected
			switch (tableColumn.Title)
			{
				case "Number":
					view.StringValue = cueDataSource.CueList[(int)row].number.ToString();
					break;
				case "Time":
					view.StringValue = cueDataSource.CueList[(int)row].time.ToString();
					break;
			}

			return view;
		}
		#endregion
	}
}
