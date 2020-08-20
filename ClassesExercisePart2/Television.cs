using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercisePart2
{

    /* Create a class that represents a television. 
     * It should expose a set of functions that allow external
     * code to increment or decrement the volume 
     * and channel, but not set it directly.*/


    class Television
    {
        private int currentChannel = 0;
        private int currentVolume = 0;

        // increases the volume by one 
        public void IncreaseVolume()
        {
            currentVolume++;

        }

        // decreases the volume by one
        public void DecreaseVolume()
        {
            currentVolume--;
        }

        // returns the current volume
        public int Volume
        {
            get
            {
                return currentVolume;
            }
           
        }

        // increases the channel num by one
        public void IncreaseChannel()
        {
            currentChannel++;

        }

        // decreases the channel num by one
        public void DecreaseChannel()
        {
            currentChannel--;
        }

        // returns the current channel
        public int Channel
        {
            get
            {
                return currentChannel;
            }
        }


    }
}
