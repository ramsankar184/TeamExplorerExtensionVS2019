using Microsoft.TeamFoundation.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;

namespace TeamExplorerExtension
{
    [TeamExplorerNavigationItem("A60CD381 - 2D27 - 49E5 - B3E8 - EFE13BCF5435",1800)]
    public class TeamExplorerExtBase : ITeamExplorerNavigationItem2
    {
        public bool IsEnabled => true;

		public int ArgbColor => 0;

        public object Icon => null;

        public string Text => "ViewCS";

        public Image Image => null;

        public bool IsVisible => true;

        public event PropertyChangedEventHandler PropertyChanged;

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Execute()
		{
			Process.Start("notepad.exe");
		}

        public void Invalidate()
        {
            
        }
    }
}
