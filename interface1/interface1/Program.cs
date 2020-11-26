using System;

namespace interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.songs();
            phone.changeChannel();
            phone.play(true);
            phone.playNext();
            phone.playPrevious();
            phone.Switch(true);

        }
    }
}
