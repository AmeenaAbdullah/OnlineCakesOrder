using Microsoft.AspNetCore.Mvc;

namespace CakesOrder.Components
{
    public class ProductsViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
