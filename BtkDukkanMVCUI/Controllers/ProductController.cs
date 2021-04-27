using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace BtkDukkanMVCUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        ProductManager pm = new ProductManager(new EfProductDal());
        public ActionResult Index()
        {
            var listele = pm.GetAll().Data;
            return View(listele);
        }
    }
}