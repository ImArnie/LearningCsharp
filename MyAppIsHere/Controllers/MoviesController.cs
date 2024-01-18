using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.Data;
using MyAppIsHere.Models;

namespace MyAppIsHere.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Moviee()
        {
            var db = WebMatrix.Data.Database.Open("DefaultConnection");
            var sql = "SELECT * FROM Movie";
            var movies = db.Query(sql);
            return View();
        }
    }
}
