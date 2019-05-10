using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Api_Rest.Models
{
    public class Customer
    {
        [Key]
        public int Id_C { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public int IdT { get; set; }

        public virtual TypeCustomer TypeCustomer { get; set; }
    }

}