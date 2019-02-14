using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using my_first_web_app.Models;

namespace my_first_web_app.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id); //lambda expression: to traverse the list of customers

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

    }
}