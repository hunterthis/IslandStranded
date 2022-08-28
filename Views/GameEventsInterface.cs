using Microsoft.EntityFrameworkCore.Metadata;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IslandStranded.Views;

public class GameEventsInterface : IView
{
    private readonly GlobalState _state;

    public GameEventsInterface(GlobalState state)
    {
        _state = state;
    }

    enum GameEventsInterfaceChoice
    {
        GoForward, // View
        GoBack, // View
        Quit
    }


    public void Execute()
    {
        var choice = AnsiConsole.Prompt
            (
                new SelectionPrompt<GameEventsInterfaceChoice>()
                    .Title("These are the following decisions. What will you do next?") // instigates choice from player
                    .AddChoices(Enum.GetValues<GameEventsInterfaceChoice>()) // choices from the WelcomeViewChoice
            );

        switch (choice)
        {
            case GameEventsInterfaceChoice.Quit:
                _state.ShouldExit = true;
                return;

            case GameEventsInterfaceChoice.GoForward:
                _state.CurrentView = new CreateAccountVIew(_state);
                return;

            case GameEventsInterfaceChoice.GoBack:
                _state.CurrentView = new LogInView(_state);
                return;

            default:
                Console.WriteLine("Error: hit default case on GameEventsInterfaceChoice");
                return;
        }

    }
}