using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Basic.Models
{
    public enum PeopleType
    {
        Director,
        Actor,
        Producer
    }
    public class People
    {
        [Key]
        public int IDPeople { get; set; }
        public string PeopleName { get; set; }
        public PeopleType PeopleType { get; set; }


        public virtual ICollection<Movie> Movies { get; set; }
    }

}