using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents a unique identifier for the matchup.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Not sure what this represents.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// ID from database if you are using one.
        /// </summary>
        public int WinnerId { get; set; }


        /// <summary>
        /// Represents the winner I think.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the matchup round.
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName 
        {
            get
            {
                string output = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. { me.TeamCompeting.TeamName }";
                        } 
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined";
                        break;
                    }
                }

                return output;
            }
        }
    }
}
