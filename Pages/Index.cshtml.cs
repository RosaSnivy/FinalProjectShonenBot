using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using final.Models;

namespace FinalProjectShonenBot.Pages;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public IList<Anime> Anime { get;set; } = default!;

    public async Task OnGetAsync()
    {
        Anime = await _context.Animes
        .Include(p => p.Characters)
        .ToListAsync();
    }
}
