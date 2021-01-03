using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GuzelRandevu.Data;
using GuzelRandevu.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace GuzelRandevu.Controllers
{ [Authorize(Roles ="Admin")]
    public class AdminPaneliController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<AdminPaneliController> _logger;
        public AdminPaneliController(ApplicationDbContext context,ILogger<AdminPaneliController> logger)
        {
            _logger = logger;
            _context = context;
        }
        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(1) }
            );

            return LocalRedirect(returnUrl);
        }
        // GET: AdminPaneli
        public async Task<IActionResult> RandevuIndex()
        {
            var applicationDbContext = _context.Randevu.Include(r => r.guzellikMerkezi).Include(r => r.uye);
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: Randevu/Details/5
        public async Task<IActionResult> RandevuDetails(string merkezId, string uyeId)
        {
            if (merkezId == null && uyeId == null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevu
                .Include(r => r.guzellikMerkezi)
                .Include(r => r.uye)
                .FirstOrDefaultAsync(m => m.merkezId == merkezId && m.uyeId == uyeId);
            if (randevu == null)
            {
                return NotFound();
            }

            return View(randevu);
        }

        // GET: Randevu/Create
        public IActionResult RandevuCreate()
        {
            ViewData["merkezId"] = new SelectList(_context.GuzellikMerkezi, "merkezId", "merkezId");
            ViewData["uyeId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["merkezAdi"] = new SelectList(_context.GuzellikMerkezi, "merkezAdi", "merkezAdi");
            ViewData["uyeAdi"] = new SelectList(_context.Users, "uyeAdi", "uyeAdi");
            //ViewBag.tur = Enum.GetValues(typeof(Randevu.randevuTipi)).Cast<Randevu.randevuTipi>();
            return View();
        }

        // POST: Randevu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RandevuCreate([Bind("uyeId,merkezId,randevuDegerlendirmesi,randevuPuani,randevuSaati,randevuTuru")] Randevu randevu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(randevu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(RandevuIndex));
            }
            ViewData["merkezId"] = new SelectList(_context.GuzellikMerkezi, "merkezId", "merkezId", randevu.merkezId);
            ViewData["uyeId"] = new SelectList(_context.Users, "Id", "Id", randevu.uyeId);
            return View();
        }

        // GET: Randevu/Edit/5
        public async Task<IActionResult> RandevuEdit(string merkezId, string uyeId)
        {
            if (merkezId == null && uyeId == null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevu.FindAsync(merkezId, uyeId);
            if (randevu == null)
            {
                return NotFound();
            }
            ViewData["merkezId"] = new SelectList(_context.GuzellikMerkezi, "merkezId", "merkezId", randevu.merkezId);
            ViewData["uyeId"] = new SelectList(_context.Users, "Id", "Id", randevu.uyeId);
            return View();
        }

        // POST: Randevu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RandevuEdit(string merkezId, string uyeId, [Bind("uyeId,merkezId,randevuDegerlendirmesi,randevuPuani,randevuSaati,randevuTuru")] Randevu randevu)
        {
            if (merkezId != randevu.merkezId && uyeId != randevu.uyeId)
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
                    if (!RandevuExists(randevu.merkezId, randevu.uyeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(RandevuIndex));
            }
            ViewData["merkezId"] = new SelectList(_context.GuzellikMerkezi, "merkezId", "merkezId", randevu.merkezId);
            ViewData["uyeId"] = new SelectList(_context.Users, "Id", "Id", randevu.uyeId);
            return View(randevu);
        }

        // GET: Randevu/Delete/5
        public async Task<IActionResult> RandevuDelete(string merkezId, string uyeId)
        {
            if (merkezId == null && uyeId == null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevu
                .Include(r => r.guzellikMerkezi)
                .Include(r => r.uye)
                .FirstOrDefaultAsync(m => m.merkezId == merkezId && m.uyeId == uyeId);
            if (randevu == null)
            {
                return NotFound();
            }

            return View(randevu);
        }

        // POST: Randevu/Delete/5
        [HttpPost, ActionName("RandevuDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RandevuDeleteConfirmed(string merkezId,string uyeId)
        {
            var randevu = await _context.Randevu.FindAsync(merkezId,uyeId);
            _context.Randevu.Remove(randevu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(RandevuIndex));
        }

       private bool RandevuExists(string merkezId, string uyeId)
        {
            return _context.Randevu.Any(e => e.merkezId == merkezId && e.uyeId==uyeId);
        }
    public async Task<IActionResult> MerkezIndex()
        {
            return View(await _context.GuzellikMerkezi.ToListAsync());
        }
        public async Task<IActionResult> MerkezDetails(string id)
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
        public IActionResult MerkezCreate()
        {
            return View();
        }

        // POST: GuzellikMerkezi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MerkezCreate([Bind("merkezId,merkezAdi,merkezAdresi,merkezEmail,merkezResim")] GuzellikMerkezi guzellikMerkezi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guzellikMerkezi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MerkezIndex));
            }
            return View(guzellikMerkezi);
        }

        // GET: GuzellikMerkezi/Edit/5
        public async Task<IActionResult> MerkezEdit(string id)
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
        public async Task<IActionResult> MerkezEdit(string id, [Bind("merkezId,merkezAdi,merkezAdresi,merkezEmail,merkezResim")] GuzellikMerkezi guzellikMerkezi)
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
                return RedirectToAction(nameof(MerkezIndex));
            }
            return View(guzellikMerkezi);
        }

        // GET: GuzellikMerkezi/Delete/5
        public async Task<IActionResult> MerkezDelete(string id)
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
        [HttpPost, ActionName("MerkezDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MerkezDeleteConfirmed(string id)
        {
            var guzellikMerkezi = await _context.GuzellikMerkezi.FindAsync(id);
            _context.GuzellikMerkezi.Remove(guzellikMerkezi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MerkezIndex));
        }

        private bool GuzellikMerkeziExists(string id)
        {
            return _context.GuzellikMerkezi.Any(e => e.merkezId == id);
        }
    }
}
