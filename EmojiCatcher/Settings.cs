using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmojiCatcher
{
    internal class Settings
    {
        public int startTimer;

        public int bonusTimer;

        private int diff;
        
        public int Diff
        {
            set
            {
                if (value == 0)
                {
                    diff = 0;
                    //Change Start Timer Here for Easy
                    startTimer = 15;
                    //Change Bonus Timer for Easy here
                    bonusTimer = 12;
                } else if (value == 1)
                {
                    diff = 1;
                    //Change Start Timer Here for Medium
                    startTimer = 12;
                    //Change Bonus Timer for Medium here
                    bonusTimer = 10;
                } else if (value == 2)
                {
                    diff = 2;
                    //Change Start Timer Here for Hard
                    startTimer = 8;
                    //Change Bonus Timer for Hard here
                    bonusTimer = 8;
                }
            }
            get { return diff; }
        }



        //Difficulty Emoji Picture Size Default
        //Easy = 100, 87 | 75, 62 | 50, 45 | 40 - 50
        //e0, e1 | e2 , e3 | e4 , e5 | e6 - e7
        public int e0 = 100, e1 = 87, e2 = 75, e3 = 62, e4 = 50, e5 = 45, e6 = 40, e7 = 50;

        //Medium = 90 78 67 56 45 40 35 - 45
        //m0, m1 | m2 , m3 | m4 , m5 | m6 - m7
        public int m0 = 90, m1 = 78, m2 = 67, m3 = 56, m4 = 45, m5 = 40, m6 = 35, m7 = 45;

        //Hard 70, 60 | 50, 40 | 30, 25 | 20 - 30
        //h0, h1 | h2 , h3 | h4 , h5 | h6 - h7
        public int h0 = 70, h1 = 60, h2 = 50, h3 = 40, h4 = 30, h5 = 25, h6 = 20, h7 = 30;



        //First Level Size Default is 800x500
        public int flsx = 800, flsy = 500;
        //First Level Random Position Default is x = (154,680) y = (0,357)
        public int flx1 = 154, flx2 = 680, fly1 = 0, fly2 = 357;

        //Second Level Size Default is 900x700
        public int slsx = 900, slsy = 700;
        //Second Level Random Position Default is x = (154,805) y = (0,582)
        public int slx1 = 154, slx2 = 805, sly1 = 0, sly2 = 582;

        //Third Level Size Default is 1100x900
        public int tlsx = 1100, tlsy = 900;
        //third Level Random Position Default is x = (154,1030) y = (0,807)
        public int tlx1 = 154, tlx2 = 1030, tly1 = 0, tly2 = 807;

    }
}
