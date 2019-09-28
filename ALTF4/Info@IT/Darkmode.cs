using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info_IT
{
	class Darkmode
	{
		Home h = new Home();
		public bool DarkMode { get; set; }

		public Darkmode() { }

		public Darkmode(bool darkmode)
		{
			DarkMode = darkmode;




			if(DarkMode)
			{
				h.pnlLoginFields.BackColor = System.Drawing.Color.FromName("ControlDarkDark");
			}
			if(!DarkMode)
			{
				h.pnlLoginFields.BackColor = System.Drawing.Color.FromName("Control");

			}
		}
	}
}
