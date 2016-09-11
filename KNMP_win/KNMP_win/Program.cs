using System;
using System.Collections.Generic;
using System.Text;
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
            bool isTimeProvided = false;

            int flag = 0;

            //default values for time start and end
            const int DEFAULT_RANGE_START = 1800000;  //30 minutes
            const int DEFAULT_RANGE_END = 2400000;  //40 minutes

            //time range variables
            int customStart = DEFAULT_RANGE_START;
            int customEnd = DEFAULT_RANGE_END;


            while(flag == 0)
            {
                

                //play sound
                var Player = new System.Media.SoundPlayer();
                Player.SoundLocation = @"D:\Programs\knmp_win\meow.wav";
                Player.PlaySync();

                //waits a random time within the specified range
                System.Threading.Thread.Sleep(Utility.Random(customStart, customEnd));


                //using System.Linq;
                //using System.Threading.Tasks;
            }
        }
    }

    
}
