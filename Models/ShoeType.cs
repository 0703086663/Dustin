using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Dustin.Models
{
    public class ShoeType
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }


    public class ShoeTypeDbContext : DbContext
    {
        public DbSet<ShoeType> ShoeTypes { get; set; }
    }
}