﻿using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Services.SpecialOfferServices;

namespace MultiShop.WebUI.ViewComponents.DefaultViewComponents;

public class _SpeacialOfferComponentPartial : ViewComponent
{
    private readonly ISpecialOfferService _specialOfferService;
    public _SpeacialOfferComponentPartial(ISpecialOfferService specialOfferService)
    {
        _specialOfferService = specialOfferService;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
       // var values = await _specialOfferService.GetAllSpecialOfferAsync();
        return View(1);
    }
}
