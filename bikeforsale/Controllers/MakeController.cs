using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bikeforsale.Models;
using bikeforsale.AppDbContext;

namespace bikeforsale.Controllers
{
    public class MakeController : Controller
    {
        public readonly BikeForSaleDbContext _db;
        public MakeController( BikeForSaleDbContext db)
        {
            _db = db;
        }
       public IActionResult Index()
        {

            return View(_db.makes.ToList());

        }
    //HTTPGET
        public IActionResult Create()
        {

            return View();

        }
        [HttpPost]
        public IActionResult Create( Make make)
        {
            if (ModelState.IsValid)
            {
                _db.Add(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View(make);

        }
    }
}
