﻿using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Business.Abstract;



namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        //Loosely coupled(gevşk bağımlılık)
        //naming convention(fieldları .net projelerinde isilendirme şekli  _productService gibi)
        //IoC Container -- Inversion of Control
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Dependency chain--
           var result = _productService.GetAll();
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result );
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result );
        }


        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result );
        }

    }
}
