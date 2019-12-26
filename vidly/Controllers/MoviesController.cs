using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;



namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies

        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult movies()
        {
            var movie = _context.Movies.Include(m=>m.Genre).ToList();
           
            return View(movie); 
        }
        public ActionResult Details(int Id)
        {
            var movieDetails = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == Id);
            return View(movieDetails);
        }

        //public ActionResult Random()
        //{
        //    var movie = new List<Movie>
        //    {
        //        new Movie { Name = "Shrek", Id = 1 },
        //        new Movie { Name = "Star Wars", Id = 2 }
        //    };
        //    var customers = new List<Customer>
        //    {
        //        new Customer{ Name="customer1"},
        //        new Customer{ Name="customer2"}
        //    };
        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };
        //    return View(viewModel);
        //}

        //public ActionResult edit(int id)
        //{
        //    return Content("id="+id);
        //}

        //public ActionResult Index(int? pageIndex,string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleasedDate(int year,int month)
        //{
        //    return Content("Year=" + year + " month=" + month);
        //}
    }
}