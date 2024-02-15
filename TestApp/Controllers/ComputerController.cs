using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestApp.Data;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class ComputerController : Controller
    {
        //-------------------------------------------
        private readonly TestAppContext _context;

        public ComputerController(TestAppContext context)
        {
            _context = context;
        }

        //----------------------------------------------

        public IActionResult Index()
        {
            return View();
        }


        //----------------------------------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,pq_uid,pq_time,pq_document")] Print_queque print_queque)
        {

            print_queque.pq_time = DateTime.Now;
           
         
            if (ModelState.IsValid)
            {
                _context.Add(print_queque);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(print_queque);
        }
        //--------------------------------------------------


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
