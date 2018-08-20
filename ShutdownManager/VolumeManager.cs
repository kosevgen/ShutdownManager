using System;

namespace ShutdownManager
{
    class VolumeManager 
    {
        int Time;
        public VolumeManager(int time) {
            Time = time;
        }
        public void desMasterVolume()
        {
            AudioManager audioManager = new AudioManager();
            float masterVolume = audioManager.GetMasterVolume();
            float partOfVolume = masterVolume/120;
            Int32 timeToWait = (Int32)(Time - 120)*1000;
            System.Threading.Thread.Sleep(timeToWait);

            for (int i = 0; i <= 120; i++)
            {
                audioManager.SetMasterVolume(masterVolume - partOfVolume);
                masterVolume = audioManager.GetMasterVolume();
                System.Threading.Thread.Sleep(1000);
            }

        }
    }
}

