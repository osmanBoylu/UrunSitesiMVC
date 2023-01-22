using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UrunSitesiMVC.Models;

namespace UrunSitesiMVC.Controllers
{
    public class OrderController : Controller
    {
        List<Order> Siparisler = new List<Order>()
        {
            new Order { ID = 1, CustomerID = 1, TotalPrice = 177, CustomerName = "Osman" },
            new Order { ID = 2, CustomerID = 2, TotalPrice = 250, CustomerName = "Betül"},
            new Order { ID = 3, CustomerID = 3, TotalPrice = 400, CustomerName = "Kadir"}
        };

        // GET: OrderController
        public ActionResult Index()
        {
            return View(Siparisler);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
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

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
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

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
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
