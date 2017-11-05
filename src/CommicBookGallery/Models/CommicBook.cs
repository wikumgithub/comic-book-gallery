using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommicBookGallery.Models
{
    public class CommicBook
    {
        public int Id { get; set; }        
        public string SeriesTitle{ get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public  Artist[] artists{ get; set; }
        public bool Favourite { get; set; }     



    }
}