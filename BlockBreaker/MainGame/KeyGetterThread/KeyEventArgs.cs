using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyGetterThread
{
    public class KeyEventArgs : EventArgs
    {
        public ConsoleKey KeyPressed { get; set; } // Create property to hold what key was pressed
    }
}
