using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using static System.Net.Mime.MediaTypeNames;

namespace IslandStranded.Views;

internal class CreateAccountVIew : IView
{
    private readonly GlobalState _state;

    public CreateAccountVIew(GlobalState state)
    {
        _state = state;
    }
    public void Execute()
    {
        var CreateAccountBool = AnsiConsole.Ask<string>("Would you like to create a new account? Please type yes or no");
        Console.WriteLine();
        // ToDo: Return back to welcome screen if you accidently select create account

        if (CreateAccountBool == "no")  
        {
            Console.WriteLine("Not creating username, program ending");
            Environment.Exit(0);
        }

        var username = AnsiConsole.Ask<string>("Please enter your desired username: ");
        Console.WriteLine();
        var password = AnsiConsole.Ask<string>("Please enter your password: ");
        var passwordConfirmation = AnsiConsole.Ask<string>("Please confirm your password: ");
        int currentStoryEvent = 0;

        // check database for existing username
        var matchingUser = _state.UserDatabase.Users.FirstOrDefault(x => x.UserName == username);
        if (matchingUser != null)
        {
            Console.WriteLine("Sorry, that username is already being used.");
            Console.WriteLine("Please Try a different username.");
            return;
        }

        // check if password matches.
        if (password != passwordConfirmation)
        {
            Console.WriteLine("Your password needs to match. Please try again.");
            return;
        }



        var user = new User(username, password, currentStoryEvent);
        _state.UserDatabase.Users.Add(user);
        _state.UserDatabase.SaveChanges();
        _state.CurrentView = new WelcomeVIew(_state);
        _state.CurrentView = new LogInView(_state);
    }
}