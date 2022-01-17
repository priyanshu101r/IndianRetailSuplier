using IndianRetailSuplier.Common.AutoMapper;
using IndianRetailSuplier.DATA.Models;
using IndianRetailSuplier.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianRetailSuplier.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DataContext _Context;
        public CategoryController(DataContext context )
        {
            _Context = context;
        }
        public IActionResult category()
       {
            List<CategoryViewModel> categoryviewmodel = new List<CategoryViewModel>();
            List<Category> category = new List<Category>();

            category = _Context.categories.ToList();
            categoryviewmodel = category.MapTo<CategoryViewModel>();
            return PartialView("_CategoryPartial", categoryviewmodel);
        }
    }
}
