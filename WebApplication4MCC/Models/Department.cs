using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4MCC.Models
{
    public class Department
    {
        //primary key id
        [Key]
        public int Id { get; set; }
        public string Nama { get; set; }
        public Division Division { get; set; }
        [ForeignKey("Division")]
        public int DivisionId { get; set; }

    }
}
