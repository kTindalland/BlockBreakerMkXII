using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyGetterThread
{
    public class Listener
    {
        public delegate void KeyGetterHandler(object source, KeyEventArgs args); // Create the signature for the delegate

        public event KeyGetterHandler KeyGot; // Create the event

        /// <summary>
        /// Will constantly listen for a key press and fire an event when one is pressed.
        /// </summary>
        public void Listen()
        {
            while (true)
            {
                var keyPressed = Console.ReadKey(true).Key; // Wait for the key press

                var args = new KeyEventArgs() {KeyPressed = keyPressed}; // Create the arguments

                OnKeyGot(args); // Call the event
            }
        }

        protected virtual void OnKeyGot(KeyEventArgs args)
        {
            if (KeyGot != null) // Check there are functions to run
                KeyGot(this, args); // Run event
        }
    }
}
