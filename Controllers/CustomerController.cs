using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UrunSitesiMVC.Models;

namespace UrunSitesiMVC.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> Musteriler = new List<Customer>()
        {
            new Customer { ID=1, FirstName = "Osman", LastName = "Boylu", Email = "oboy@gmail.com"},
            new Customer { ID=2, FirstName = "Betül", LastName = "Boylu", Email = "bboy@gmail.com"},
            new Customer { ID=3, FirstName = "Kadir", LastName = "Boylu", Email = "kboy@gmail.com"}
        };


        // GET: CustomerController
        public ActionResult Index()
        {
            return View(Musteriler);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
