using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Bakery.Data;
using Bakery.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MimeKit;

namespace Bakery.Pages;

public class CheckoutModel : PageModel
{
    private readonly BakeryContext context;
    public CheckoutModel(BakeryContext context)
    {
        this.context = context;
    }
    public Basket Basket { get; set; } = new();
    public List<Product> SelectedProducts { get; set; } = new ();
[BindProperty, Required, Display(Name ="Your Email Address")]
public string OrderEmail {get;set;}
[BindProperty, Required, Display(Name ="Shipping Address")]
public string ShippingAddress { get; set; }
[TempData]
public string Confirmation { get; set; }
    public async Task OnGetAsync()
    {
        if(Request.Cookies[nameof(Basket)] is not null)
        {
            Basket = JsonSerializer.Deserialize<Basket>(Request.Cookies[nameof(Basket)]);
            if(Basket.NumberOfItems > 0)
            {
                var selectedProducts = Basket.Items.Select(b=> b.ProductId).ToArray();
                SelectedProducts = await context.Products.Where(p => selectedProducts.Contains(p.Id)).ToListAsync();
            }
        }
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if(ModelState.IsValid && Request.Cookies[nameof(Basket)] is not null){
            var basket = JsonSerializer.Deserialize<Basket>(Request.Cookies[nameof(Basket)]);
            if(basket is not null)
            {
                var plural = basket.NumberOfItems == 1 ? string.Empty : "s";
                Confirmation = $@"<p>Your order for {basket.NumberOfItems} item{plural} has been recieved and is being processed:</p>
                <p>It will be sent to {ShippingAddress}. We will notify you when it has been despatched</p>";    
                var message = new MimeMessage();    
                message.From.Add(MailboxAddress.Parse("test@test.com"));    
                message.To.Add(MailboxAddress.Parse(OrderEmail));    
                message.Subject = "Your order confirmation";    

                message.Body = new TextPart("html")    
                {    
                    Text = Confirmation
                };    
                using var client = new SmtpClient ();
                await client.ConnectAsync("localhost");
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
                Response.Cookies.Append(nameof(Basket), string.Empty, new CookieOptions{Expires = DateTime.Now.AddDays(-1)});
                return RedirectToPage("/OrderSuccess");
            }
        }
        return Page();
    }
}

