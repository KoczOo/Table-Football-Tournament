using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Football.Pages
{
    public class TeamsModel : PageModel
    {
        private readonly TeamsDbContext _db;

        public TeamsModel(TeamsDbContext db)
        {
            _db = db;
        }

        public Teams Teams { get; private set; }

        public async Task OnGetAsync()
        {
            Teams = await _db.Teams.MinAsync();
        }
    }
}