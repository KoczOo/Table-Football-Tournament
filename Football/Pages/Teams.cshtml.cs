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
        private readonly Teams timy;

        public TeamsModel()
        {
            timy = new Teams();
            Teams = timy.RandomizedTeams;
        }

        public List<string> Teams { get; private set; }

    }
}