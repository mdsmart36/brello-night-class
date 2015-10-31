﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brello.Models
{
    public class Board
    {
        public int BoardId { get; set; }
        public string Title { get; set; }
        public virtual ICollection<BrelloList> Lists { get; set; }
        public virtual ICollection<ApplicationUser> Followers { get; set; }
    }
}
