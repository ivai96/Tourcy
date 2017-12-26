using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tourcy1.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Reservation/new
        public ActionResult New()
        {
            return View();
        }
    }
}