using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Basic.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        public string NameMovie { get; set; }

        public string ImgUrl { get; set; }
        public float Rating { get; set; }

        public virtual ICollection<People> People { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
    }

}