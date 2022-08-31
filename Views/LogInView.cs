using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;


namespace IslandStranded.Views

{

    {
        private readonly GlobalState _state;

        public LogInView(GlobalState state)
        {
            _state = state;
        }

        public void Execute()
        {

            Console.WriteLine("Logging in!");

            var username = AnsiConsole.Ask<string>("Please enter your username: ");
            var password = AnsiConsole.Ask<string>("Please enter your password: ");

            var hash = User.GenerateSha256Hash(password, User.CREAM);

            var matchingUser = _state.UserDatabase.Users.FirstOrDefault(x => x.UserName == username && x.Password == hash);

            if (matchingUser is null)
            {
                Console.WriteLine("Sorry, invalid login information. Please, try again.");
                return;
            }

            _state.CurrentUser = matchingUser;
            _state.CurrentView = new GameStartView(_state);

        }
    }
}

