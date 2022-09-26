using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4MCC.Models
{
    public class Region
    {
        //primary key id
        [Key]
        public int Id { get; set; }
        public string Nama { get; set; }

        //foreignkey
        public Division Division { get; set; }
        [ForeignKey("Division")] // foreign key merepresentasikan  ke table gaji
        public int DivisionId { get; set; }
    }
}
