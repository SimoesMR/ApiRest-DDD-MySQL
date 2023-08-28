using API.DDD.Application.Dtos;
using API.DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace RestApi.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductApplicationService _productServiceApplication;

        public ProductController(IProductApplicationService productServiceApplication)
        {
            _productServiceApplication = productServiceApplication;
        }

        [HttpGet]
        [Route("[controller]/GetAll")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_productServiceApplication.GetAll());
        }

        [HttpGet]
        [Route("[controller]/GetById/Id")]
        public ActionResult<string> Get(Guid id)
        {
            return Ok(_productServiceApplication.GetById(id));
        }

        [HttpPost]
        [Route("[controller]/Insert")]
        public ActionResult Post([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();


                _productServiceApplication.Add(productDto);
                return Ok("The product has been successfully registered");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut]
        [Route("[controller]/Update")]
        public ActionResult Put([FromBody] ProductDto productDto)
        {

            try
            {
                if (productDto == null)
                    return NotFound();

                _productServiceApplication.Update(productDto);
                return Ok("The product has been updated successfully!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete()]
        [Route("[controller]/Delete")]
        public ActionResult Delete([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _productServiceApplication.Remove(productDto);
                return Ok("The product has been removed successfully!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
