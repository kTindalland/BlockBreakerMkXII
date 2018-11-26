using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyGetterThread;

namespace MainGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyListener = new Listener(); // Create the listener
            KeyGetter.Run(keyListener); // Start the listener thread

            


        }
    }
}
