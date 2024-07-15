﻿using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Services.ProductDetailServices;

namespace MultiShop.WebUI.ViewComponents.ProductDetailViewComponents;

public class ProductDetailDescriptionComponentPartial : ViewComponent
{
    private readonly IProductDetailService _productDetailService;
    public ProductDetailDescriptionComponentPartial(IProductDetailService productDetailService)
    {
        _productDetailService = productDetailService;
    }
    public async Task<IViewComponentResult> InvokeAsync(string id)
    {
        var values = await _productDetailService.GetByProductIdProductDetailAsync(id);
        return View(values);
    }
}
