using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer();
            WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

            var curDir = Directory.GetCurrentDirectory();

            var dir1 = curDir + @"\Bibio - lovers' carvings.wav";
            var dir2 = curDir + @"\e-dubble - No Brakes (FF #44).mp3";
            var dir3 = curDir + @"\Bibio - Lovers Carvings (Remix) ft. Olu & Blue Scholars.mp3";

            while (true) { 
                player.SoundLocation = dir1;
                player.Play();
                Console.ReadLine();
                player.Stop();

                wplayer.URL = dir2;
                wplayer.controls.play();
                Console.ReadLine();
                wplayer.controls.stop();

                wplayer.URL = dir3;
                wplayer.controls.play();
                Console.ReadLine();
                wplayer.controls.stop();
            }
        }
    }
}
