using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player("Genti", 100, 40, 50);
            var player2 = new Player("Ylli", 100, 20, 70);

            var result = new PVPGame(player1, player2);
        }
    }
}
