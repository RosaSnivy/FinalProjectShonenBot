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

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string CurrentSearch {get; set;} = string.Empty;

        public async Task OnGetAsync()
        {
            var query = _context.Characters.Include(c => c.Anime).Select(c => c);
            if (!string.IsNullOrEmpty(CurrentSearch))
            {
                query = query.Where(s => s.CharacterName.ToUpper().Contains(CurrentSearch.ToUpper()) || s.CharacterName.ToUpper().Contains(CurrentSearch.ToUpper()));
            }

            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(c => c.CharacterName);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(c => c.CharacterName);
                    break;
                case "HP_asc":
                    query = query.OrderBy(c => c.HP);
                break;
                case "HP_desc":
                    query = query.OrderByDescending(c => c.HP);
                break;
                case "Strength_asc":
                    query = query.OrderBy(c => c.Strength);
                break;
                case "Strength_desc":
                    query = query.OrderByDescending(c => c.Strength);
                break;
                case "Durability_asc":
                    query = query.OrderBy(c => c.Durability);
                break;
                case "Durability_desc":
                    query = query.OrderByDescending(c => c.Durability);
                break;
                case "Anime_asc":
                    query = query.OrderBy(c => c.Anime.AnimeName);
                break;
                case "Anime_desc":
                    query = query.OrderByDescending(c => c.Anime.AnimeName);
                break;
            }

            TotalPages = (int)Math.Ceiling(_context.Characters.Count()/(double)PageSize);

            Character = await query.Skip((PageNum - 1) * PageSize).Take(PageSize).ToListAsync();
        }
    }
}
