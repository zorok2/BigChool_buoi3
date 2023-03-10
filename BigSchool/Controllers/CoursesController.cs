using BigSchool.Models;
using BigSchool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        private readonly ApplicationDbContext dbContext;
        public CoursesController()
        {
            dbContext = new ApplicationDbContext();
        }

        public ActionResult Create()
        {


            var viewModel = new CourseViewModel { Categories = dbContext.Categories.ToList() };

            return View(viewModel);

        }
    }
}