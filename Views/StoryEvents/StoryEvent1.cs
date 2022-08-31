using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IslandStranded.Views.StoryEvents
{
    public class StoryEvent1 : IView // must be public
    {
        private readonly GlobalState _state;

        public StoryEvent1(GlobalState state)
        {
            _state = state;
        }

        enum StroyEventChoice1
        {
            GoIntoTheJungle,
            TryAndCatchAFish,
            WalkOnTheCoast,
            ReturnToTheGameStartView,
            Exit

        }

        public void Execute()
        {
            var choice = AnsiConsole.Prompt
            (
                new SelectionPrompt<StroyEventChoice1>()
                    // You can only use one .Title
                    .Title($"In the panic you decide to jump out of the plane with the parachute...\n" +
                    $"Pain. Searing pain. You awake and slowly gather yourself. \n" +
                    $"You stand up and realize you have survived the crash and have been stranded by the seashore. \n" +
                    $"You feel so weak. You have to find food and water. ") // Tile/ intro text
                    .AddChoices(Enum.GetValues<StroyEventChoice1>()) // choices from the WelcomViewChoice
            );

            switch (choice)
            {
                case StroyEventChoice1.GoIntoTheJungle:
                    _state.CurrentView = new StoryEvent2(_state);
                    return;
                case StroyEventChoice1.TryAndCatchAFish:
                    return;
                case StroyEventChoice1.WalkOnTheCoast:
                    return;
                case StroyEventChoice1.ReturnToTheGameStartView:
                    _state.CurrentView = new GameStartView(_state);
                    return;
                case StroyEventChoice1.Exit:
                    _state.ShouldExit = true;
                    return;
            }
        }
        


    }
}
