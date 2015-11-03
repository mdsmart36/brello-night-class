using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Brello.Models
{
    public class BoardContext : DbContext
    {
        // Uses the connection string from the Web.config named "BoardContext"
        //public BoardContext() : base("name=BoardContext") { }

        public virtual IDbSet<Color> Colors { get; set; }
        public virtual IDbSet<Card> Cards { get; set; }
        public virtual IDbSet<Board> Boards { get; set; }
    }
}