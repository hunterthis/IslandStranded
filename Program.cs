using IslandStranded.Views; // use views folder

namespace IslandStranded;

public static class Program
{
    public static void Main()
    {
        //var db = new database()
        var state = new GlobalState();
        //state.Database = db;
        state.CurrentView = new WelcomeVIew(state);

        while (!state.ShouldExit)
        {
            state.CurrentView.Execute();
        }
    }
}