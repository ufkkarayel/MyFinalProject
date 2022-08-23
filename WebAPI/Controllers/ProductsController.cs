using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //burası Attribute 
    // Attirbute bir classla ilgili bilgi verme yöntemi.
    public class ProductsController : ControllerBase
    {
        // gevşek bağlılık - loosely coupled

        IProductService _productService;
        //IoC Container (Inversion of Control)

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            //dependency chain -- bağımlılık zinciri var burada

            
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
