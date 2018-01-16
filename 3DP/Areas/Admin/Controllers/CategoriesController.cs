using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _3DP.Areas.Admin.Models.BusinessModels;
using _3DP.Areas.Admin.Models.Entities;

namespace _3DP.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        private DBContextCommon db = new DBContextCommon();

        // GET: Admin/Categories
        public ActionResult Index()
        {
            return View("ListCategory", db.DSCategory.ToList());
        }

        // GET: Admin/Categories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.DSCategory.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CatID,CatCode,CatName,ParentCatCode")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.DSCategory.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);

        }

        // GET: Admin/Categories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("DetailCategory", new Category());
            }
            Category category = db.DSCategory.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            category.State = (int)EntityState.Modified;
            return View("DetailCategory", category);
        }
        /// <summary>
        /// Hàm cất chung khi thêm/sửa
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save([Bind(Include = "CatID,CatCode,CatName,ParentCatCode,State")] Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.State != (int)EntityState.Modified)
                {
                    db.DSCategory.Add(category);
                }
                else
                {
                    category.ModifyDate = DateTime.Now;
                    db.Entry(category).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        //// GET: Admin/Categories/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Category category = db.DSCategory.Find(id);
        //    if (category == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(category);
        //}

        // POST: Admin/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Category category = db.DSCategory.Find(id);
            db.DSCategory.Remove(category);
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
