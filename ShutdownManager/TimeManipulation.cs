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
        }
        public TimeManipulation(String time)
        {
            Time = time;
            Shutdown = true;
            Restart = false;
        }

        public void run()
        {

            setTimeToShutdownOrRestart();

            if (Shutdown == true)
            {
                Process.Start("shutdown.exe", "-s -f -t " + TimeInSeconds.ToString()); 
                Messages.MessagesForm messagesShutdown = new Messages.MessagesForm();
                messagesShutdown.SetMessageText("Пішов шатдавн " + Time);
                Messages.MessagesForm messagesTimeToShutdown = new Messages.MessagesForm();
                messagesTimeToShutdown.SetMessageText("Час до вимикання ПК " + Time);
            }
            else if (Restart == true)
            {
                Process.Start("shutdown.exe", "-s -f -t " + TimeInSeconds.ToString());
                Messages.MessagesForm messagesRestart = new Messages.MessagesForm();
                messagesRestart.SetMessageText("Пішов шатдавн " + Time);
                Messages.MessagesForm messagesTimeToRestart = new Messages.MessagesForm();
                messagesTimeToRestart.SetMessageText("Час до вимикання ПК " + Time);
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
