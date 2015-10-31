using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Brello.Models
{
    public class BoardService
    {
        private BoardContext context;
        public BoardService(BoardContext _context) {
            context = _context;
        }

        
        public bool AddList(Board board, BrelloList list)
        {
            return false;
        }

        public List<BrelloList> GetAllLists()
        {
            return null;
        }

        // example of method overload
        public List<BrelloList> GetAllLists(Board board)
        {
            return null;
        }
    }
}