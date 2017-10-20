using System.Collections.Generic;

namespace PlayerConsole
{
    public delegate void AttackReportHandler(Player attacker, Player defender);
    internal class PVPGame
    {
        private List<Player> _players = new List<Player>();
        private int playerPos = 1;
        public event AttackReportHandler AttackReport;

        public PVPGame(Player player1, Player player2)
        {
            _players.Add(player1);
            _players.Add(player2);
        }
    }
}