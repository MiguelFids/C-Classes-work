using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player("Frankenstein");

            while (player.GetLivesLeft() > 0)
            {
                player.AddPoints(100);

                player.Kill();
            }

        }
    }
}
