using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Pages.Components.Basket;

public class BasketViewComponent: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        Models.Basket basket = new();
        if(Request.Cookies[nameof(Basket)] is not null)
        {
            basket = JsonSerializer.Deserialize<Models.Basket?>(Request.Cookies[nameof(Basket)]!);
        }
        return View(basket);
    }
}
