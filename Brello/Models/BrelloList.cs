using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Brello.Models
{
    public class BrelloList
    {
        [Key]
        public int BrelloListId { get; set; }
        public string Title { get; set; }
        public List<Card> Cards { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}