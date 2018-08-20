using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutdownManager
{
    class TimeManipulation
    {
        String Time;
        bool Shutdown;
        bool Restart;
        public int TimeInSeconds;

        public TimeManipulation(String time, bool shutdown, bool restart)
        {
            Time = time;
            Shutdown = shutdown;
            Restart = restart;
            setTimeToShutdownOrRestart();
        }
        public TimeManipulation(String time)
        {
            Time = time;
            Shutdown = true;
            Restart = false;
            setTimeToShutdownOrRestart();
        }

        public void run()
        {
            if (Shutdown == true)
            {
                Process.Start("shutdown.exe", "-s -f -t " + TimeInSeconds.ToString());
            }
            else if (Restart == true)
            {
                Process.Start("shutdown.exe", "-r -f -t " + TimeInSeconds.ToString());
            }
        }

        private void setTimeToShutdownOrRestart()
        {

            if (Time == "1 хв")
            {

                TimeInSeconds = 60;

            }
            else if (Time == "2 хв")
            {

                TimeInSeconds = 60 * 2;

            }
            else if (Time == "5 хв")
            {

                TimeInSeconds = 60 * 5;

            }
            else if (Time == "10 хв")
            {

                TimeInSeconds = 60 * 10;

            }
            else if (Time == "15 хв")
            {

                TimeInSeconds = 60 * 15;

            }
            else if (Time == "30 хв")
            {

                TimeInSeconds = 60 * 30;

            }
            else if (Time == "40 хв")
            {

                TimeInSeconds = 60 * 40;

            }
            else if (Time == "1 год")
            {

                TimeInSeconds = 60 * 60;

            }
            else if (Time == "2 год")
            {

                TimeInSeconds = 60 * 2 * 60;

            }
            else if (Time == "3 год")
            {

                TimeInSeconds = 60 * 3 * 60;

            }
        }
    }
}
