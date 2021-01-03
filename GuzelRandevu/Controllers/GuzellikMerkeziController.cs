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

namespace GuzelRandevu.Controllers
{
    public class GuzellikMerkeziController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<GuzellikMerkeziController> _logger;
        public GuzellikMerkeziController(ApplicationDbContext context,ILogger<GuzellikMerkeziController> logger)
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
        // GET: GuzellikMerkezi
        public async Task<IActionResult> Index()
        {
            return View(await _context.GuzellikMerkezi.ToListAsync());
        }

        // GET: GuzellikMerkezi/Details/5
        public async Task<IActionResult> Details(string id)
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
    }
}
