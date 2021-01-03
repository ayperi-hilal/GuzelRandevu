using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GuzelRandevu.Data;
using GuzelRandevu.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;

namespace GuzelRandevu.Controllers
{
    public class GuzellikMerkeziController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<GuzellikMerkeziController> _logger;
        private readonly IStringLocalizer<GuzellikMerkeziController> _localizer;
        public GuzellikMerkeziController(ApplicationDbContext context, ILogger<GuzellikMerkeziController> logger, IStringLocalizer<GuzellikMerkeziController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
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
        // GET: GuzellikMerkezi
        public async Task<IActionResult> Index()
        {
            ViewData["Title2"] = _localizer["Yeni Merkez Ekle"];
            ViewData["Title3"] = _localizer["Detaylar"];
            ViewData["Title4"] = _localizer["Güzellik Merkezleri"];
            return View(await _context.GuzellikMerkezi.ToListAsync());
        }

        // GET: GuzellikMerkezi/Details/5
        public async Task<IActionResult> Details(string id)
        {
            ViewData["Title"] = _localizer["Güzellik Merkezi Detayları"];
            ViewData["Title1"] = _localizer["Güzellik Merkezi Adı"];
            ViewData["Title2"] = _localizer["Adres"];
            ViewData["Title3"] = _localizer["Email adresi"];
            ViewData["Title4"] = _localizer["Güzellik Merkezi"];
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
    }
}
