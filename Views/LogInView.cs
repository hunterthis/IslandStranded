using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


            var matchingUser = _state.UserDatabase.Users.FirstOrDefault(x => x.UserName == username);
            if (matchingUser != null)
            {
                Console.WriteLine("Sorry, that username or password doesn't exist.");
                Console.WriteLine("Please try a different username or password.");
                return;
            }

            // after user log in confirmed, state = gamestate event
            _state.UserDatabase.SaveChanges();
            _state.CurrentView = new WelcomeVIew(_state);

        }
    }
}

