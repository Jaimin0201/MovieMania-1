using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace MovieMania.Models
{
    public class Serie
    {
        public int SerieId { get; set; }
        public string SerieTitle { get; set; }
        public string SerieDescription { get; set; }
        public Genre Genre { get; set; }

        [DisplayName("Upload File")]
        public string Cover { get; set; }//Image Path

        //public HttpPostedFileBase ImageFile { get; set; }//ImageFile
        public int SeasonsNumber { get; set; }

    }
}