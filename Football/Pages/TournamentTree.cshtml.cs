using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Football.Pages
{
    public class TournamentTreeModel : PageModel
    {
        private readonly AppDbContext _db;

        public TournamentTreeModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public DbSet<Player> Players { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }
    }
}