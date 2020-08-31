using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi3.Models;

namespace WebApi3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<Product> products = new List<Product>()
        {
            new Product
            {
                Id = 1006368,
                Name = "Austin and Barbeque AABQ WiFi Food Thermometer",
                Description = "Thermometer med WiFi för en optimal innertemperatur",
                Price = 399
            },
            new Product
            {
                Id = 1009334,
                Name = "Anderson Elektrisk Tändare ECL 1.1",
                Description = "Elektrisk stormsäker tändare helt utan gas och bränsle",
                Price = 89
            },
            new Product
            {
                Id = 1002266,
                Name = "Weber Non-Stick Spray",
                Price = 99
            }
        };

        [HttpGet] // Get All Products
        public IEnumerable<Product> Get()
        {
            return products;
        }

        [HttpGet("{id}")] //Get a specific Product
        public Product Get(int id)
        {
            var product = products.Find(product => product.Id == id);
            return product;
        }
    }
}
