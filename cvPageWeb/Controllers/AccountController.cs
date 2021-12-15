using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cvPageWeb.Models.Entity;
using System.Web.Security;

namespace cvPageWeb.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {

        resupEntities1 db = new resupEntities1();

        // GET: Account
        public ActionResult SignInSingUp()
        {
            return View();
        }

        public ActionResult SingUp()
        {
            return View();
        }
        public ActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgotPassword(TBL_RESET_PASS_REQUEST p)
        {
            var member_email = db.TBL_MEMBERS.Where(x => x.email == p.email);
            if (member_email.Count()==0)
            {
                ViewBag.ForgotPassMessage = "Bu mail adresi kayıtlı değil.";
                return View();
            }
            else
            {
                db.TBL_RESET_PASS_REQUEST.Add(p);
                db.SaveChanges();
                return RedirectToAction("ResetPassRequestOk", "Account");
            }
            
        }
        public ActionResult RegisterOk()
        {
            return View();
        }
        public ActionResult ResetPassRequestOk()
        {
            return View();
        }
        public ActionResult NotAuth()
        {
            return View();
        }


        //[ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult SingUp(TBL_MEMBERS p)
        {
            var member_username = db.TBL_MEMBERS.Where(x=>x.username==p.username);
            var member_email = db.TBL_MEMBERS.Where(x => x.email == p.email);
            if (!ModelState.IsValid)
            {
                //ViewBag.Mesaj = "Tüm alanları doldurduğunuzdan emin olun.";
                return View(p);
            }
            else if (member_username.Count()!=0)
            {
                ViewBag.KayitMesaj = "Bu kullanıcı adı başka üye tarafından kullanılıyor.Lütfen değiştirip yeniden deneyiniz.";
                return View();
            }
            else if (member_email.Count() != 0)
            {
                ViewBag.KayitMesaj = "Bu e-posta adresi başka üye tarafından kullanılıyor.Lütfen değiştirip yeniden deneyiniz.";
                return View();
            }
            else
            {
                db.TBL_MEMBERS.Add(p);
                db.SaveChanges();
                return RedirectToAction("RegisterOk", "Account");
            }

        }

        [HttpPost]
        public ActionResult SignInSingUp(TBL_MEMBERS p)
        {
            var user_login_data = db.TBL_MEMBERS.FirstOrDefault(x => x.username == p.username && x.password == p.password);
            if (user_login_data != null)
            {
                FormsAuthentication.SetAuthCookie(user_login_data.username, false);
                Session["id"] = user_login_data.id.ToString();
                Session["username"] = user_login_data.username.ToString();
                Session["name"] = user_login_data.name.ToString();
                Session["surname"] = user_login_data.surname.ToString();

                return RedirectToAction("ProfilePage", "Profile", new { id = user_login_data.id });
            }
            else
            {
                ViewBag.LoginErrorMessage = "Kullanıcı adı veya parola hatalı.Kontrol edip yeniden deneyiniz.";
                return View();
            }
        }




    }
}