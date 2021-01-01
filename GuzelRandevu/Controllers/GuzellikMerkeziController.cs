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
