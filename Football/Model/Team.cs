using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Model
{
    public class Team
    {
        public string TeamName { get; set; }

        public Team(string player1, string player2)
        {
            TeamName = createTeamName(player1, player2);
        }

        private string createTeamName(string player1, string player2)
        {
            return player1 + "/" + player2;
        }
    }
}
