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

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 7;
        public int TotalPages {get; set;}

        public async Task OnGetAsync()
        {
            TotalPages = (int)Math.Ceiling(_context.Characters.Count()/(double)PageSize);

            Character = await _context.Characters.Include(a => a.Anime)
                .Skip((PageNum - 1) * PageSize).Take(PageSize).ToListAsync();
        }
    }
}
