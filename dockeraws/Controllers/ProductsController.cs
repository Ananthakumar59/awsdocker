using dockeraws.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dockeraws.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<Product> products = new List<Product>();

        public ProductsController()
        {



            products.Add(new Product { Id = 1, ProductName = "Panasonic Tv", Price = 30000, ShopName = "Vasanth & Co" });
            products.Add(new Product { Id = 2, ProductName = "Panasonic AC", Price = 40000, ShopName = "Panansonc Ac Show Room" });
            products.Add(new Product { Id = 3, ProductName = "Panasonic LED Tv", Price = 50000, ShopName = "Vasanth & Co" });
            products.Add(new Product { Id = 4, ProductName = "LG Washing Machine", Price = 30000, ShopName = "Vasanth & Co" });
            products.Add(new Product { Id = 5, ProductName = "WhirlPool Refrigerator", Price = 30000, ShopName = "Vasanth & Co" });



        }


        [HttpGet(Name = "GetProducts")]
        public ActionResult Index()
        {


            return Ok(products);
        }
        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            Product product = products.FirstOrDefault(x => x.Id == id);

            return Ok(product);

        }

    }
}
