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
    public class RallyController : Controller
    {
        private readonly RallyContexto _context;

        public RallyController(RallyContexto context)
        {
            _context = context;
        }

        // GET: Rally
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rally.ToListAsync());
        }

        // GET: Rally/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rally = await _context.Rally
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rally == null)
            {
                return NotFound();
            }

            return View(rally);
        }

        // GET: Rally/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rally/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,cld_nome_curto_rally,cld_nome_completo_rally,cld_pais_rally,cld_cidade_rally,cld_data_inicio_rally")] Rally rally)
        {
            rally.cld_data_insercao = DateTime.Now;
            rally.cld_data_atualizacao = DateTime.Now;
            if (ModelState.IsValid)
            {
                _context.Add(rally);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rally);
        }

        // GET: Rally/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rally = await _context.Rally.FindAsync(id);
            if (rally == null)
            {
                return NotFound();
            }
            return View(rally);
        }

        // POST: Rally/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,cld_nome_curto_rally,cld_nome_completo_rally,cld_pais_rally,cld_cidade_rally,cld_data_inicio_rally")] Rally rally)
        {
            rally.cld_data_atualizacao = DateTime.Now;

            if (id != rally.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rally);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RallyExists(rally.Id))
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
            return View(rally);
        }

        // GET: Rally/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rally = await _context.Rally
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rally == null)
            {
                return NotFound();
            }

            return View(rally);
        }

        // POST: Rally/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rally = await _context.Rally.FindAsync(id);
            _context.Rally.Remove(rally);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RallyExists(int id)
        {
            return _context.Rally.Any(e => e.Id == id);
        }
    }
}
