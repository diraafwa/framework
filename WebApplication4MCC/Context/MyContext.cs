using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication4MCC.Models;

namespace WebApplication4MCC.Context
{
    public class MyContext : DbContext
    {
      public MyContext(DbContextOptions<MyContext> dbContext) : base (dbContext)
        {

        }

        //mengatur connection string (done)
        //memasukkan model yang digunakan untuk melakukan crud / migrasi

        public DbSet<Department> Departments { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Region> Regions { get; set; }


    }
}
