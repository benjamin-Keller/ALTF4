using System;
using System.Threading;
using System.Windows.Forms;


namespace Info_IT
{
	static class Program
	{
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //	Application.EnableVisualStyles();
        //	Application.SetCompatibleTextRenderingDefault(false);
        //	Application.Run(new Home());
        //}

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var thread = new Thread(ThreadStart);
            // allow UI with ApartmentState.STA though [STAThread] above should give that to you
            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();

            Application.Run(new SplashScreen());
          
        }

        private static void ThreadStart()
        {
            Application.Run(new Home()); // <-- other form started on its own UI thread
        }

    }


}
