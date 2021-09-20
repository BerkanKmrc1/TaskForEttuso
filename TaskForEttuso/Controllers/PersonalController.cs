using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskForEttuso.Models;


namespace TaskForEttuso.Controllers
{
    public class PersonalController : Controller
    {
        private readonly IPersonalService _personalService = null;

        public PersonalController(IPersonalService personalService)
        {
            _personalService = personalService;
        }
        // GET: PersonalList
        public ActionResult Add()
        {

            return View();
        }
        //[HttpPost]
        //public ActionResult Add()
        //{

        //    return View();
        //}
        public ActionResult List()
        {
            var result= context.Set<Personal>().ToList();
            return View(result);
        }
    }
}