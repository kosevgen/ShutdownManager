using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            TimeManipulation timeManipulation = new TimeManipulation(Time, Shutdown, Restart);
            VolumeManager volumeManager = new VolumeManager(timeManipulation.TimeInSeconds);

            Thread thread1 = new Thread(new ThreadStart(timeManipulation.run));
            Thread thread2 = new Thread(new ThreadStart(volumeManager.desMasterVolume));
            thread1.Name = "Process shutdown or restart";
            thread2.Name = "Process volume controll";
            thread1.Start();
            thread2.Start();
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

        

    }

}

