using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1700GiyeonKimICA09
{
    class Program
    {
        static void Main(string[] args)
        {

            Players player = new Players();
            player.GenerateHand();
            Stack<string> Card = new Stack<string>();
            for (int i = 0; i < 52; i++)
            {
                // putting face in one array and putting suit in another array and also put together in one array

                Card.Push(player.hand[i].Face.ToString() + " of " + player.hand[i].Suits.ToString());

            }
            foreach (string i in Card)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
