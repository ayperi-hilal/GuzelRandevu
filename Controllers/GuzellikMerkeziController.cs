using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GuzelRandevu.Data;
using GuzelRandevu.Models;

namespace GuzelRandevu.Controllers
{
    public class GuzellikMerkeziController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GuzellikMerkeziController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GuzellikMerkezi
        public async Task<IActionResult> Index()
        {
            return View(await _context.GuzellikMerkezi.ToListAsync());
        }

        // GET: GuzellikMerkezi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guzellikMerkezi = await _context.GuzellikMerkezi
                .FirstOrDefaultAsync(m => m.merkezId == id);
            if (guzellikMerkezi == null)
            {
                return NotFound();
            }

            return View(guzellikMerkezi);
        }

        // GET: GuzellikMerkezi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GuzellikMerkezi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("merkezId,merkezAdi,merkezEmail,merkezAdres,merkezTelNo,merkezResimUrl")] GuzellikMerkezi guzellikMerkezi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guzellikMerkezi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(guzellikMerkezi);
        }

        // GET: GuzellikMerkezi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guzellikMerkezi = await _context.GuzellikMerkezi.FindAsync(id);
            if (guzellikMerkezi == null)
            {
                return NotFound();
            }
            return View(guzellikMerkezi);
        }

        // POST: GuzellikMerkezi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("merkezId,merkezAdi,merkezEmail,merkezAdres,merkezTelNo,merkezResimUrl")] GuzellikMerkezi guzellikMerkezi)
        {
            if (id != guzellikMerkezi.merkezId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guzellikMerkezi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuzellikMerkeziExists(guzellikMerkezi.merkezId))
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
            return View(guzellikMerkezi);
        }

        // GET: GuzellikMerkezi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guzellikMerkezi = await _context.GuzellikMerkezi
                .FirstOrDefaultAsync(m => m.merkezId == id);
            if (guzellikMerkezi == null)
            {
                return NotFound();
            }

            return View(guzellikMerkezi);
        }

        // POST: GuzellikMerkezi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var guzellikMerkezi = await _context.GuzellikMerkezi.FindAsync(id);
            _context.GuzellikMerkezi.Remove(guzellikMerkezi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuzellikMerkeziExists(int id)
        {
            return _context.GuzellikMerkezi.Any(e => e.merkezId == id);
        }
    }
}
