using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21_MusicRadio
{
    class iPhone: IMusicPlayerInterface, IRadioPlayerInterface
    {
        public int volume;
        public int musicCount { get; set; }
        MusicFile[] musicfiles;
        
        public iPhone() { }
        public iPhone(int volume) {
            this.volume = volume;
            musicfiles = new MusicFile[10];
        }


        public void switchh(bool on) {
            if (on) {
                Console.WriteLine("iPhone turned off");

            }
            else
            {
                Console.WriteLine("iPhone turned on");
            }
        }
        public void play(bool on)
        {
            if (on)
            {
                Console.WriteLine("iPhone Music off");

            }
            else
            {
                Console.WriteLine("iPhone Music on");
            }
        }
        public void setVolume(int loudness) {
            if (loudness > volume)
            {
                int change = loudness - volume;
                Console.WriteLine("iPhone Volume decreased by " + change);
            }
            else if (loudness < volume)
            {
                int change =  volume- loudness;
                Console.WriteLine("iPhone Volume decreased by " + change);
            }
        }
        public void playNext() {
            Console.WriteLine("iPhone Next track played");
        }
        public void playPrevious() {
            Console.WriteLine("iPhone Previous track played");
        }
        public void retune(double frequency) {
            Console.WriteLine("iPhone Frequency changed to " + frequency + " Hz");}
        public void changeChannel() {
            Console.WriteLine("iPhone Channel Changed");
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
