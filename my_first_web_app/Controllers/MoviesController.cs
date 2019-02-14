using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using my_first_web_app.Models;
using my_first_web_app.ViewModels;

namespace my_first_web_app.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        /*
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id=1,Name="Shrek"},
                new Movie { Id=2,Name="Wall-e"}
            };
        }
        */

        public ViewResult Index()
        {
            var movies = _context.Movies.ToList();

            return View(movies);
        }
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id); //lambda expression: to traverse the list of customers

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "The Raid Redemption!" };
            var customers = new List<Customer>
            {
                new Customer {Name= "customer 1"},
                new Customer {Name= "customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            /* Helper Method */
            return View(viewModel);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        /*
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        */
    }
}