using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CerezoJose_Progreso1.Data;
using CerezoJose_Progreso1.Models;

namespace CerezoJose_Progreso1.Controllers
{
    public class JoseCerezosController : Controller
    {
        private readonly CerezoJose_Progreso1Context _context;

        public JoseCerezosController(CerezoJose_Progreso1Context context)
        {
            _context = context;
        }

        // GET: JoseCerezos
        public async Task<IActionResult> Index()
        {
            var cerezoJose_Progreso1Context = _context.JoseCerezo.Include(j => j.Telefono);
            return View(await cerezoJose_Progreso1Context.ToListAsync());
        }

        // GET: JoseCerezos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joseCerezo = await _context.JoseCerezo
                .Include(j => j.Telefono)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (joseCerezo == null)
            {
                return NotFound();
            }

            return View(joseCerezo);
        }

        // GET: JoseCerezos/Create
        public IActionResult Create()
        {
            ViewData["TelefonoId"] = new SelectList(_context.Telefono, "Id", "Modelo");
            return View();
        }

        // POST: JoseCerezos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,CantidadHermanos,SaldoBancario,EsHombre,FechaNacimiento,TelefonoId")] JoseCerezo joseCerezo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(joseCerezo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TelefonoId"] = new SelectList(_context.Telefono, "Id", "Modelo", joseCerezo.TelefonoId);
            return View(joseCerezo);
        }

        // GET: JoseCerezos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joseCerezo = await _context.JoseCerezo.FindAsync(id);
            if (joseCerezo == null)
            {
                return NotFound();
            }
            ViewData["TelefonoId"] = new SelectList(_context.Telefono, "Id", "Modelo", joseCerezo.TelefonoId);
            return View(joseCerezo);
        }

        // POST: JoseCerezos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,CantidadHermanos,SaldoBancario,EsHombre,FechaNacimiento,TelefonoId")] JoseCerezo joseCerezo)
        {
            if (id != joseCerezo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(joseCerezo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JoseCerezoExists(joseCerezo.Id))
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
            ViewData["TelefonoId"] = new SelectList(_context.Telefono, "Id", "Modelo", joseCerezo.TelefonoId);
            return View(joseCerezo);
        }

        // GET: JoseCerezos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joseCerezo = await _context.JoseCerezo
                .Include(j => j.Telefono)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (joseCerezo == null)
            {
                return NotFound();
            }

            return View(joseCerezo);
        }

        // POST: JoseCerezos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var joseCerezo = await _context.JoseCerezo.FindAsync(id);
            if (joseCerezo != null)
            {
                _context.JoseCerezo.Remove(joseCerezo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JoseCerezoExists(int id)
        {
            return _context.JoseCerezo.Any(e => e.Id == id);
        }
    }
}
