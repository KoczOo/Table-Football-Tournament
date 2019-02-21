using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;

namespace Football.Model
{
    public class Teams
    {
        private List<string> playersList;
        private Random rng = new Random();

        public Teams()
        {
            GetPlayers();
        }

        public void Shuffle()
        {
            int n = playersList.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = playersList[k];
                playersList[k] = playersList[n];
                playersList[n] = value;
            }
        }

        private void GetPlayers()
        {
            using (var context = new PlayersDBContext())
            {
                playersList = context.Players.Select(player => player.PlayerName).ToList();
                context.Dispose();
            }
        }

        private string createTeamName(string player1, string player2)
        {
            return player1 + "/" + player2;
        }

        private List<string> createTeams()
        {
            for (int i = 0; i < playersList.Count; i ++)
            {

            }
            
        }
    }
}
