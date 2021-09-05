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
    public class EquipesController : Controller
    {
        private readonly EquipesContexto _context;

        public EquipesController(EquipesContexto context)
        {
            _context = context;
        }

        // GET: Equipes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Equipes.ToListAsync());
        }

        // GET: Equipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipes = await _context.Equipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipes == null)
            {
                return NotFound();
            }

            return View(equipes);
        }

        // GET: Equipes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Equipes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,eqp_nome_curto,eqp_nome_completo,eqp_url_site,eqp_url_email,eqp_nome_chefe_equipe,eqp_pais_origem,eqp_data_insercao,eqp_data_atualizacao")] Equipes equipes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equipes);
        }

        // GET: Equipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipes = await _context.Equipes.FindAsync(id);
            if (equipes == null)
            {
                return NotFound();
            }
            return View(equipes);
        }

        // POST: Equipes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,eqp_nome_curto,eqp_nome_completo,eqp_url_site,eqp_url_email,eqp_nome_chefe_equipe,eqp_pais_origem,eqp_data_insercao,eqp_data_atualizacao")] Equipes equipes)
        {
            if (id != equipes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipesExists(equipes.Id))
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
            return View(equipes);
        }

        // GET: Equipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipes = await _context.Equipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipes == null)
            {
                return NotFound();
            }

            return View(equipes);
        }

        // POST: Equipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipes = await _context.Equipes.FindAsync(id);
            _context.Equipes.Remove(equipes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipesExists(int id)
        {
            return _context.Equipes.Any(e => e.Id == id);
        }
    }
}
