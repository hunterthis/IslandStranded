using IslandStranded.Views; // use views folder


namespace IslandStranded
{
    public static class Program
    {
        public static void Main()
        {
            var db = new UserContext();
            var state = new GlobalState();
            state.UserDatabase = db;
            state.CurrentView = new WelcomeVIew(state);

            while (!state.ShouldExit)
            {
                state.CurrentView.Execute();
            }
        }
    }
}