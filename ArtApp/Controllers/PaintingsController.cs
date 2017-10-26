using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtApp.Controllers
{
    public class PaintingsController : Controller
    {
        // GET: Paintings
        public ActionResult PastelsOnPreparedPaper()
        {
            return View();
        }
        public ActionResult OilOnCanvas()
        {
            return View();
        }
        public ActionResult OilOnPreparedPaper()
        {
            return View();
        }
        public ActionResult OilOnLinenCanvas()
        {
            return View();
        }
        public ActionResult SilverPointOnPaper()
        {
            return View();
        }
        public ActionResult SilverPointOnPreparedBoard()
        {
            return View();
        }
    }
}