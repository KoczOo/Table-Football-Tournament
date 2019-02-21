using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Football.Model
{
    public partial class Players
    {
        public int Id { get; set; }
        [Required, MaxLength(10)]
        public string PlayerName { get; set; }
    }
}
