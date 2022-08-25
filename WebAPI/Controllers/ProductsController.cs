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

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            //dependency chain -- bağımlılık zinciri var burada
            //Swagger dokümantasyon sağlayıcı


            var result = _productService.GetAll();
            if (result.Success == true)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);

        }

        [HttpGet("GetByID")]

        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]

        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
