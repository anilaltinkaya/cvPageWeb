using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cvPageWeb.Models.Entity;

namespace cvPageWeb.Controllers
{
    [Authorize]
    public class CvController : Controller
    {
        // GET: Cv
        resupEntities1 db = new resupEntities1();
        public ActionResult Cv_Index(int id)
        {
            var singular_info = db.TBL_SINGULAR_INFO.FirstOrDefault(x => x.member_id == id);

            var members = from d in db.TBL_MEMBERS.Where(d => d.id == id)
                          select new
                          {
                              email = d.email,
                              name = d.name,
                              surname = d.surname,
                              id = d.id,
                          };
            string member_id_string="";
            foreach (var item in members)
            {
                ViewBag.email = item.email;
                ViewBag.name = item.name;
                ViewBag.surname = item.surname;
                ViewBag.id = item.id;
                member_id_string = item.id.ToString();
            }

            if(User.IsInRole(member_id_string))
            {
                return View(singular_info);
            }
            else
            {
                return RedirectToAction("NotAuth", "Account");
            }

                
        }


        public ActionResult HtmlResume(int id)
        {
            var singular_info = db.TBL_SINGULAR_INFO.FirstOrDefault(x => x.member_id == id);

            var members = from d in db.TBL_MEMBERS.Where(d => d.id == id)
                          select new
                          {
                              email = d.email,
                              name = d.name,
                              surname = d.surname,
                              id = d.id,
                          };
            string member_id_string = "";
            foreach (var item in members)
            {
                ViewBag.email = item.email;
                ViewBag.name = item.name;
                ViewBag.surname = item.surname;
                ViewBag.id = item.id;
                member_id_string = item.id.ToString();
            }
            int experience_time_year = 0;
            int experience_time_month = 0;
            var experience_time = db.TBL_EXPERIENCE.Where(x => x.member_id == id && x.visible == "visible");
            foreach (var item in experience_time)
            {
                DateTime finishdate = Convert.ToDateTime(item.finish_date);
                DateTime startdate = Convert.ToDateTime(item.start_date);
                int year_time;
                int month_time;

                if (finishdate.Year==1 && finishdate.Month==1 && finishdate.Day==1)
                {
                    finishdate = DateTime.Now;
                }

                year_time = finishdate.Year-startdate.Year;
                month_time = finishdate.Month-startdate.Month;

                experience_time_year = experience_time_year+year_time;
                experience_time_month = experience_time_month + month_time;

            }

            if (experience_time_month<0)
            {
                experience_time_year = experience_time_year - 1;
                experience_time_month = 12 + experience_time_month;
            }

            

            if (experience_time_month>=12)
            {
                int years_in_month = experience_time_month / 12;
                experience_time_year = experience_time_year + years_in_month;
                experience_time_month = experience_time_month-12* years_in_month;
            }

            ViewBag.experience_time_year = experience_time_year;
            ViewBag.experience_time_month = experience_time_month;


            //string imageFilePath = "~"+db.TBL_SINGULAR_INFO.FirstOrDefault(x => x.member_id == id).profile_photo;

            //string imageFilePath = "img/profile_photos/04_12_2021__11_57__40profilepic.jfif";

            //byte[] imageArray = System.IO.File.ReadAllBytes(@imageFilePath);
            //string base64ImageRepresentation = Convert.ToBase64String(imageArray);

            //var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64ImageRepresentation)));

            //ViewBag.img = img;


            if (User.IsInRole(member_id_string))
            {
                return View(singular_info);
            }
            else
            {
                return RedirectToAction("NotAuth", "Account");
            }

        }

        public PartialViewResult Education_Data_onCV_html_resume(int member_id)
        {
            var education_data = db.TBL_EDUCATION.OrderByDescending(x=>x.placement).Where(x => x.member_id == member_id).ToList();
            return PartialView("Education_Data_onCV_html_resume", education_data);
        }

        public PartialViewResult Lang_Data_onCV_html_resume(int member_id)
        {
            var lang_data = db.TBL_LANG.OrderByDescending(x => x.placement).Where(x => x.member_id == member_id).ToList();

            return PartialView("Lang_Data_onCV_html_resume", lang_data);
        }
        public PartialViewResult Experience_Data_onCV_html_resume(int member_id)
        {
            var experience_data = db.TBL_EXPERIENCE.OrderByDescending(x => x.placement).Where(x => x.member_id == member_id).ToList();

            return PartialView("Experience_Data_onCV_html_resume", experience_data);
        }

        public PartialViewResult Projects_Data_onCV_html_resume(int member_id)
        {
            var experience_data = db.TBL_PROJECTS.OrderByDescending(x => x.placement).Where(x => x.member_id == member_id).ToList();

            return PartialView("Projects_Data_onCV_html_resume", experience_data);
        }

        public PartialViewResult Certificate_Data_onCV_html_resume(int member_id)
        {
            var experience_data = db.TBL_CERTIFICATE.OrderByDescending(x => x.placement).Where(x => x.member_id == member_id).ToList();

            return PartialView("Certificate_Data_onCV_html_resume", experience_data);
        }

        public PartialViewResult Ability_Data_onCV_html_resume(int member_id)
        {
            var experience_data = db.TBL_ABILITY.OrderByDescending(x => x.placement).Where(x => x.member_id == member_id).ToList();

            return PartialView("Ability_Data_onCV_html_resume", experience_data);
        }

        public PartialViewResult Ref_Data_onCV_html_resume(int member_id)
        {
            var experience_data = db.TBL_REFERENCE.OrderByDescending(x => x.placement).Where(x => x.member_id == member_id).ToList();

            return PartialView("Ref_Data_onCV_html_resume", experience_data);
        }

        public ActionResult GeneratePDF(int id)
        {
            if (User.IsInRole(id.ToString()))
            {
                string file_name = db.TBL_MEMBERS.Find(id).name + "_" + db.TBL_MEMBERS.Find(id).surname + "_" + DateTime.Now;



                return new Rotativa.ActionAsPdf
                    //("Cv_Index", new { id=id})
                    ("HtmlResume", new { id = id })
                {
                    FileName = file_name + ".pdf",
                    PageOrientation = Rotativa.Options.Orientation.Portrait,
                    PageSize = Rotativa.Options.Size.A4,

                };
            }
            else
            {
                return RedirectToAction("NotAuth", "Account");
            }

            
        }

        public PartialViewResult Education_Data_onCV(int member_id)
        {
            var education_data = db.TBL_EDUCATION.Where(x => x.member_id == member_id).ToList();

            return PartialView("Education_Data_onCV", education_data);
        }

        public PartialViewResult Lang_Data_onCV(int member_id)
        {
            var lang_data = db.TBL_LANG.Where(x => x.member_id == member_id).ToList();

            return PartialView("Lang_Data_onCV", lang_data);
        }

        public PartialViewResult Experience_Data_onCV(int member_id)
        {
            var experience_data = db.TBL_EXPERIENCE.Where(x => x.member_id == member_id).ToList();

            return PartialView("Experience_Data_onCV", experience_data);
        }

        public PartialViewResult Ability_Data_onCV(int member_id)
        {
            var ability_data = db.TBL_ABILITY.Where(x => x.member_id == member_id).ToList();

            return PartialView("Ability_Data_onCV", ability_data);
        }

        public PartialViewResult Hobby_Data_onCV(int member_id)
        {
            var hobby_data = db.TBL_HOBBY.Where(x => x.member_id == member_id).ToList();

            return PartialView("Hobby_Data_onCV", hobby_data);
        }


    }
}