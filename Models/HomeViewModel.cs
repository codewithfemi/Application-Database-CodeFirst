using System.Collections.Generic;
using IDE.Data.Web.Entities;

namespace IDE.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            People = new List<Person>();
        }

        public List<Person> People {get; set;}
        public string Title { get; set; }
        public string Description { get; set; }
    }
}