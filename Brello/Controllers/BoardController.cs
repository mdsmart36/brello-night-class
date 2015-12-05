using Brello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Brello.Controllers
{
    public class BoardController : Controller
    {
        private BoardRepository repository;
        //private Mock<>

        public BoardController()
        {
            repository = new BoardRepository();
        }

        public BoardController(BoardRepository _repo)
        {
            repository = _repo;
        }

        // GET: Board
        [Authorize]
        public ActionResult Index()
        {
            //UserManager<ApplicationUser> manager = new UserManager<ApplicationUser>();
            //UserManager<ApplicationUser> manager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            string user_id = User.Identity.GetUserId();
            ApplicationUser me = repository.Users.FirstOrDefault(u => u.Id == user_id);

            List<Board> boards = repository.GetBoards(me);
            Board my_board = null;
            if (boards.Count() == 0)
            {
                 my_board = repository.CreateBoard("My Board", me);
            } else
            {
                my_board = boards.First();
            }
            ViewBag.Title = my_board.Title;
            ViewBag.CurrentBoardId = my_board.BoardId;

            //bool successful = repository.AddList(my_board.BoardId, new BrelloList { Title = "ToDo" });

            List<BrelloList> board_lists = repository.GetAllLists(my_board.BoardId);

            return View(board_lists);
        }

        // GET: Board/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Board/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateList(FormCollection form)
        {
            string list_name = form.Get("list-name");
            string board_id = form.Get("board-id");
            Board current_board = repository.GetBoardById(int.Parse(board_id));
            if (current_board != null)
            {
                repository.AddList(current_board.BoardId, new BrelloList { Title = list_name });
            }

            return RedirectToAction("Index");

        }

        // POST: Board/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Board/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Board/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Board/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Board/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
