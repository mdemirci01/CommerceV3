using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommerceV3.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CommerceV3.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext db;
        public UsersController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var users = db.Users.ToList();
            return View(users);
        }
    }
}