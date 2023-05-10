using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using will_stock_backend.Models;

namespace MeuProjeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        // GET api/produtos
        //[HttpGet]
        //public IEnumerable<ProductModel> Get()
        //{
        //    return new List<ProductModel>
        //    {
        //        new ProductModel { Id = 1, Nome = "Produto 1", Preco = 10.99 },
        //        new ProductModel { Id = 2, Nome = "Produto 2", Preco = 5.99 },
        //        new ProductModel { Id = 3, Nome = "Produto 3", Preco = 7.99 },
        //    };
        //}

        public IActionResult Index()
        {
            List<ProductModel> products = new List<ProductModel>();
            products.Add(new ProductModel { Id = 1, Nome = "Produto 1", Preco = 10.99 });
            products.Add(new ProductModel { Id = 2, Nome = "Produto 2", Preco = 5.99 });
            products.Add(new ProductModel { Id = 3, Nome = "Produto 3", Preco = 7.99 });

            return View(products);
        }

        // Outros endpoints da API, como POST, PUT, DELETE, podem ser adicionados aqui.
    }
}
