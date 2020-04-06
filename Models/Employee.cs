using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Employee
    {

        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar(16)")]
        public string Salary { get; set; }
        [Required]
        [Column(TypeName = "varchar(5)")]
        public string Dept { get; set; }
        [Required]
        [Column(TypeName = "varchar(3)")]
        public string Type { get; set; }
        [Required]
        [Column(TypeName = "varchar(3)")]
        public string Status { get; set; }
        [Required]
        [Column(TypeName = "varchar(3)")]
        public string Company { get; set; }
        [Required]
        [Column(TypeName = "varchar(3)")]
        public string Limit { get; set; }
    }
}
