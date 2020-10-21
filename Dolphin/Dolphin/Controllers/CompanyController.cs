using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dolphin.Models;
using Dolphin.DataContext;


namespace Dolphin.Controllers
{
    public class CompanyController : Controller
    {
        ApplicationDbContext _context;
        public CompanyController ()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Company
        public ActionResult Index()
        {
            return View(_context.Companies.ToList());
        }
    }
}