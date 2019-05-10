using Api_Rest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Api_Rest.Context
{
    public class Db_Context : DbContext
    {
        public DbSet<Customer> customers { get; set; }
    }
}