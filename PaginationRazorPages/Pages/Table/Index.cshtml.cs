using Lib.Context;
using Lib.Entity;
using Lib.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PaginationRazorPages.Pages.Table;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;
    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public PaginatedList<Exemplo>? Exemplo { get; set; }
    public async Task OnGet([FromQuery]int pageIndex = 1, [FromQuery]int pageSize = 10)
    {
        Exemplo = await _context.Exemplo.ToPaginatedListAsync(pageIndex, pageSize);
    }
}
