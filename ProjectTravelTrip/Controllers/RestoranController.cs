using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectTravelTrip.Models.Siniflar;

namespace ProjectTravelTrip.Controllers
{
    public class RestoranController : Controller
    {
        // GET: Restoran
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Restorans.ToList();
            return View(degerler);
        }
    }
}