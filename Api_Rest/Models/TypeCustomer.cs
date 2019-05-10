using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Api_Rest.Models
{
    public class TypeCustomer
    {
        [Key]
        public int IdT { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TypeCustomer> TypeCustomers { get; set; }
    }
}