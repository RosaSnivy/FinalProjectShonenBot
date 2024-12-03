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
    public class DetailsModel : PageModel
    {
        private readonly final.Models.AppDbContext _context;

        public DetailsModel(final.Models.AppDbContext context)
        {
            _context = context;
        }

        public Character Character { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters.FirstOrDefaultAsync(m => m.CharacterID == id);

            if (character is not null)
            {
                Character = character;

                return Page();
            }

            return NotFound();
        }
    }
}
