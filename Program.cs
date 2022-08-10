/* [Island Stranded]
 * by Guillermo and Hunter 
 * This work is created as a joint coding project between two c# web developers
 * Adventure based text game
 */


using IslandStranded;
namespace IslandStrandedAdventure
{
    public static class Game
    {

        static string UserName; // blank value to assign user value
        static string UserKey;

        static void AdventureStart()
        {
            Console.WriteLine("Welcome back" + UserName);
        }

        static void NameCharacter()
        {
            Console.WriteLine("What should your characters name be?");
            UserName = Console.ReadLine();
            Console.WriteLine(UserName + " is now your character's name");

        }

        public static void StartGame()
        {
             
            Console.WriteLine("Welcome to Island Stranded, the game where you are stranded on an island.");
            Console.WriteLine("If you are good at solving problems, you can escape the island.");
            Console.WriteLine("Do you have an account currently? Press y for yes, or press any other key for no.");
            UserKey = Console.ReadLine();

            if (UserKey == "y")
            {
                AdventureStart();
            }
            else
            {
                NameCharacter();
            }
        }

    }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.Read();
        }

    }
}