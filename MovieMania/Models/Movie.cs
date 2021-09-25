using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieMania.Models
{
    public class Movie
    {
        public Movie()
        {
            this.Users = new HashSet<User>();
        }

        public int MovieId { get; set; }
        public Genre Genre { get; set; }
        public string MovieTitle { get; set; }
        public int DurationHours { get; set; }
        public int DurationMin { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public string Cover { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}