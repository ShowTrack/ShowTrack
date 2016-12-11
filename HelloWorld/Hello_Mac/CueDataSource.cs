using System;
using System.Collections.Generic;
using AppKit;

namespace Hello_Mac
{
	public class CueDataSource : NSTableViewDataSource
	{
		public List<Cue> CueList = new List<Cue>(); 

		public CueDataSource()
		{
		}

		public override nint GetRowCount(NSTableView tableView)
		{
			return CueList.Count;
		}


	}
}
