using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cvPageWeb.Models.Entity;

namespace cvPageWeb.Controllers
{
    [Authorize]
    public class EditController : Controller
    {
        // GET: Edit
        resupEntities1 db = new resupEntities1();

        public ActionResult EditProfile(int id,string mesaj)
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

            ViewBag.Mesaj = mesaj;
            if (User.IsInRole(member_id_string))
            {
                return View(singular_info);
            }
            else
            {
                return RedirectToAction("NotAuth", "Account");
            }
        }

        public ActionResult EducationEdit(int id,string mesaj)
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
            ViewBag.Mesaj=mesaj;
            if (User.IsInRole(member_id_string))
            {
                return View(singular_info);
            }
            else
            {
                return RedirectToAction("NotAuth", "Account");
            }
        }

        

        public ActionResult LangEdit(int id)
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

            if (User.IsInRole(member_id_string))
            {
                return View(singular_info);
            }
            else
            {
                return RedirectToAction("NotAuth", "Account");
            }
        }

        public ActionResult ExperienceEdit(int id)
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

            if (User.IsInRole(member_id_string))
            {
                return View(singular_info);
            }
            else
            {
                return RedirectToAction("NotAuth", "Account");
            }
        }

        public ActionResult ProjectsEdit(int id, string mesaj)
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
            ViewBag.Mesaj = mesaj;
            if (User.IsInRole(member_id_string))
            {
                return View(singular_info);
            }
            else
            {
                return RedirectToAction("NotAuth", "Account");
            }
        }


        public ActionResult CertificateEdit(int id, string mesaj)
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
            ViewBag.Mesaj = mesaj;
            if (User.IsInRole(member_id_string))
            {
                return View(singular_info);
            }
            else
            {
                return RedirectToAction("NotAuth", "Account");
            }
        }

        public ActionResult AbilityEdit(int id)
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

            if (User.IsInRole(member_id_string))
            {
                return View(singular_info);
            }
            else
            {
                return RedirectToAction("NotAuth", "Account");
            }
        }

        public ActionResult HobbyEdit(int id)
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

            if (User.IsInRole(member_id_string))
            {
                return View(singular_info);
            }
            else
            {
                return RedirectToAction("NotAuth", "Account");
            }
        }


        public ActionResult ReferenceEdit(int id)
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

            if (User.IsInRole(member_id_string))
            {
                return View(singular_info);
            }
            else
            {
                return RedirectToAction("NotAuth", "Account");
            }
        }


        [HttpPost]
        public ActionResult EditProfile(TBL_SINGULAR_INFO p, TBL_MEMBERS m)
        {
            var singular_info = db.TBL_SINGULAR_INFO.Find(p.id);
            singular_info.job = p.job;
            singular_info.tel = p.tel;
            singular_info.tel_visible = p.tel_visible;
            singular_info.birt_date = p.birt_date;
            singular_info.gender = p.gender;
            singular_info.drive_licence = p.drive_licence;
            singular_info.nationality = p.nationality;
            singular_info.nation_visible = p.nation_visible;
            singular_info.military_situation = p.military_situation;
            singular_info.military_date = p.military_date;
            singular_info.mlitary_visible = p.mlitary_visible;
            singular_info.linkedin = p.linkedin;
            singular_info.location = p.location;
            singular_info.summary = p.summary;

            var members = db.TBL_MEMBERS.Find(p.member_id);
            members.email = m.email;
            members.name = m.name;
            members.surname = m.surname;

            db.SaveChanges();

            string update_ok = "Genel bilgiler güncellendi. Şimdi eğitim bilgilerini güncelleyebilirsiniz.";

            return RedirectToAction("EditProfile", "Edit", new { id = p.member_id, mesaj = update_ok });
        }







        public ActionResult Update_Profile_Data(TBL_SINGULAR_INFO p, TBL_MEMBERS m)
        {
            var singular_info = db.TBL_SINGULAR_INFO.Find(p.id);
            singular_info.job = p.job;
            singular_info.tel = p.tel;
            singular_info.tel_visible = p.tel_visible;
            singular_info.birt_date = p.birt_date;
            singular_info.gender = p.gender;
            singular_info.drive_licence = p.drive_licence;
            singular_info.nationality = p.nationality;
            singular_info.nation_visible = p.nation_visible;
            singular_info.military_situation = p.military_situation;
            singular_info.military_date = p.military_date;
            singular_info.mlitary_visible = p.mlitary_visible;
            singular_info.linkedin = p.linkedin;
            singular_info.location = p.location;
            singular_info.summary = p.summary;

            var members = db.TBL_MEMBERS.Find(p.member_id);
            members.email = m.email;
            members.name = m.name;
            members.surname = m.surname;

            db.SaveChanges();

            string update_ok = "Genel bilgiler güncellendi. Şimdi eğitim bilgilerini güncelleyebilirsiniz.";

            return RedirectToAction("EditProfile", "Edit", new { id = p.member_id,mesaj=update_ok });
        }







        // EDUCATION DATA -----------------------------------------------------------------------------------
        public PartialViewResult Education_Data(int member_id)
        {
            var education_data = db.TBL_EDUCATION.Where(x => x.member_id == member_id).ToList();

            return PartialView("Education_Data", education_data);
        }


        public ActionResult Add_Education_Data(TBL_EDUCATION p, TBL_MEMBERS m)
        {
            db.TBL_EDUCATION.Add(p);
            db.SaveChanges();
            string add_ok = "Eğitim bilginiz eklendi.Başka eğitim bilgisi eklemeyecekseniz, yabancı dil bilgileri düzenleme sayfasına gidebilirsiniz.";

            var members = db.TBL_MEMBERS.Find(p.member_id);

            return RedirectToAction("EducationEdit", "Edit", new { id = p.member_id,mesaj=add_ok });
        }


        public ActionResult EducationDelete(int member_id,int id)
        {
            var education = db.TBL_EDUCATION.Find(id);
            db.TBL_EDUCATION.Remove(education);
            db.SaveChanges();
            return RedirectToAction("EducationEdit", "Edit", new { id = member_id });
        }

        [HttpGet]
        public ActionResult Update_Education_Data(int id)
        {
            var education_data = db.TBL_EDUCATION.Find(id);

            return PartialView("Update_Education_Data", education_data);
        }
        [HttpPost]
        public ActionResult Update_Education_Data(TBL_EDUCATION p)
        {
            var education_info = db.TBL_EDUCATION.Find(p.id);
            //education_info.education_start_date_day = p.education_start_date_day;
            //education_info.education_start_date_month = p.education_start_date_month;
            //education_info.education_start_date_year = p.education_start_date_year;

            //education_info.education_finish_date_day = p.education_finish_date_day;
            //education_info.education_finish_date_month = p.education_finish_date_month;
            //education_info.education_finish_date_year = p.education_finish_date_year;

            education_info.department = p.department;
            education_info.school = p.school;
            education_info.education_start_date = p.education_start_date;
            education_info.education_finish_date = p.education_finish_date;
            education_info.placement = p.placement;
            education_info.gpa = p.gpa;
            education_info.gpa_full = p.gpa_full;
            education_info.lang = p.lang;
            education_info.visible = p.visible;
            education_info.gpa_visible = p.gpa_visible;







            var members = db.TBL_MEMBERS.Find(p.member_id);

            db.SaveChanges();

            return RedirectToAction("EducationEdit", "Edit", new { id = p.member_id });
        }



        // LANGUAGE DATA -----------------------------------------------------------------------------------
        public PartialViewResult lang_Data(int member_id)
        {
            var lang_data = db.TBL_LANG.Where(x => x.member_id == member_id).ToList();

            return PartialView("lang_Data", lang_data);
        }

        
        public ActionResult Add_Lang_Data(TBL_LANG p)
        {

            db.TBL_LANG.Add(p);
            db.SaveChanges();

            return RedirectToAction("LangEdit", "Edit", new { id = p.member_id });
        }
        public ActionResult LangDelete(int member_id, int id)
        {
            var lang = db.TBL_LANG.Find(id);
            db.TBL_LANG.Remove(lang);
            db.SaveChanges();
            return RedirectToAction("LangEdit", "Edit", new { id = member_id });
        }
        [HttpGet]
        public ActionResult Update_Lang_Data(int id)
        {
            var lang_data = db.TBL_LANG.Find(id);

            return PartialView("Update_Lang_Data", lang_data);
        }
        [HttpPost]
        public ActionResult Update_Lang_Data(TBL_LANG p)
        {
            var lang_info = db.TBL_LANG.Find(p.id);
            lang_info.lang = p.lang;
            lang_info.placement = p.placement;
            lang_info.point_source = p.point_source;
            lang_info.point = p.point;
            lang_info.point_full = p.point_full;
            lang_info.point_visible = p.point_visible;
            lang_info.reading_point = p.reading_point;
            lang_info.reading_point_full = p.reading_point_full;

            lang_info.writing_point = p.writing_point;
            lang_info.writing_point_full = p.writing_point_full;

            lang_info.speaking_point = p.speaking_point;
            lang_info.speaking_point_full = p.speaking_point_full;

            lang_info.rws_visible = p.rws_visible;
            lang_info.visible = p.visible;












            var members = db.TBL_MEMBERS.Find(p.member_id);

            db.SaveChanges();

            return RedirectToAction("langEdit", "Edit", new { id = p.member_id });
        }



        // Experience DATA -----------------------------------------------------------------------------------
        public PartialViewResult Experience_Data(int member_id)
        {
            var experience_data = db.TBL_EXPERIENCE.Where(x => x.member_id == member_id).ToList();

            return PartialView("Experience_Data", experience_data);
        }
        public ActionResult Add_Experience_Data(TBL_EXPERIENCE p)
        {
            db.TBL_EXPERIENCE.Add(p);
            db.SaveChanges();

            return RedirectToAction("ExperienceEdit", "Edit", new { id = p.member_id });
        }
        public ActionResult ExperienceDelete(int member_id, int id)
        {
            var experience = db.TBL_EXPERIENCE.Find(id);
            db.TBL_EXPERIENCE.Remove(experience);
            db.SaveChanges();
            return RedirectToAction("ExperienceEdit", "Edit", new { id = member_id });
        }
        [HttpGet]
        public ActionResult Update_Experience_Data(int id)
        {
            var experience_data = db.TBL_EXPERIENCE.Find(id);

            return PartialView("Update_Experience_Data", experience_data);
        }
        [HttpPost]
        public ActionResult Update_Experience_Data(TBL_EXPERIENCE p)
        {
            var experience_info = db.TBL_EXPERIENCE.Find(p.id);


            experience_info.company_name = p.company_name;
            experience_info.title = p.title;
            experience_info.description = p.description;
            experience_info.placement = p.placement;
            experience_info.visible = p.visible;
            experience_info.start_date = p.start_date;
            experience_info.finish_date = p.finish_date;






            db.SaveChanges();

            return RedirectToAction("ExperienceEdit", "Edit", new { id = p.member_id });
        }


        // Ability DATA -----------------------------------------------------------------------------------
        public PartialViewResult Ability_Data(int member_id)
        {
            var ability_data = db.TBL_ABILITY.Where(x => x.member_id == member_id).ToList();

            return PartialView("Ability_Data", ability_data);
        }
        public ActionResult Add_Ability_Data(TBL_ABILITY p)
        {
            db.TBL_ABILITY.Add(p);
            db.SaveChanges();

            return RedirectToAction("AbilityEdit", "Edit", new { id = p.member_id });
        }
        public ActionResult AbilityDelete(int member_id, int id)
        {
            var ability = db.TBL_ABILITY.Find(id);
            db.TBL_ABILITY.Remove(ability);
            db.SaveChanges();
            return RedirectToAction("AbilityEdit", "Edit", new { id = member_id });
        }
        [HttpGet]
        public ActionResult Update_Ability_Data(int id)
        {
            var ability_data = db.TBL_ABILITY.Find(id);

            return PartialView("Update_Ability_Data", ability_data);
        }
        [HttpPost]
        public ActionResult Update_Ability_Data(TBL_ABILITY p)
        {
            var ability_info = db.TBL_ABILITY.Find(p.id);
            ability_info.ability_name = p.ability_name;
            ability_info.ability_description = p.ability_description;
            ability_info.visible = p.visible;
            ability_info.placement = p.placement;



            db.SaveChanges();

            return RedirectToAction("AbilityEdit", "Edit", new { id = p.member_id });
        }


        // Hobby DATA -----------------------------------------------------------------------------------
        public PartialViewResult Hobby_Data(int member_id)
        {
            var hobby_data = db.TBL_HOBBY.Where(x => x.member_id == member_id).ToList();

            return PartialView("Hobby_Data", hobby_data);
        }
        public ActionResult Add_Hobby_Data(TBL_HOBBY p)
        {
            db.TBL_HOBBY.Add(p);
            db.SaveChanges();

            return RedirectToAction("HobbyEdit", "Edit", new { id = p.member_id });
        }
        public ActionResult HobbyDelete(int member_id, int id)
        {
            var hobby = db.TBL_HOBBY.Find(id);
            db.TBL_HOBBY.Remove(hobby);
            db.SaveChanges();
            return RedirectToAction("HobbyEdit", "Edit", new { id = member_id });
        }
        [HttpGet]
        public ActionResult Update_Hobby_Data(int id)
        {
            var hobby_data = db.TBL_HOBBY.Find(id);

            return PartialView("Update_Hobby_Data", hobby_data);
        }
        [HttpPost]
        public ActionResult Update_Hobby_Data(TBL_HOBBY p)
        {
            var hobby_info = db.TBL_HOBBY.Find(p.id);
            hobby_info.hobby = p.hobby;
            db.SaveChanges();

            return RedirectToAction("HobbyEdit", "Edit", new { id = p.member_id });
        }






        // PROJECTS DATA -----------------------------------------------------------------------------------
        public PartialViewResult Projects_Data(int member_id)
        {
            var projects_data = db.TBL_PROJECTS.Where(x => x.member_id == member_id).ToList();

            return PartialView("Projects_Data", projects_data);
        }


        public ActionResult Add_Projects_Data(TBL_PROJECTS p, TBL_MEMBERS m)
        {
            db.TBL_PROJECTS.Add(p);
            db.SaveChanges();
            //string add_ok = "Proje bilginiz eklendi.Başka eğitim bilgisi eklemeyecekseniz, yabancı dil bilgileri düzenleme sayfasına gidebilirsiniz.";

            var members = db.TBL_MEMBERS.Find(p.member_id);

            return RedirectToAction("ProjectsEdit", "Edit", new { id = p.member_id});
        }


        public ActionResult ProjectsDelete(int member_id, int id)
        {
            var project = db.TBL_PROJECTS.Find(id);
            db.TBL_PROJECTS.Remove(project);
            db.SaveChanges();
            return RedirectToAction("ProjectsEdit", "Edit", new { id = member_id });
        }

        [HttpGet]
        public ActionResult Update_Projects_Data(int id)
        {
            var project_data = db.TBL_PROJECTS.Find(id);

            return PartialView("Update_Projects_Data", project_data);
        }
        [HttpPost]
        public ActionResult Update_Projects_Data(TBL_PROJECTS p)
        {
            var education_info = db.TBL_PROJECTS.Find(p.id);

            education_info.placement = p.placement;
            education_info.projects_name = p.projects_name;
            education_info.start_date = p.start_date;
            education_info.finish_date = p.finish_date;
            education_info.position = p.position;
            education_info.description = p.description;
            education_info.company_name = p.company_name;
            education_info.visible = p.visible;

            var members = db.TBL_MEMBERS.Find(p.member_id);

            db.SaveChanges();

            return RedirectToAction("ProjectsEdit", "Edit", new { id = p.member_id });
        }







        // CERTIFICATE DATA -----------------------------------------------------------------------------------
        public PartialViewResult Certificate_Data(int member_id)
        {
            var certificate_data = db.TBL_CERTIFICATE.Where(x => x.member_id == member_id).ToList();

            return PartialView("Certificate_Data", certificate_data);
        }


        public ActionResult Add_Certificate_Data(TBL_CERTIFICATE p, TBL_MEMBERS m)
        {
            db.TBL_CERTIFICATE.Add(p);
            db.SaveChanges();
            //string add_ok = "Proje bilginiz eklendi.Başka eğitim bilgisi eklemeyecekseniz, yabancı dil bilgileri düzenleme sayfasına gidebilirsiniz.";

            var members = db.TBL_MEMBERS.Find(p.member_id);

            return RedirectToAction("CertificateEdit", "Edit", new { id = p.member_id });
        }


        public ActionResult CertificateDelete(int member_id, int id)
        {
            var certificate = db.TBL_CERTIFICATE.Find(id);
            db.TBL_CERTIFICATE.Remove(certificate);
            db.SaveChanges();
            return RedirectToAction("CertificateEdit", "Edit", new { id = member_id });
        }

        [HttpGet]
        public ActionResult Update_Certificate_Data(int id)
        {
            var certificate_data = db.TBL_CERTIFICATE.Find(id);

            return PartialView("Update_Certificate_Data", certificate_data);
        }
        [HttpPost]
        public ActionResult Update_Certificate_Data(TBL_CERTIFICATE p)
        {
            var certificate_info = db.TBL_CERTIFICATE.Find(p.id);

            certificate_info.placement = p.placement;
            certificate_info.date = p.date;
            certificate_info.source = p.source;
            certificate_info.certificate_name = p.certificate_name;
            certificate_info.visible = p.visible;



            var members = db.TBL_MEMBERS.Find(p.member_id);

            db.SaveChanges();

            return RedirectToAction("CertificateEdit", "Edit", new { id = p.member_id });
        }




        // Reference DATA -----------------------------------------------------------------------------------
        public PartialViewResult Reference_Data(int member_id)
        {
            var ability_data = db.TBL_REFERENCE.Where(x => x.member_id == member_id).ToList();

            return PartialView("Reference_Data", ability_data);
        }
        public ActionResult Add_Reference_Data(TBL_REFERENCE p)
        {
            db.TBL_REFERENCE.Add(p);
            db.SaveChanges();

            return RedirectToAction("ReferenceEdit", "Edit", new { id = p.member_id });
        }
        public ActionResult ReferenceDelete(int member_id, int id)
        {
            var ability = db.TBL_REFERENCE.Find(id);
            db.TBL_REFERENCE.Remove(ability);
            db.SaveChanges();
            return RedirectToAction("ReferenceEdit", "Edit", new { id = member_id });
        }
        [HttpGet]
        public ActionResult Update_Reference_Data(int id)
        {
            var ability_data = db.TBL_REFERENCE.Find(id);

            return PartialView("Update_Reference_Data", ability_data);
        }
        [HttpPost]
        public ActionResult Update_Reference_Data(TBL_REFERENCE p)
        {
            var ability_info = db.TBL_REFERENCE.Find(p.id);
            ability_info.reference_name = p.reference_name;
            ability_info.working_at = p.working_at;
            ability_info.title = p.title;
            ability_info.ref_tel = p.ref_tel;
            ability_info.ref_mail = p.ref_mail;
            ability_info.visible = p.visible;
            ability_info.placement = p.placement;



            db.SaveChanges();

            return RedirectToAction("ReferenceEdit", "Edit", new { id = p.member_id });
        }




        // Bölümlerin Header ve Görünürlük Ayarları
        public PartialViewResult Header_Visibility_Singular_Data(int member_id)
        {
            var singular_data = db.TBL_SINGULAR_INFO.FirstOrDefault(x=>x.member_id==member_id);

            return PartialView("Header_Visibility_Singular_Data", singular_data);
        }
        public ActionResult Update_Header_Visibility_Singular_Data(TBL_SINGULAR_INFO p)
        {
            var singular_info = db.TBL_SINGULAR_INFO.Find(p.id);
            singular_info.summary_head = p.summary_head;
            singular_info.summary_visible = p.summary_visible;
            singular_info.contact_head = p.contact_head;
            singular_info.contact_visible = p.contact_visible;
            singular_info.personel_info_head = p.personel_info_head;
            singular_info.personel_info_visible = p.personel_info_visible;

            db.SaveChanges();

            return RedirectToAction("EditProfile", "Edit", new { id = p.member_id });
        }
        public PartialViewResult Header_Visibility_Education_Data(int member_id)
        {
            var singular_data = db.TBL_SINGULAR_INFO.FirstOrDefault(x => x.member_id == member_id);

            return PartialView("Header_Visibility_Education_Data", singular_data);
        }
        public ActionResult Update_Header_Visibility_Education_Data(TBL_SINGULAR_INFO p)
        {
            var singular_info = db.TBL_SINGULAR_INFO.Find(p.id);
            singular_info.education_head = p.education_head;
            singular_info.education_visible = p.education_visible;

            db.SaveChanges();

            return RedirectToAction("EducationEdit", "Edit", new { id = p.member_id });
        }

        public PartialViewResult Header_Visibility_Lang_Data(int member_id)
        {
            var singular_data = db.TBL_SINGULAR_INFO.FirstOrDefault(x => x.member_id == member_id);

            return PartialView("Header_Visibility_Lang_Data", singular_data);
        }
        public ActionResult Update_Header_Visibility_Lang_Data(TBL_SINGULAR_INFO p)
        {
            var singular_info = db.TBL_SINGULAR_INFO.Find(p.id);
            singular_info.lang_head = p.lang_head;
            singular_info.lang_visible = p.lang_visible;

            db.SaveChanges();

            return RedirectToAction("LangEdit", "Edit", new { id = p.member_id });
        }
        public PartialViewResult Header_Visibility_Experience_Data(int member_id)
        {
            var singular_data = db.TBL_SINGULAR_INFO.FirstOrDefault(x => x.member_id == member_id);

            return PartialView("Header_Visibility_Experience_Data", singular_data);
        }
        public ActionResult Update_Header_Visibility_Experience_Data(TBL_SINGULAR_INFO p)
        {
            var singular_info = db.TBL_SINGULAR_INFO.Find(p.id);
            singular_info.experience_head = p.experience_head;
            singular_info.experience_visible = p.experience_visible;

            db.SaveChanges();

            return RedirectToAction("ExperienceEdit", "Edit", new { id = p.member_id });
        }
        public PartialViewResult Header_Visibility_Projects_Data(int member_id)
        {
            var singular_data = db.TBL_SINGULAR_INFO.FirstOrDefault(x => x.member_id == member_id);

            return PartialView("Header_Visibility_Projects_Data", singular_data);
        }
        public ActionResult Update_Header_Visibility_Projects_Data(TBL_SINGULAR_INFO p)
        {
            var singular_info = db.TBL_SINGULAR_INFO.Find(p.id);
            singular_info.projects_head = p.projects_head;
            singular_info.projects_visible = p.projects_visible;

            db.SaveChanges();

            return RedirectToAction("ProjectsEdit", "Edit", new { id = p.member_id });
        }
        public PartialViewResult Header_Visibility_Certification_Data(int member_id)
        {
            var singular_data = db.TBL_SINGULAR_INFO.FirstOrDefault(x => x.member_id == member_id);

            return PartialView("Header_Visibility_Certification_Data", singular_data);
        }
        public ActionResult Update_Header_Visibility_Certification_Data(TBL_SINGULAR_INFO p)
        {
            var singular_info = db.TBL_SINGULAR_INFO.Find(p.id);
            singular_info.certification_head = p.certification_head;
            singular_info.certification_visible = p.certification_visible;

            db.SaveChanges();

            return RedirectToAction("CertificateEdit", "Edit", new { id = p.member_id });
        }
        public PartialViewResult Header_Visibility_Ability_Data(int member_id)
        {
            var singular_data = db.TBL_SINGULAR_INFO.FirstOrDefault(x => x.member_id == member_id);

            return PartialView("Header_Visibility_Ability_Data", singular_data);
        }
        public ActionResult Update_Header_Visibility_Ability_Data(TBL_SINGULAR_INFO p)
        {
            var singular_info = db.TBL_SINGULAR_INFO.Find(p.id);
            singular_info.areas_of_exp_head = p.areas_of_exp_head;
            singular_info.areas_of_expertise_visible = p.areas_of_expertise_visible;

            db.SaveChanges();

            return RedirectToAction("AbilityEdit", "Edit", new { id = p.member_id });
        }
        public PartialViewResult Header_Visibility_Reference_Data(int member_id)
        {
            var singular_data = db.TBL_SINGULAR_INFO.FirstOrDefault(x => x.member_id == member_id);

            return PartialView("Header_Visibility_Reference_Data", singular_data);
        }
        public ActionResult Update_Header_Visibility_Reference_Data(TBL_SINGULAR_INFO p)
        {
            var singular_info = db.TBL_SINGULAR_INFO.Find(p.id);
            singular_info.reference_head = p.reference_head;
            singular_info.reference_visible = p.reference_visible;

            db.SaveChanges();

            return RedirectToAction("ReferenceEdit", "Edit", new { id = p.member_id });
        }



        //Fotoğraf Ekle-Güncelle
        [HttpGet]
        public PartialViewResult Update_Profile_Photo(int member_id)
        {
            var singular_data = db.TBL_SINGULAR_INFO.FirstOrDefault(x => x.member_id == member_id);

            return PartialView("Update_Profile_Photo", singular_data);
        }
        [HttpPost]
        public PartialViewResult Update_Profile_Photo(TBL_SINGULAR_INFO p, HttpPostedFileBase profile_photo)
        {
            Random r = new Random();
            int random = r.Next();

            var singular_info = db.TBL_SINGULAR_INFO.Find(p.id);

            string imageFileName = Path.GetFileName(profile_photo.FileName);
            string filePath;
            filePath = Path.Combine(Server.MapPath("~/img/profile_photos/"), DateTime.Now.ToString("dd_MM_yyyy") + "__" + DateTime.Now.ToString("HH_mm") + "__" + p.member_id + imageFileName);
            profile_photo.SaveAs(filePath);
            filePath = "/img/profile_photos/" + DateTime.Now.ToString("dd_MM_yyyy") + "__" + DateTime.Now.ToString("HH_mm") + "__" + imageFileName;

            

            if (!ModelState.IsValid && imageFileName.Equals("-1"))
            {
                ViewBag.Mesaj = "Profil fotoğrafınız güncellenirken bir sorun oluştu. Yeniden deneyiniz.";
            }
            else
            {
                ViewBag.Mesaj = "Profil fotoğrafınız güncellendi.";
                
                singular_info.profile_photo = filePath;
                db.SaveChanges();
            }


            return PartialView("Update_Profile_Photo", singular_info);
        }

    }
}