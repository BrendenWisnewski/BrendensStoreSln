using Microsoft.AspNetCore.Mvc;
using Products.Models;


namespace Products.Components
{
    public class CartSummaryViewComponent :ViewComponent
    {

        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }

    }
}
