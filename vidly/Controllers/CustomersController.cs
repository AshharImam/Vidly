using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;
using System.Data.Entity;


namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        //[Route("customers")]
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {

            var customers = _context.Customers.Include(c =>c.MembershipType).ToList(); 

            return View(customers);
        }
        public ActionResult Details(int Id)
        {
            var customer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == Id);
            if (customer==null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
            
        }

        //private IEnumerable<Customer> GetCustomer()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer{Id=1,Name="John Smith"},
        //        new Customer{Id=2,Name="Alan Walker"}
        //    };
        //}
    }
}