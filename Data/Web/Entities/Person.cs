using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IDE.Data.Web.Entities
{
    public class Person
    {
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
    }
}