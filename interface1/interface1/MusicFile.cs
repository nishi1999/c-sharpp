using System;
using System.Collections.Generic;
using System.Text;

namespace interface1
{
    class MusicFile
    {
        private string title;
        private string artist;
        private int yearOfRelease;
        private int durationInSeconds;

        public MusicFile()
        {
            title = "Meet you again";
            artist = "tara";
            yearOfRelease = 2012;
            durationInSeconds = 4;
        }
        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;
        }
        public void changeTitle(string title)
        {
            this.title = title;
        }
    }
}
