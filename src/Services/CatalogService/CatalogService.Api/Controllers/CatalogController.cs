using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase
    {
        private static readonly string[] Categories = new[]
        {
            "Shoes", "Top", "Binco", "Legs"
        };

        private readonly ILogger<CatalogController> _logger;

        public CatalogController(ILogger<CatalogController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Catalog> Get()
        {
            return Enumerable.Range(1, 4).Select(index => new Catalog
            {
                Name = Categories[Random.Shared.Next(Categories.Length)],
                ProductCount = Random.Shared.Next(0, 1000),
            })
            .ToArray();
        }
    }
}