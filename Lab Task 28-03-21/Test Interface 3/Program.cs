using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21_MusicRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile m1 = new MusicFile("After Hours", "The Weeknd", 2020, 450);
            MusicFile m2 = new MusicFile("Nightmare", "2Scratch", 2019, 400);
            MusicFile m3 = new MusicFile("Vampire", "Ramzoid", 2018, 390);

            iPhone a1 = new iPhone(10);
            a1.AddMusicFile(m1,m2);
            a1.setVolume(8);
            a1.playNext();
            a1.retune(98.4);
            a1.changeChannel();

            Console.WriteLine("========================");

            iPod b1 = new iPod(12);
            b1.AddMusicFile(m3);
            b1.setVolume(8);
            b1.playNext();
            b1.playPrevious();
            
        }
    }
}
