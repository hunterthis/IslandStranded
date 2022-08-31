using IslandStranded.Views.StoryEvents;
using Microsoft.EntityFrameworkCore.Metadata;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandStranded.Views
{
    public class GameStartView : IView
    {
        private readonly GlobalState _state;

        public GameStartView(GlobalState state)
        {
            _state = state;
        }

        enum GameStartChoice
        {
            StartNewGame,
            Continue,
            Exit
        }

        public void Execute()
        {
            if (_state.CurrentUser is null)
            {
                Console.WriteLine("How did you get here?");
                _state.CurrentView = new LogInView(_state);
                return;

            }

            var choice = AnsiConsole.Prompt
            (
                new SelectionPrompt<GameStartChoice>()
                    // You can only use one .Title
                    .Title($"Hello {_state.CurrentUser.UserName}! Your passwrod is {_state.CurrentUser.Password}.") // Tile/ intro text
                    .AddChoices(Enum.GetValues<GameStartChoice>()) // choices from the WelcomViewChoice
            );

            switch (choice)
            {
                case GameStartChoice.StartNewGame:
                    _state.CurrentView = new StoryEvent0(_state);
                    return;
                case GameStartChoice.Continue:
                    return;
                case GameStartChoice.Exit:
                    _state.ShouldExit = true;
                    return;
            }






            //Console.WriteLine("You have sucessfully loggedin!");

            //if(_state.CurrentUser is null)
            //{
            //    Console.WriteLine("How did you get here?");
            //    _state.CurrentView = new LogInView(_state);
            //    return;

            //}

            //Console.WriteLine($"Hello {_state.CurrentUser.UserName}! Your passwrod is {_state.CurrentUser.Password}.");

            //_state.ShouldExit = true;

        }
    }
}
