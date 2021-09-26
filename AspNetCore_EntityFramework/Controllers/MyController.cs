using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_EntityFramework.Controllers
{
    public class MyController : Controller
    {
        CoreDBContext dBContext;
        public MyController(CoreDBContext _dbContext)
        {
            dBContext = _dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Category model)
        {
            dBContext.Category.Add(model);
            dBContext.SaveChanges(); // değişikliği veritana yansıt...

            return View();
        }
    }
}