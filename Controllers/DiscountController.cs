using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class DiscountController : Controller
    {
        private INorthwindRepository repository;
        public DiscountController(INorthwindRepository repo) => repository = repo;

        public IActionResult Index(int id) => View(repository.Discounts.FirstOrDefault(d => d.DiscountID == id));
        public IActionResult Discounts() => View(repository.Discounts.OrderBy(d => d.DiscountID));
        //public IActionResult Index(int id) => View(repository.Products.Where(p => p.CategoryId == id && p.Discontinued == false).OrderBy(p => p.ProductName));
    }
}