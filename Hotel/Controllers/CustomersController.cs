using Hotel.EF;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomersController(ApplicationDbContext context)
        {
            _context = context;       
        }
        public IActionResult List()
        {

            return View("CumList",_context.customers);
        }
        public IActionResult OrderPage() 
        {
            ViewBag.OrderListData = _context.orderLists.ToList();


            return View();
        }
        public IActionResult Save(Customer customer) 
        {
            if(customer.Id == 0)
            {
            _context.customers.Add(customer);   

            }
            else
            {
               var id = customer.Id;
                var customerInDb = _context.customers.Find(id);
                TryUpdateModelAsync(customerInDb);
            }
            
            _context.SaveChanges();
            return RedirectToAction("List","Customers");

        }
        public IActionResult Edit(int id) 
        {
            ViewBag.OrderListData = _context.orderLists.ToList();

            var customInDb =  _context.customers.Find(id);
            return View("OrderPage",customInDb);
        }
         public IActionResult Delete(int id) 
        {
            var customerInDb = _context.customers.SingleOrDefault(x => x.Id == id);
            _context.customers.Remove(customerInDb);
            _context.SaveChangesAsync();
            return RedirectToAction("List","Customers");
        }
    }
}
