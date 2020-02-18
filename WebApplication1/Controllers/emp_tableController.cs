using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class emp_tableController : Controller
    {
        private EmployeeEntities db = new EmployeeEntities();

        // GET: emp_table
        public ActionResult Index()
        {
            return View(db.emp_table.ToList());
        }

        // GET: emp_table/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            emp_table emp_table = db.emp_table.Find(id);
            if (emp_table == null)
            {
                return HttpNotFound();
            }
            return View(emp_table);
        }

        // GET: emp_table/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: emp_table/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "empID,empName,empAddress,empPhoneNo")] emp_table emp_table)
        {
            if (ModelState.IsValid)
            {
                db.emp_table.Add(emp_table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emp_table);
        }

        // GET: emp_table/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            emp_table emp_table = db.emp_table.Find(id);
            if (emp_table == null)
            {
                return HttpNotFound();
            }
            return View(emp_table);
        }

        // POST: emp_table/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "empID,empName,empAddress,empPhoneNo")] emp_table emp_table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emp_table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp_table);
        }

        // GET: emp_table/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            emp_table emp_table = db.emp_table.Find(id);
            if (emp_table == null)
            {
                return HttpNotFound();
            }
            return View(emp_table);
        }

        // POST: emp_table/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            emp_table emp_table = db.emp_table.Find(id);
            db.emp_table.Remove(emp_table);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
