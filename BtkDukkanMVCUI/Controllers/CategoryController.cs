using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace BTKDukkanMVCUI.Controllers
{
    public class CategoryController : Controller
    {
        private ProductManager pm = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var liste = pm.GetAll();
            return View(liste);
        }
    }
}
