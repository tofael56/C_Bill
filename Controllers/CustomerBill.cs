using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C_Bill.Controllers
{
    public class CustomerBill : Controller
    {
        // GET: CustomerBill
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerBill/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerBill/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerBill/Create
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

        // GET: CustomerBill/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerBill/Edit/5
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

        // GET: CustomerBill/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerBill/Delete/5
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
