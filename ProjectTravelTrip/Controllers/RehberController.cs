using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectTravelTrip.Models.Siniflar;

namespace ProjectTravelTrip.Controllers
{
    public class RehberController : Controller
    {
        // GET: Rehber
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Otels.ToList();
            return View(degerler);
        }
        public PartialViewResult RestoranPartial()
        {
            var degerler = c.Restorans.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(degerler);
        }
        public ActionResult OtelDetay(int id)
        {

            //  var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
             var Deger = c.Otels.Where(x => x.ID == id).ToList();
            
            return View(Deger);
        }


    }
}