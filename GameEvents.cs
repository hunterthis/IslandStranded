using IslandStranded.Views;
using Microsoft.VisualBasic;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;


namespace IslandStranded
{


    // calls CurrentUser data,
    // use intvalue as a parameter in play method 
    // creates array of events to access depending on users retrieved int value

    internal class GameEventsView
    {
        private readonly GlobalState _state;

        public GameEventsView(GlobalState state)
        {
            _state = state;
        }

        public void Execute()
        {

            // this should be updated to represent new state of users events call

            Console.WriteLine("Part -1 You are flying over the south asia sea.Everything is so blue. Suddenly, the engine stalls...");

            Console.WriteLine(" You are going to crash.In the panic you decide to jump out of the plane with your parachute...");



            /*
        part - 2
        Pain.Searing pain. You awake and slowly gather yourself. 
        You stand up and realize you have survived the crash and have been stranded by the seashore.
        You feel so weak. You have to find food and water.

        part -3 
        You decide to enter the thick jungle.Once, deep inside, you nothice some of the brush rustleling.

        part - 4
        You decide to sneak up to the other side of the bursh. It's a scrawny dog. He doesnt notice you.

        part - 5
        You decide to make your pressence known to the dog. He is startled, but he does not ruun way.

        part - 6
        You remeber you have a piece of jerky in your pocket. You gice it to the dog.

        part - 7
        He devours the small peice of meat.He seems to trust you.

        part - 8
        You muster up the courag eto pet the dog.The dog loves it. Suddenly, his ears perk up. Without warning he takes off in flash.

        part - 9
        You chase after it. He is way to fast.You slip and fall. He is nowhere in sight.

        part - 10
        You decide to climb up the giant tree.

        part - 11
        You get to the top and notice that there is a black smoke rise from a certain location.

        part - 12
        You decide to go the location. You arrive at the source.It's your plane.

        part - 13
        You searc the debris adn stumble upon a back pack with a Barong Macchete and strap.

        part - 14
        As you prepare to leave you realize that two young, but maancing tigers, have you in their sight....

        part - 15
        You decide to pull out the machette and fight if you must.

        part - 16
        Suddenly the dog you met rushes to your dice barnking menacingly.

        part - 17
        You hold your ground and wait to see if the tigers strike first, but they accept that you are too much effort and vanish into the brush.

        part - 18
        You follow the dog and he brings you to a Quail he captured.


                */

        }
    }
}