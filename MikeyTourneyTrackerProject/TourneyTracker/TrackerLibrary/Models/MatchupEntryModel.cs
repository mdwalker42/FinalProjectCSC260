using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents a unique identifier for the matchup.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// unique identifier for the team.
        /// </summary>
        public int TeamCompetingId { get; set; }

        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Unique identifier for the parent matchup (team).
        /// </summary>
        public int ParentMatchupId { get; set; }

        /// <summary>
        /// Represents the score for this team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the previous matchup this team won.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
