using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using aam_bonmark_product.Domain;
using aam_bonmark_product.Application.Services;
using System.Collections.Generic;

namespace aam_bonmark_api.Controllers.Market
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ProductController> _logger;
        private readonly GetProductsService _getProductsService;

        public ProductController(ILogger<ProductController> logger, GetProductsService getProductsService)
        {
            _logger = logger;
            _getProductsService = getProductsService;
        }

        [HttpGet]
        public List<Product> Get() => _getProductsService.GetAll();
    }
}
