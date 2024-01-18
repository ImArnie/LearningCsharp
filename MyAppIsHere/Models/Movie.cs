using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAppIsHere.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Poster { get; set; }
        public string Description { get; set; }
        public string Trailer { get; set; }
        public string Comments { get; set; }
    }

}