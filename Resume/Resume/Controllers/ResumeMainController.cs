using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Resume.Models;

namespace Resume.Controllers
{
    public class ResumeMainController : Controller
    {
        private readonly ResumeContext _context;

        public ResumeMainController(ResumeContext context)
        {
            _context = context;    
        }

        // GET: ResumeMain
        public async Task<IActionResult> Index()
        {
            return View(await _context.ResumeMain.ToListAsync());
        }

        // GET: ResumeMain/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeMain = await _context.ResumeMain
                .SingleOrDefaultAsync(m => m.ID == id);
            if (resumeMain == null)
            {
                return NotFound();
            }

            return View(resumeMain);
        }

        // GET: ResumeMain/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ResumeMain/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ResName,Descr,ResDate,MyName,Email,Phone,Objective,Summary")] ResumeMain resumeMain)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resumeMain);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(resumeMain);
        }

        // GET: ResumeMain/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeMain = await _context.ResumeMain.SingleOrDefaultAsync(m => m.ID == id);
            if (resumeMain == null)
            {
                return NotFound();
            }
            return View(resumeMain);
        }

        // POST: ResumeMain/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ResName,Descr,ResDate,MyName,Email,Phone,Objective,Summary")] ResumeMain resumeMain)
        {
            if (id != resumeMain.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resumeMain);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResumeMainExists(resumeMain.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(resumeMain);
        }

        // GET: ResumeMain/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeMain = await _context.ResumeMain
                .SingleOrDefaultAsync(m => m.ID == id);
            if (resumeMain == null)
            {
                return NotFound();
            }

            return View(resumeMain);
        }

        // POST: ResumeMain/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resumeMain = await _context.ResumeMain.SingleOrDefaultAsync(m => m.ID == id);
            _context.ResumeMain.Remove(resumeMain);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ResumeMainExists(int id)
        {
            return _context.ResumeMain.Any(e => e.ID == id);
        }
    }
}
