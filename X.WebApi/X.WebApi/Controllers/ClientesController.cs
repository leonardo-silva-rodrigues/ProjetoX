using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using X.Core.Domain;

namespace X.WebApi.Controllers
{
    public class ClientesController : Controller
    {
        // GET: ClientesController
        [Route("api/[controller]")]
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new List<Cliente>()
            {
                new Cliente 
                { 
                    Id = 1,
                    Nome = "Leonardo",
                    DataNascimento = new DateTime(1990,01,01)                    
                },
                 new Cliente
                {
                    Id = 2,
                    Nome = "Maria",
                    DataNascimento = new DateTime(1980,01,01)
                }
            });
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientesController/Create
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

        // GET: ClientesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientesController/Edit/5
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

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientesController/Delete/5
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
