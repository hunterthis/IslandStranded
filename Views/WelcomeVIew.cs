using Microsoft.EntityFrameworkCore.Metadata;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IslandStranded.Views;

public class WelcomeVIew : IView
{
    private readonly GlobalState _state;

    public WelcomeVIew(GlobalState state)
    {
        _state = state;
    }

    enum WelcomeViewChoice
    {
        LogIn, // View
        CreateAccount, // View
        Quit
    }


    public void Execute()
    {
        var choice = AnsiConsole.Prompt
            (
                new SelectionPrompt<WelcomeViewChoice>()
                    .Title("Welcome to our game. What will you do next?") // Tile/ intro text
                    .AddChoices(Enum.GetValues<WelcomeViewChoice>()) // choices from the WelcomViewChoice
            );

        switch (choice)
        {
            case WelcomeViewChoice.Quit:
                _state.ShouldExit = true;
                return;

            case WelcomeViewChoice.CreateAccount:
                _state.CurrentView = new CreateAccountVIew(_state);
                return;

            case WelcomeViewChoice.LogIn:
                _state.CurrentView = new LogInView(_state);
                return;

            default:
                Console.WriteLine("Error: hit default case on LogInView");
                return;
        }

    }
}