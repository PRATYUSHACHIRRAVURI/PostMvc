using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PosttController : Controller
    {
        // GET: Postt
        private EmployeeEntities db = new EmployeeEntities();
        public ActionResult Index()
        {
            return View(db.emp_table.ToList());
        }

        // GET: Postt/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Postt/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Postt/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                emp_table e = new emp_table();
             
                e.empName = collection["empName"];
                e.empAddress = collection["empAddress"];
                e.empPhoneNo = collection["empPhoneNo"];
                EmployeeEntities userRegistrationEntities = new EmployeeEntities();
                userRegistrationEntities.emp_table.Add(e);
                userRegistrationEntities.SaveChanges();
                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: Postt/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Postt/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Postt/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Postt/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
