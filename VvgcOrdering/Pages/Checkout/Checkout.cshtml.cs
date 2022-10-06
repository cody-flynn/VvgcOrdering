using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VvgcOrdering.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string ItemName { get; set; }
        public float Price { get; set; }
        public string ImageTitle { get; set; }
        public void OnGet()
        {
            
        }
    }
}
