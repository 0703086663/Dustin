using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Dustin.Models
{
    public class Brand
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Desc { get; set; }
    }

    public class BrandDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
    }
}