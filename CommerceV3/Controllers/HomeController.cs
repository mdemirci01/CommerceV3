﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommerceV3.Models;
using CommerceV3.Data;
using Microsoft.EntityFrameworkCore;

namespace CommerceV3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;
        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            ViewBag.Slides = db.Slides.Where(s=>s.IsPublished == true).OrderBy(o=>o.Position).Take(10).ToList();
            ViewBag.Products = (from p in db.Products.Include(i=>i.Category) where p.IsPublished == true orderby p.CreateDate descending select p).Take(8).ToList(); // Query-based LINQ to Entities
                                                                                                                // db.Products.Include(i=>i.Category).Where(p => p.IsPublished == true).OrderByDescending(o => o.CreateDate).Take(8).ToList(); // Method-based LINQ to Entities
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
