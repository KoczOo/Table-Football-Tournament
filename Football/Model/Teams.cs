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
        public List<string> RandomizedTeams { get; set; }
        private List<string> playersList;
        private Random rng = new Random();

        public Teams()
        {
            GetPlayers();
            Shuffle();
            CreateTeams();
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

        public void CreateTeams()
        {
            RandomizedTeams = new List<string>();
            if (playersList.Count % 2 == 1)
            {
                playersList.Add("DefaultPlayer");
            }
            for (int i = 0; i < playersList.Count - 1; i = i + 2)
            {
                RandomizedTeams.Add(playersList[i] + " " + playersList[i + 1]);
            }
        }
    }
}
