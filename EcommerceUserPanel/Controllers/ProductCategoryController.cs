﻿

//using System.Linq;
//using System.Threading.Tasks;
//using EcommerceUserPanel.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace EcommerceUserPanel.Controllers
//{
//    public class ProductCategoryController : Controller
//    {

//        //ShoppingDemoooo2Context context = new ShoppingDemoooo2Context();
//        private readonly ShoppingDemoooo2Context _context;

//        public ProductCategoryController(ShoppingDemoooo2Context context)
//        {
//            _context = context;
//        }
//        public IActionResult Index()
//        {

//            var productcat = _context.Categories.ToList();
//            return View(productcat);
//        }

//        public async Task<IActionResult> ProDisplay(int? id)
//        {
//            var p = _context.Products.Where(x => x.ProductCategoryId == id);
//            return View(p);
//        }
//        [HttpGet]
//        public async Task<IActionResult> Display(int? id)
//        {
//            if (id == null)
//            {
//                return BadRequest();
//            }
//            var categories = await _context.Categories.FindAsync(id);

//            if (categories == null)
//            {
//                return NotFound();
//            }

//            return Ok(categories);


//        }
//    }
//}
