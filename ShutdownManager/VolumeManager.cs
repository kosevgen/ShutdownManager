using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutdownManager
{
    class VolumeManager 
    {

        public void desMasterVolume(int time)
        {

            AudioManager audioManager = new AudioManager();
            float masterVolume = audioManager.GetMasterVolume();
            float partOfVolume = masterVolume/120;
            Int16 timeToWait = (Int16)(time - 120);//var!!!
            System.Threading.Thread.Sleep(timeToWait * 100);
            
            for (int i = 0; i <= 120; i++)
            {
                double a = 0.0000000000000001;
                audioManager.SetMasterVolume(masterVolume - partOfVolume);
                masterVolume = audioManager.GetMasterVolume();
                for (int j = 0; j<= 2000000000; j++) {

                    a = a + 1 / 20000;

                }
                a = 0.000;
            }

        }





    }


}

