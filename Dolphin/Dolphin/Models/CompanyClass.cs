using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Dolphin.Models
{
    [Table("Companies", Schema = "public")]
    public class CompanyClass
    {
        
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public int Telnumber { get; set; }
        public string Country { get; set; }
        public string Adres { get; set; }
        public string Taxrecord { get; set; }

    }
}