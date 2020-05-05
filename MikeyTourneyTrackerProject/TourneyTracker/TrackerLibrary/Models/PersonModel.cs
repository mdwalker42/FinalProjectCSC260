using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Represents a unique identifier for the player.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents first name of player.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents player's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents player's phone number.
        /// </summary>
        public string CellphoneNumber { get; set; }

        /// <summary>
        /// Represents player's email address.
        /// </summary>
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}
