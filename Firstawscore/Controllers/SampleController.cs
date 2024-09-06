using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Firstawscore.Model;

namespace Firstawscore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {



          public SampleController() { }

   [HttpGet(Name = "GetProducts")]
   public ActionResult Index()
   { 
   
   List<Product> products = new List<Product>();
       products.Add(new Product { id = 1, name = "Videocon", description = "FlatTv", price = 30000, quantity = 10 });
       products.Add(new Product { id = 2, name = "Panasonic", description = "A/C", price = 40000, quantity = 10 });
       products.Add(new Product { id = 3, name = "LG", description = "A/C", price = 40000, quantity = 10 });
       products.Add(new Product { id = 4, name = "Whirlpool", description = "Refrigerator", price = 30000, quantity = 10 });
       products.Add(new Product { id = 5, name = "Panasonic", description = "LED TV", price = 40000, quantity = 10 });
       products.Add(new Product { id = 6, name = "Sony Bravia", description = "FlatTv", price = 35000, quantity = 10 });



       return Ok(products);
   }
    }
}
