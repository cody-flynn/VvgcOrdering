using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.NetworkInformation;
using VvgcOrdering.Models;

namespace VvgcOrdering.Pages
{
    public class MenuModel : PageModel
    {
        public List<MenuOrderModel> MenuOrders = new List<MenuOrderModel>()
        {
            new MenuOrderModel(){ItemName="Nachos", BasePrice=15, Description="Tortilla chips with seasoned chicken or ground beef topped with Monterey Jack, black olives," +
                " jalapenos, lime crema, guacamole, and fresh salsa"},
            new MenuOrderModel(){ItemName="Boneless Chicken Wings", BasePrice=15, Description="Breaded chicken wings served dry or tossed in Frank's Redhot Sauce. Served with carrots, celery, bleu cheese or ranch"},
            new MenuOrderModel(){ItemName="Deli Sandwich", BasePrice=8, Description="Your choice of bread, meat, and cheese. Includes\r\nlettuce, tomato, and mayo "},
            new MenuOrderModel(){ItemName="Bacon, Lettuce & Tomato", BasePrice=12.50F, Description="Crispy bacon layered with lettuce, tomatoes, and mayo on your choice of toast"},
            new MenuOrderModel(){ItemName="French Dip", BasePrice=13, Description="Tender, sliced roast beef on a toasted hoagie French roll, served with au jus and horsey sauce"},
            new MenuOrderModel(){ItemName="Hamburger", BasePrice=11.50F, Description="Grilled beef patty served on a toasted bun with lettuce, tomato, pickles, and red onion"}
        };
        public void OnGet()
        {
        }
    }
}
