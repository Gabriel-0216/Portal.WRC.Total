using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portal.WRC.Total.com.Data;
using Portal.WRC.Total.com.Models;

namespace Portal.WRC.Total.com.Controllers
{
    public class PilotosController : Controller
    {
        private readonly PilotosContexto _context;

        public PilotosController(PilotosContexto context)
        {
            _context = context;
        }

        // GET: Pilotos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Piloto.ToListAsync());
        }

        // GET: Pilotos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var piloto = await _context.Piloto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (piloto == null)
            {
                return NotFound();
            }

            return View(piloto);
        }

        // GET: Pilotos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pilotos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,plt_nome_curto,plt_nome_completo,plt_data_nascimento,plt_data_insercao,plt_data_atualizacao,plt_pais_nascimento")] Piloto piloto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(piloto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(piloto);
        }

        // GET: Pilotos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var piloto = await _context.Piloto.FindAsync(id);
            if (piloto == null)
            {
                return NotFound();
            }
            return View(piloto);
        }

        // POST: Pilotos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,plt_nome_curto,plt_nome_completo,plt_data_nascimento,plt_data_insercao,plt_data_atualizacao,plt_pais_nascimento")] Piloto piloto)
        {
            if (id != piloto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(piloto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PilotoExists(piloto.Id))
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
            return View(piloto);
        }

        // GET: Pilotos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var piloto = await _context.Piloto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (piloto == null)
            {
                return NotFound();
            }

            return View(piloto);
        }

        // POST: Pilotos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var piloto = await _context.Piloto.FindAsync(id);
            _context.Piloto.Remove(piloto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PilotoExists(int id)
        {
            return _context.Piloto.Any(e => e.Id == id);
        }
    }
}
