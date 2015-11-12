using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Brello.Models
{
    public class BoardRepository
    {
        private BoardContext context;
        public BoardRepository(BoardContext _context) {
            context = _context;
        }

        // void or bool or BrelloList
        public bool AddList(int _board_id, BrelloList _list)
        {
            var query = from b in context.Boards where b.BoardId == _board_id select b;
            Board found_board = null;
            bool result = true;
            try
            {
                found_board = query.Single<Board>();
                found_board.Lists.Add(_list);
                context.SaveChanges();
            }
            catch (InvalidOperationException)
            {
                result = false;
            }
            catch (ArgumentNullException)
            {
                result = false;
            }
            return result;
        }

        public List<BrelloList> GetAllLists()
        {
            var query = from l in context.Boards select l;
            return query.SelectMany(board => board.Lists).ToList();
        }

        // This is an example of overloading a method
        public List<BrelloList> GetAllLists(int _board_id)
        {
            var query = from b in context.Boards where b.BoardId == _board_id select b.Lists;
            return query.Single<List<BrelloList>>();
        }

        public Board CreateBoard(string title, ApplicationUser owner)
        {
            Board my_board = new Board { Title = title, Owner = owner};
            context.Boards.Add(my_board);
            context.SaveChanges(); // This saves something to the Database

            return my_board;
        }

        public List<Board> GetAllBoards()
        {
            return context.Boards.ToList();
        }

        public int GetBoardCount()
        {
            var query = from b in context.Boards select b;
            // Same As -> context.Boards.ToList().Count
            
            return query.Count();
        }

        public List<Board> GetBoards(ApplicationUser user1)
        {
            var query = from b in context.Boards where b.Owner == user1 select b;
            return query.ToList<Board>(); // Same as query.ToList();
        }

        public int GetListCount()
        {
            return GetAllLists().Count;
        }

        public Board UpdateBoardTitle(string title, ApplicationUser owner, string newTitle)
        {
            // find the board with title and owner
            var query = context.Boards.Where(b => b.Title == title).Where(b => b.Owner == owner);
            var result = query.First();

            // assign newTitle to title and return board
            result.Title = newTitle;
            context.SaveChanges();
            return result;
        }

        public Board UpdateBoardOwner(string title, ApplicationUser owner, ApplicationUser newOwner)
        {
            // find the board with title and owner
            var query = context.Boards.Where(b => b.Title == title).Where(b => b.Owner == owner);
            var result = query.First();

            // assign newTitle to title and return board
            result.Owner = newOwner;
            context.SaveChanges();            
            return result;
        }

        public Board DeleteBoard(int boardId)
        {
            // find the board using the unique BoardId
            var query = from b in context.Boards where b.BoardId == boardId select b;
            Board found_board;
            try
            {            
                found_board = query.First();
                context.Boards.Remove(found_board);
                context.SaveChanges();
                return found_board;
            }
            catch (Exception)
            {
                throw;
            }            
        }
    }
}