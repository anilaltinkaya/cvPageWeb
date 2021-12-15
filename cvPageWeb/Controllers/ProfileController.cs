using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using cvPageWeb.Models.Entity;

namespace cvPageWeb.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        // GET: Profile
        resupEntities1 db = new resupEntities1();

        public ActionResult ProfilePage(int id)
        {
            var singular_info = db.TBL_SINGULAR_INFO.FirstOrDefault(x=>x.member_id==id);

            var members = from d in db.TBL_MEMBERS.Where(d => d.id == id)
                          select new
                          {
                              name = d.name,
                              surname = d.surname,
                              id = d.id,
                          };
            string member_id_string = "";
            foreach (var item in members)
            {
                ViewBag.name = item.name;
                ViewBag.surname = item.surname;
                ViewBag.id = item.id;
                member_id_string = item.id.ToString();
            }

            if (User.IsInRole(member_id_string))
            {
                return View(singular_info);
            }
            else
            {
                return RedirectToAction("NotAuth", "Account");
            }
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("SignInSingUp", "Account");
        }


    }
}