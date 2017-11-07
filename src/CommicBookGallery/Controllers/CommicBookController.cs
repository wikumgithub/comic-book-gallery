using CommicBookGallery.Data;
using CommicBookGallery.Models;
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
            CommicBookRepository repository = new CommicBookRepository();
            repository.GetCommicBook(1);

            return null;
        }
    }
}