﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelContentController : Controller
    {
        // GET: WriterPanelContent
        Context c = new Context();

        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult MyContent(string p)
        {
            p = (string)Session["WriterMail"];  // session değerini bir değişkene atadık
            var writeridinfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();  //sisteme kim giriş yapıyorsa onun bilgisini getiriyor.
            var contentvalues = cm.GetListByWriter(writeridinfo);
            return View(contentvalues);
        }

        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.d = id;
            return View();
        }

        [HttpPost]
        public ActionResult AddContent(Content p)
        {
            string mail = (string)Session["WriterMail"];  // session değerini bir değişkene atadık
            var writeridinfo = c.Writers.Where(x => x.WriterMail == mail).Select(y => y.WriterID).FirstOrDefault();
            p.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterID = writeridinfo;
            p.ContentStatus = true;
            cm.ContentAdd(p);
            return View("MyContent");
        }
        public ActionResult ToDoList() {

            return View();
        }
    }
}