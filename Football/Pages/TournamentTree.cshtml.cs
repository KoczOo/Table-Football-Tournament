using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Football.Pages
{
    public class TournamentTreeModel : PageModel
    {

        private readonly Teams timy;

        public TournamentTreeModel()
        {
            timy = new Teams();
            Teams = JsonConvert.SerializeObject(timy.RandomizedTeams);
        }

        public string Teams { get; private set; }

    }
}