using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Statdrop.Data;
using Statdrop.Models;

namespace Statdrop.Controllers
{
    public class SolutionsController : Controller
    {
        private readonly StatdropContext _context;

        public SolutionsController(StatdropContext context)
        {
            _context = context;
        }

        // GET: Solutions
        public async Task<IActionResult> Demo()
        {
            return View(await _context.Solutions.ToListAsync());
        }

        // GET: Solutions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solutions = await _context.Solutions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solutions == null)
            {
                return NotFound();
            }

            return View(solutions);
        }

        // GET: Solutions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Solutions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,DatePlayed,Team,TeamScore,Rival,RivalScore")] Solutions solutions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solutions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(solutions);
        }

        // GET: Solutions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solutions = await _context.Solutions.FindAsync(id);
            if (solutions == null)
            {
                return NotFound();
            }
            return View(solutions);
        }

        // POST: Solutions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,DatePlayed,Team,TeamScore,Rival,RivalScore")] Solutions solutions)
        {
            if (id != solutions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solutions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolutionsExists(solutions.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(solutions);
        }

        // GET: Solutions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solutions = await _context.Solutions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solutions == null)
            {
                return NotFound();
            }

            return View(solutions);
        }

        // POST: Solutions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solutions = await _context.Solutions.FindAsync(id);
            _context.Solutions.Remove(solutions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolutionsExists(int id)
        {
            return _context.Solutions.Any(e => e.Id == id);
        }
    }
}
