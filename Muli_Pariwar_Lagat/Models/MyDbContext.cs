using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Muli_Pariwar_Lagat.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext() : base("connString")
        {
        }
        public DbSet<Muli> Mulis { get; set; }
    }
}