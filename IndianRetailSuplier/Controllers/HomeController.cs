using IndianRetailSuplier.Common.AutoMapper;
using IndianRetailSuplier.CustomeFilter;
using IndianRetailSuplier.DATA.Models;
using IndianRetailSuplier.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IndianRetailSuplier.Controllers
{
    //[BaseAuthorizeAttribute]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DataContext _context;
        
        public HomeController(ILogger<HomeController> logger,DataContext context)
        {
            _logger = logger;
            _context = context;
        }
      
        public IActionResult Index()
        {
           _logger.LogInformation("First something nitin jihnuyhui");
            var viewmodell = new List<ProductViewModel>();
            viewmodell = (from Product in _context.products
                         join productDetails in _context.productDetails
                         on Product.Id equals productDetails.Product.Id
                         join productImages in _context.ProductImages
                         on Product.Id equals productImages.Product.Id
                         select(new ProductViewModel { 
                         productDetails = productDetails,
                         productImages = productImages,
                         Product = Product
                         })).ToList();
                          

            return View(viewmodell);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
    }
}
