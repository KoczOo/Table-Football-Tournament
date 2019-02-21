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
    public class IndexModel : PageModel
    {

        private readonly PlayersDBContext _db;

        [BindProperty]
        public Players Players { get; set; }


        public IndexModel(PlayersDBContext db)
        {
            _db = db;

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Players.Add(Players);
            await _db.SaveChangesAsync();
            return RedirectToPage("/players");
        }

    }

}
