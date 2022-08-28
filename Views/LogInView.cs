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
            Console.WriteLine("Welcome to the log in page");
            // ask for username
            var username = AnsiConsole.Ask<string>("Please enter your username: ");
            // ask for password
            var password = AnsiConsole.Ask<string>("Please enter your password: ");
            // check if username == password
            
            if (password != password )  // is not functional, placeholder function for later once password matches with hashes
                {
                    Console.WriteLine("Your password needs to match. Please try again.");           
                }
                if (password == password)
                {
                    Console.WriteLine("Your password matches.");
                }

            _state.CurrentView = new GameEventsInterface(_state);
            // currently repeating loop of asking for questions
            // init GameEvents view
            //http://programmingisfun.com/learn/c-sharp-adventure-game/c_sharp_08_branching_narrative/
        }
    }
}
