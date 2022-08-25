using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace IslandStranded.Views

{
    internal class LogInView :IView
    {
        private readonly GlobalState _state;

        public LogInView(GlobalState state)
        {
            _state = state;
        }

        public void Execute()
        {
            // ask for username
            // ask for password
            // check if username == password
            //if they are equal, proceed to program start
            // execute program start
            Console.WriteLine("Log In View not built yet");
        }
    }
}
