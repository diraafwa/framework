using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WebApplication4MCC.Context;

namespace WebApplication4MCC.Models
{//harus ada CRUD
    public class DepartmentController : Controller
    {
        MyContext myContext;

        public DepartmentController(MyContext myContext)
        {
            this.myContext = myContext;

        }
        //READ
        public IActionResult Index()
        {
            var data = myContext.Departments.Include(x => x.Division).ToList();
            return View(data);
        }


        //CREATE
        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                myContext.Departments.Add(department);
                myContext.SaveChanges();
            }
            return View();
        }

        //EDIT
        //GET
        public IActionResult Edit(int Id)
        {
            var dep = myContext.Departments.Find(Id);
            return View(dep);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Department department)
        {
            var data = myContext.Departments.Find(department.Id);
            if (data != null)
            {
                data.Nama = department.Nama;
                data.DivisionId = department.DivisionId;
            }
            myContext.SaveChanges();
            return View();
        }

        //DELETE
        //GET
        public IActionResult Delete(int Id)
        {
            var dep = myContext.Departments.Find(Id);
            return View(dep);
        }
        
    }

}
