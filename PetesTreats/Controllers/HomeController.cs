using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PetesTreats.Models;
using System.Collections.Generic;
using System.Linq;

namespace PetesTreats.Controllers
{
    public class HomeController : Controller
    {
      public readonly PetesTreatsContext _db;
      public HomeController(PetesTreatsContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpGet("/Both")]
      public ActionResult Both()
      {
        ViewBag.Flavors = _db.Flavors.ToList();
        ViewBag.Treats = _db.Treats.ToList();
        return View();
    }
  }
}