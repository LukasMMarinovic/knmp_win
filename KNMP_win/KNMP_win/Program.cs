using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Runtime.InteropServices;



///////////////////////////////////////////////
//                                           //
//    	            |\___|\                  //
//           	   /       |.                //
//   	          |  .     |_                //
//    	          |          )               //
//   	          |      -v-v                //
//   	          /        |\                //
//	          Scratch-A-Bear Media           //
//-------------------------------------------//
//--------------Lukas Marinovic--------------//
//-------------------------------------------//
// Please visit:                             //
//  -Blog				                     //
//	http://scratchabear.blogspot.com         //
//  -Github                                  //
//	https://github.com/LukasMMarinovic       //
//                                           //
/////////////////////////////////////////////// 


namespace KNMP_win
{
    class Program
    {
        static void Main(string[] args)
        {

            int randomSeconds = 0;

            for (int Loops = 0; Loops <= 10; Loops++)
            {
                //generates a random integer between 1000 and 5000
                //this determines the length of time between each sound
                Random rnd = new Random();
                randomSeconds = rnd.Next(1000, 5000);
                

                //pause for "randomSeconds" seconds
                System.Threading.Thread.Sleep(randomSeconds);

                //play sound
                var Player = new System.Media.SoundPlayer();
                Player.SoundLocation = @"D:\Programs\knmp_win\meow.wav";
                Player.PlaySync();
            }
        }
    }
}
