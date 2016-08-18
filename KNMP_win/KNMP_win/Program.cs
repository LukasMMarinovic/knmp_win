using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

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


            Console.WriteLine("//");

            //Implement search for "meow.wav" file
            var Player = new System.Media.SoundPlayer();
            Player.SoundLocation = @"D:\Programs\knmp_win\meow.wav";
            Player.PlaySync();
        }
    }
}
