using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownManager
{
    public partial class Form1 : Form
    {
        bool Shutdown;
        bool Restart;
        String Time;
        public Int16 TimeInSeconds;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            Shutdown = true;
            Restart = false;
                
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            Restart = true;
            Shutdown = false;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Time = comboBOX.SelectedItem.ToString();
                                    
        }

        private void button1_Click(object sender, EventArgs e)
        {

            run();
            if (Shutdown)
            {

                MessageBox.Show("Час до вимикання ПК " + Time, "Time to SHUTDOWN");

            }
            else {

                MessageBox.Show("Час до перезапуску ПК " + Time, "Time to RESTART");

            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Process.Start("shutdown.exe", "-a");
            MessageBox.Show("УСЕ ВІДМІНЕНО!!!");

        }

        void run() {

            setTimeToShutdownOrRestart();

            if (Shutdown == true)
            {
                Process.Start("shutdown.exe", "-s -f -t " + TimeInSeconds.ToString()); 
                //MessageBox.Show("Пішов шатдавн " + Time);

            }
            else if (Restart == true)
            {
                Process.Start("shutdown.exe", "-s -f -t " + TimeInSeconds.ToString());
                //MessageBox.Show("Пішов рестарт " + Time);
                
            }

            VolumeManager volumeManager = new VolumeManager();
            volumeManager.desMasterVolume(TimeInSeconds);
            
        }

        private void setTimeToShutdownOrRestart() {

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
