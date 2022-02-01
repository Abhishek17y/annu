using Annu.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Annu.Controllers
{
    public class CategoryController : Controller
    {
            private ApplicationDbContext dbContext;
            public IHostingEnvironment Environment { get; }
            public CategoryController(ApplicationDbContext context, IHostingEnvironment environment)
            {
                dbContext = context;
                Environment = environment;
            }
            public IActionResult Index()
            {
                var categ = dbContext.Categories.ToList();
                return View(categ);
            }
            public IActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Create(Category Cat)
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
                Cat.Image = dbpath;
                dbContext.Categories.Add(Cat);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            public IActionResult CategoryDetail(int id)
            {
                var Categ = dbContext.Categories.SingleOrDefault(e => e.ID == id);
                return View(Categ);
            }
        }
    }
