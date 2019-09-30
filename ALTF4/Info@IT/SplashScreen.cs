using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info_IT
{
    public partial class SplashScreen : MetroFramework.Forms.MetroForm
    {
        Home home = new Home();
        public SplashScreen()
        {
            InitializeComponent();

            timerClose.Interval = 16070;
            timerClose.Tick += new EventHandler(timerClose_Tick);
            timerClose.Start();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
