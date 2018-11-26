using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeyGetterThread
{
    public class KeyGetter
    {
        /// <summary>
        /// Will start the listening thread
        /// </summary>
        /// <param name="listener">Listener object</param>
        public static void Run(Listener listener)
        {
            var threadRef = new ThreadStart(listener.Listen); // Assign what function the thread will run

            var listenerThread = new Thread(threadRef); // Create the thread object

            listenerThread.Start(); // Start the listener thread

        }
    }
}
