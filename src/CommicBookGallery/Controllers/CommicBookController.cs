using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CommicBookGallery.Controllers
{
    public class CommicBookController:Controller
    {
        public ActionResult Details()
        {
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            //{
            //    return Content("Hello,This is a commic book") ;
            //}
            //else
            //{

            //    return new RedirectResult("/");
            //}


             ViewBag.Message = "Hi BUDDY... Get Your Commic Book Today";
             ViewBag.SeriesTitle = "The Amazing Spider-Man";
             ViewBag.IssueNumber = 700;
             ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
             ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View();
        }
    }
}