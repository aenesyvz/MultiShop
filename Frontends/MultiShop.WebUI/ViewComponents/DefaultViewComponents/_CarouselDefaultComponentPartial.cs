using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Services.CategoryService;
using MultiShop.Catalog.Services.FeatureSliderServices;
using MultiShop.Catalog.Services.ProductService;

namespace MultiShop.WebUI.ViewComponents.DefaultViewComponents;
public class _CarouselDefaultComponentPartial : ViewComponent
{
    private readonly IFeatureSliderService _featureSliderService;
    public _CarouselDefaultComponentPartial(IFeatureSliderService featureSliderService)
    {
        _featureSliderService = featureSliderService;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var values = await _featureSliderService.GetAllFeatureSliderAsync();
        return View(values);
    }
}
