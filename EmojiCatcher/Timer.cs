using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmojiCatcher
{
    static public class Timer
    {
        static public int times;

        static public void timerReduce()
        {
            times--;
        }
    }
}
