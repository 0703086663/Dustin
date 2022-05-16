using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dustin.Models
{
    public class Shoe
    {
        [Required]
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        
        public string Desc { get; set; }

        [Required]
        [DefaultValue(0)]
        public float Price { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public string Image { get; set; }

        public int Rate { get; set; }

        [Required]
        [DefaultValue(0)]
        public int Stock { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Created Date")]
        public DateTime Created { get; set; }
    }
}