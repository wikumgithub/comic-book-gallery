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
        private CommicBookRepository _repository;

        

        public CommicBookController()
        {
            _repository = new CommicBookRepository();

        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            else
            {
              var  _comicbook= _repository.GetCommicBook(id.Value);
              return View(_comicbook);
            }


        }
    }
}