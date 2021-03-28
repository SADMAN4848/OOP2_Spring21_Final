using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21_MusicRadio
{
    interface IMusicPlayerInterface
    {
        void switchh(bool on);
        void play(bool on);
        void setVolume(int loudness);
        void playNext();
        void playPrevious();
    }
}
