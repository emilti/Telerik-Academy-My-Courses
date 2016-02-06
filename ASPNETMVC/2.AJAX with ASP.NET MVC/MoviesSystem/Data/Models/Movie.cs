using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesSystem.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public int Year { get; set; }

        public string LeadingMaleRole { get; set; }

        public int LeadingMaleRoleAge { get; set; }      

        public string LeadingFemaleRole { get; set; }

        public int LeadingFemaleRoleAge { get; set; }

        public string Studio { get; set; }

        public string StudioAddress { get; set; }

    }
}