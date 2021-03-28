using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21_MusicRadio
{
    class MusicFile
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int YearOfRelease { get; set; }
        public int DurationInSeconds { get; set; }

        public MusicFile() { }
        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds) 
        {
            Title = title;
            Artist = artist;
            YearOfRelease = yearOfRelease;
            DurationInSeconds = durationInSeconds;
        }

        void changeTitle(string title) { }
    }
}
