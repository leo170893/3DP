using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _3DP.Areas.Admin.Models.BusinessModels;

namespace _3DP.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private DBContextCommon db = new DBContextCommon();
        // GET: Admin/Product
        public ActionResult Index()
        {
            return View("ProductList", db.DSProduct.ToList());
        }
    }
}