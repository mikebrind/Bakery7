using Bakery.Data;
using Bakery.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Pages;

public class IndexModel : PageModel
{
    private readonly BakeryContext context;
    public IndexModel(BakeryContext context) => 
        this.context = context;
    public List<Product> Products { get; set; } = new ();
    public async Task OnGetAsync() =>
        Products = await context.Products.ToListAsync();
}
