using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandStranded.Views.StoryEvents
{
    public class StoryEvent0 : IView
    {
        private readonly GlobalState _state;

        public StoryEvent0(GlobalState state)
        {
            _state = state;
        }

        enum StroyEventChoice0
        {
            GrabTheParachute,
            YouStayOnThePlane,
            ReturnToTheGameStartView,
            Exit

        }

        public void Execute()
        {
            var choice = AnsiConsole.Prompt
            (
                new SelectionPrompt<StroyEventChoice0>()
                    // You can only use one .Title
                    .Title($"You are flying over the south asia sea. Everything is so blue. Suddenly, the engine stalls... \n" +
                    $"You are going to crash...") // Tile/ intro text
                    .AddChoices(Enum.GetValues<StroyEventChoice0>()) // choices from the WelcomViewChoice
            );

            switch (choice)
            {
                case StroyEventChoice0.GrabTheParachute:
                    _state.CurrentView = new StoryEvent1(_state);
                    return;
                case StroyEventChoice0.YouStayOnThePlane:
                    return;
                case StroyEventChoice0.ReturnToTheGameStartView:
                    _state.CurrentView = new GameStartView(_state);
                    return;
                case StroyEventChoice0.Exit:
                    _state.ShouldExit = true;
                    return;
            }
        }
    }
}
