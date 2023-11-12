using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tasks_Points.Models;

namespace Tasks_Points.Controllers
{
    [Authorize]
    public class RecompensasController : Controller
    {
        private readonly AppDbContext _context;

        public RecompensasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Recompensas
        public async Task<IActionResult> Index()
        {
              return View(await _context.Recompensas.ToListAsync());
        }

        // GET: Recompensas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Recompensas == null)
            {
                return NotFound();
            }

            var recompensa = await _context.Recompensas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recompensa == null)
            {
                return NotFound();
            }

            return View(recompensa);
        }

        [Authorize(Roles = "Admin")]
        // GET: Recompensas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recompensas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("Id,Name,Descricao,Valor")] Recompensa recompensa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recompensa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recompensa);
        }

        [Authorize(Roles = "Admin")]
        // GET: Recompensas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Recompensas == null)
            {
                return NotFound();
            }

            var recompensa = await _context.Recompensas.FindAsync(id);
            if (recompensa == null)
            {
                return NotFound();
            }
            return View(recompensa);
        }

        // POST: Recompensas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Descricao,Valor")] Recompensa recompensa)
        {
            if (id != recompensa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recompensa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecompensaExists(recompensa.Id))
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
            return View(recompensa);
        }

        [Authorize(Roles = "Admin")]
        // GET: Recompensas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Recompensas == null)
            {
                return NotFound();
            }

            var recompensa = await _context.Recompensas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recompensa == null)
            {
                return NotFound();
            }

            return View(recompensa);
        }

        // POST: Recompensas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Recompensas == null)
            {
                return Problem("Entity set 'AppDbContext.Recompensas'  is null.");
            }
            var recompensa = await _context.Recompensas.FindAsync(id);
            if (recompensa != null)
            {
                _context.Recompensas.Remove(recompensa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecompensaExists(int id)
        {
          return _context.Recompensas.Any(e => e.Id == id);
        }
    }
}
