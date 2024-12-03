using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using final.Models;

namespace FinalProjectShonenBot.Pages_Characters
{
    public class IndexModel : PageModel
    {
        private readonly final.Models.AppDbContext _context;

        public IndexModel(final.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Character = await _context.Characters.ToListAsync();
        }
    }
}
