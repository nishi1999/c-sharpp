using System;
using System.Collections.Generic;
using System.Text;

namespace interface1
{
    class Phone:RadioPlayer,MusicPlayer
    {
        MusicFile[] musicFile = new MusicFile[100];


        public void songs()
        {
            MusicFile song = new MusicFile();
            musicFile[0] = song;
            song = new MusicFile("x", "y", 2012, 5);
            musicFile[1] = song;
        }


        public void changeChannel()
        {
            Console.WriteLine("Change Chanale");
        }

        public void play(bool on)
        {
            Console.WriteLine(" just Play");
        }

        public void playNext()
        {
            Console.WriteLine("Play in next");
        }

        public void playPrevious()
        {
            Console.WriteLine("Play in previous");
        }

        public void Return(double frequency)
        {
            Console.WriteLine("Return");
        }

        public void setVolume(int loudness)
        {
            Console.WriteLine("Set volume");
        }

        public void Switch(bool on)
        {
            Console.WriteLine("Switch");
        }
    }
}