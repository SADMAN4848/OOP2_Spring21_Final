using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21_MusicRadio
{
    class iPod: IMusicPlayerInterface
    {
        public int volume;
        public int musicCount { get; set; }
        MusicFile[] musicfiles;

        public iPod() { }
        public iPod(int volume)
        {
            this.volume = volume;
            musicfiles = new MusicFile[10];
        }

        public void switchh(bool on)
        {
            if (on)
            {
                Console.WriteLine("iPod turned off");

            }
            else
            {
                Console.WriteLine("iPod turned on");
            }
        }
        public void play(bool on) { }
        public void setVolume(int loudness) {
            if (loudness > volume)
            {
                int change = loudness - volume;
                Console.WriteLine("iPod Volume decreased by " + change);
            }
            else if (loudness < volume)
            {
                int change = volume - loudness;
                Console.WriteLine("iPod Volume decreased by " + change);
            }
        }
        public void playNext()
        {
            Console.WriteLine("iPod Next track played");
        }
        public void playPrevious()
        {
            Console.WriteLine("iPod Previous track played");
        }

        public void AddMusicFile(params MusicFile[] musicfiles)
        {
            foreach (MusicFile mus in musicfiles)
            {
                this.musicfiles[musicCount++] = mus;
            }
        }
    }
}
