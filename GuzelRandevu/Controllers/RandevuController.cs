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
    public class RandevuController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RandevuController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Randevu
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Randevu.Include(r => r.guzellikMerkezi).Include(r => r.uye);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Randevu/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevu
                .Include(r => r.guzellikMerkezi)
                .Include(r => r.uye)
                .FirstOrDefaultAsync(m => m.merkezId == id);
            if (randevu == null)
            {
                return NotFound();
            }

            return View(randevu);
        }

        // GET: Randevu/Create
        public IActionResult Create()
        {
            ViewData["merkezId"] = new SelectList(_context.GuzellikMerkezi, "merkezId", "merkezId");
            ViewData["uyeId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Randevu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("uyeId,merkezId,randevuDegerlendirmesi,randevuPuani,randevuSaati,randevuTuru")] Randevu randevu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(randevu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["merkezId"] = new SelectList(_context.GuzellikMerkezi, "merkezId", "merkezId", randevu.merkezId);
            ViewData["uyeId"] = new SelectList(_context.Users, "Id", "Id", randevu.uyeId);
            return View(randevu);
        }

        // GET: Randevu/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevu.FindAsync(id);
            if (randevu == null)
            {
                return NotFound();
            }
            ViewData["merkezId"] = new SelectList(_context.GuzellikMerkezi, "merkezId", "merkezId", randevu.merkezId);
            ViewData["uyeId"] = new SelectList(_context.Users, "Id", "Id", randevu.uyeId);
            return View(randevu);
        }

        // POST: Randevu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("uyeId,merkezId,randevuDegerlendirmesi,randevuPuani,randevuSaati,randevuTuru")] Randevu randevu)
        {
            if (id != randevu.merkezId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(randevu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RandevuExists(randevu.merkezId))
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
            ViewData["merkezId"] = new SelectList(_context.GuzellikMerkezi, "merkezId", "merkezId", randevu.merkezId);
            ViewData["uyeId"] = new SelectList(_context.Users, "Id", "Id", randevu.uyeId);
            return View(randevu);
        }

        // GET: Randevu/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevu
                .Include(r => r.guzellikMerkezi)
                .Include(r => r.uye)
                .FirstOrDefaultAsync(m => m.merkezId == id);
            if (randevu == null)
            {
                return NotFound();
            }

            return View(randevu);
        }

        // POST: Randevu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var randevu = await _context.Randevu.FindAsync(id);
            _context.Randevu.Remove(randevu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RandevuExists(string id)
        {
            return _context.Randevu.Any(e => e.merkezId == id);
        }
    }
}
