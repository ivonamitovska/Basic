using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Basic.Models
{
    public class Genre
    {
        [Key]
        public int IDGenre { get; set; }
        public string NameGenre { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

    }

}