using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cvPageWeb.Models.Entity;


namespace cvPageWeb.Controllers
{
    public class IndexController : Controller
    {
        resupEntities1 db = new resupEntities1();

        [AllowAnonymous]
        // GET: Index
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TBL_GUEST_MESSAGES p)
        {
            
            db.TBL_GUEST_MESSAGES.Add(p);
            db.SaveChanges();
            ViewBag.Mesaj = "Mesajınızı aldık. Size döneceğiz.";
            return View();
        }

        public ActionResult Test() 
        { 
            return View(); 
        }
        [HttpPost]
        public JsonResult Test(string Prefix)
        {
            //Note : you can bind same list from database  
            //List<TBL_CITY_LIST> ObjList = new List<TBL_CITY_LIST>()
            //{

            //    new TBL_CITY_LIST {id=1,city_name="Latur" },
            //    new TBL_CITY_LIST {id=2,city_name="Mumbai" },

            //};

            var ObjList = db.TBL_CITY_LIST.ToList();
            //Searching records from list using LINQ query  
            var city_name = (from N in ObjList
                        where N.location.ToLower().StartsWith(Prefix.ToLower())
                             select new { N.location });
            return Json(city_name, JsonRequestBehavior.AllowGet);
        }


         

        public ActionResult Robots()
        {
            Response.ContentType = "text/plain";
            return View();
        }
    }
}