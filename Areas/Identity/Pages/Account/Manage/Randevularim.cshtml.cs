using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GuzelRandevu.Data;
using GuzelRandevu.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GuzelRandevu.Areas.Identity.Pages.Account.Manage
{
    public class RandevularimModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Musteri> _userManager;
        public RandevularimModel(ApplicationDbContext context, UserManager<Musteri> userManager)
        {
            _userManager = userManager;
            _context = context;
        }
        List<Randevu> randevular { get; set;}
        
        
        public void OnGet()
        {
        }
    }
}
