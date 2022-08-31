using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandStranded.Views.StoryEvents
{
    public class StoryEvent2 : IView
    {
        private readonly GlobalState _state;

        public StoryEvent2(GlobalState state)
        {
            _state = state;
        }

        enum StroyEventChoice2
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
                new SelectionPrompt<StroyEventChoice2>()
                    // You can only use one .Title
                    .Title($"MEOW MEWO MEWO NEOW") // needs to be updated
                    .AddChoices(Enum.GetValues<StroyEventChoice2>()) // choices from the WelcomViewChoice
            );

            switch (choice)
            {
                case StroyEventChoice2.GoIntoTheJungle:
                    _state.CurrentView = new StoryEvent2(_state);
                    return;
                case StroyEventChoice2.TryAndCatchAFish:
                    return;
                case StroyEventChoice2.WalkOnTheCoast:
                    return;
                case StroyEventChoice2.ReturnToTheGameStartView:
                    _state.CurrentView = new GameStartView(_state);
                    return;
                case StroyEventChoice2.Exit:
                    _state.ShouldExit = true;
                    return;
            }
        }
    }
}
