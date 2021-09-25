using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieMania.Models
{
    public class Serie
    {
        public int SerieId { get; set; }
        public string SerieTitle { get; set; }
        public string SerieDescription { get; set; }
        public Genre Genre { get; set; }
        public string Cover { get; set; }
        public int SeasonsNumber { get; set; }

    }
}