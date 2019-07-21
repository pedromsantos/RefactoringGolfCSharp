using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round2.A
{
    public class FootballScoreStats
    {

        public int TeamTotal(String teamName)
        {
            int total = 0;
            Game[] played = new FootballData().GetAllPlayed();
            foreach (Game game in played)
            {
                int teamScore = 0;
                if (game.HomeTeam.Equals(teamName))
                {
                    teamScore = game.HomeTeamScore;
                }
                if (game.AwayTeam.Equals(teamName))
                {
                    teamScore = game.AwayTeamScore;
                }

                total += teamScore;
            }
            return total;
	}

    }
}
