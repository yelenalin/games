using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using games.Models;

namespace games.Controllers
{
    public class GameController : Controller
    {
        gamesEntities1 db = new gamesEntities1();
        // GET: Game
        
        public ActionResult Leisure(string type = "CA00001")
        {
            ViewBag.game_type = db.game_type
               .Where(m => m.type_no == type)
               .FirstOrDefault().type_name;
            Typelink vm = new Typelink()
            {
                gametype = db.game_type.ToList(),
                gamelist = db.gamelist.Where(m => m.game_type == type).ToList()
            };
            return View(vm);
        }

        public ActionResult Mulpitlayer(string type = "CA00002")
        {
            ViewBag.game_type = db.game_type
               .Where(m => m.type_no == type)
               .FirstOrDefault().type_name;
            Typelink vm = new Typelink()
            {
                gametype = db.game_type.ToList(),
                gamelist = db.gamelist.Where(m => m.game_type == type).ToList()
            };
            return View(vm);
        }

        public ActionResult Cosplay(string type = "CA00003")
        {
            ViewBag.game_type = db.game_type
               .Where(m => m.type_no == type)
               .FirstOrDefault().type_name;
            Typelink vm = new Typelink()
            {
                gametype = db.game_type.ToList(),
                gamelist = db.gamelist.Where(m => m.game_type == type).ToList()
            };
            return View(vm);
        }

        public ActionResult Adventure(string type = "CA00004")
        {
            ViewBag.game_type = db.game_type
               .Where(m => m.type_no == type)
               .FirstOrDefault().type_name;
            Typelink vm = new Typelink()
            {
                gametype = db.game_type.ToList(),
                gamelist = db.gamelist.Where(m => m.game_type == type).ToList()
            };
            return View(vm);
        }

        public ActionResult Action(string type = "CA00005")
        {
            ViewBag.game_type = db.game_type
               .Where(m => m.type_no == type)
               .FirstOrDefault().type_name;
            Typelink vm = new Typelink()
            {
                gametype = db.game_type.ToList(),
                gamelist = db.gamelist.Where(m => m.game_type == type).ToList()
            };
            return View(vm);
        }

        public ActionResult Strategy(string type = "CA00006")
        {
            ViewBag.game_type = db.game_type
               .Where(m => m.type_no == type)
               .FirstOrDefault().type_name;
            Typelink vm = new Typelink()
            {
                gametype = db.game_type.ToList(),
                gamelist = db.gamelist.Where(m => m.game_type == type).ToList()
            };
            return View(vm);
        }

        public ActionResult Independent(string type = "CA00007")
        {
            ViewBag.game_type = db.game_type
                .Where(m => m.type_no == type)
                .FirstOrDefault().type_name;
            Typelink vm = new Typelink()
            {
                gametype = db.game_type.ToList(),
                gamelist = db.gamelist.Where(m => m.game_type == type).ToList()
            };
            return View(vm);
        }

        public ActionResult Racing(string type = "CA00008")
        {
            ViewBag.game_type = db.game_type
               .Where(m => m.type_no == type)
               .FirstOrDefault().type_name;
            Typelink vm = new Typelink()
            {
                gametype = db.game_type.ToList(),
                gamelist = db.gamelist.Where(m => m.game_type == type).ToList()
            };
            return View(vm);
        }
    }
}