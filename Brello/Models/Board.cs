using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Brello.Models
{
    public class Board
    {
        [Key]
        public int BoardId { get; set; }
        public string Title { get; set; }
        public ApplicationUser Owner { get; set; }
        // Changed from ICollection to List
        public virtual List<BrelloList> Lists { get; set; }
        public virtual List<ApplicationUser> Followers { get; set; }

        public Board() {
            Lists = new List<BrelloList>();
            Followers = new List<ApplicationUser>();
        }

    }
}