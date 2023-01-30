using API.DDD.Application.Dtos;
using API.DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace RestApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductApplicationService _productServiceApplication;

        public ProductController(IProductApplicationService productServiceApplication)
        {
            _productServiceApplication = productServiceApplication;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_productServiceApplication.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            return Ok(_productServiceApplication.GetById(id));
        }

        // POST api/values
        [HttpPost]
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

        // PUT api/values/5
        [HttpPut]
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

        // DELETE api/values/5
        [HttpDelete()]
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
