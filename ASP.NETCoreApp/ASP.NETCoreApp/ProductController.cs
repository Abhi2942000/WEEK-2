using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreApp
{
    [Route("Product")]
    public class ProductController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            // Return all products
            return Ok("All products");
        }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            // Return product with the specified ID
            return Ok($"Product with ID {id}");
        }
        [HttpGet("{id}/reviews")]
        public IActionResult GetProductReviews(int id)
        {
            // Return reviews for the product with the specified ID
            return Ok($"Reviews for product with ID {id}");
        }
    }
}

