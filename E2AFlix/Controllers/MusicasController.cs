using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E2AFlix.Infra.Data.Context;
using E2AFlix.Models;

namespace E2AFlix.Controllers
{
    public class MusicasController : Controller
    {
        private readonly Context _context;

        public MusicasController(Context context)
        {
            _context = context;
        }

        // GET: Musicas
        public async Task<IActionResult> Index()
        {
              return View(await _context.Musica.ToListAsync());
        }

        // GET: Musicas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Musica == null)
            {
                return NotFound();
            }

            var musicas = await _context.Musica
                .FirstOrDefaultAsync(m => m.Id == id);
            if (musicas == null)
            {
                return NotFound();
            }

            return View(musicas);
        }

        // GET: Musicas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Musicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Artista,Nota,FotoMusica")] Musicas musicas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(musicas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(musicas);
        }

        // GET: Musicas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Musica == null)
            {
                return NotFound();
            }

            var musicas = await _context.Musica.FindAsync(id);
            if (musicas == null)
            {
                return NotFound();
            }
            return View(musicas);
        }

        // POST: Musicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Artista,Nota,FotoMusica")] Musicas musicas)
        {
            if (id != musicas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(musicas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusicasExists(musicas.Id))
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
            return View(musicas);
        }

        // GET: Musicas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Musica == null)
            {
                return NotFound();
            }

            var musicas = await _context.Musica
                .FirstOrDefaultAsync(m => m.Id == id);
            if (musicas == null)
            {
                return NotFound();
            }

            return View(musicas);
        }

        // POST: Musicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Musica == null)
            {
                return Problem("Entity set 'Context.Musica'  is null.");
            }
            var musicas = await _context.Musica.FindAsync(id);
            if (musicas != null)
            {
                _context.Musica.Remove(musicas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MusicasExists(int id)
        {
          return _context.Musica.Any(e => e.Id == id);
        }
    }
}
