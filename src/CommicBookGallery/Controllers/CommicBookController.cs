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
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Content("Hello,This is a commic book") ;
            }
            else
            {

                return new RedirectResult("/");
            }
                          
        }
    }
}