using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Annu.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace pro.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext dbContext;
        public IHostingEnvironment Environment { get; }
        public ProductController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            dbContext = context;
            Environment = environment;
        }
        public IActionResult Index()
        {
            var prod = dbContext.Products.ToList();
            return View(prod);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product pro)
        {

            var files = Request.Form.Files;
            string dbpath = string.Empty;
            if (files.Count > 0)
            {
                string path = Environment.WebRootPath;
                string fullpath = Path.Combine(path, "images", files[0].FileName);
                dbpath = "images/" + files[0].FileName;
                FileStream stream = new FileStream(fullpath, FileMode.Create);
                files[0].CopyTo(stream);
            }
            pro.Image = dbpath;
            dbContext.Products.Add(pro);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {
            var prod = dbContext.Products.SingleOrDefault(x => x.Id == Id);
            dbContext.Products.RemoveRange();
            dbContext.SaveChanges();
            var res = dbContext.Products.ToList();
            return View(res);
        }
        public IActionResult ProductDetails()
        {
            return View();
        }
    }
}