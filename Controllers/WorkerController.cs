using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Asp.netCoreMVCCRUD.Models;

namespace Asp.netCoreMVCCRUD.Controllers
{
    public class WorkerController : Controller
    {
        private readonly MyWorkerContext _context;

        public WorkerController(MyWorkerContext context)
        {
            _context = context;
        }

        // GET: Worker
        public async Task<IActionResult> Index()
        {
            return View(await _context.MyWorkers.ToListAsync());
        }



        // GET: Worker/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Worker());
            else;
            return View(_context.MyWorkers.Find(id));

        }

        // POST: Worker/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("WorkerId,FullName,EmpCode,Position,OfficeLocation")] Worker worker)
        {
            if (ModelState.IsValid)
            {
                if (worker.WorkerId == 0)

                    _context.Add(worker);

                else

                    _context.Update(worker);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(worker);
        }



        // GET: Worker/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var worker =await _context.MyWorkers.FindAsync(id);
            _context.MyWorkers.Remove(worker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
