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

        private readonly AppDbContext _db;

        [BindProperty]
        public Player Player { get; set; }


        public IndexModel(AppDbContext db)
        {
            _db = db;

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Players.Add(Player);
            await _db.SaveChangesAsync();
            return RedirectToPage("/index");
        }

    }

}
