using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectTravelTrip.Models.Siniflar;

namespace ProjectTravelTrip.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        Context c = new Context();
       
       
       
        public ActionResult Index(Iletisim i)
        {
            c.Iletisims.Add(i);
            c.SaveChanges();
            return View();
        }
    }
}


