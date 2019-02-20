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
    public class PlayersModel : PageModel
    {
        private readonly AppDbContext _db;

        public PlayersModel(AppDbContext db)
        {
            _db = db;
        }

        public IList<Player> Players { get; private set; }

        public async Task OnGetAsync()
        {
            Players = await _db.Players.AsNoTracking().ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var player = await _db.Players.FindAsync(id);

            if (player != null)
            {
                _db.Players.Remove(player);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
    