using API.DDD.Application.Dtos;
using API.DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace RestApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderApplicationService _orderServiceApplication;

        public OrderController(IOrderApplicationService orderServiceApplication)
        {
            _orderServiceApplication = orderServiceApplication;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_orderServiceApplication.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            return Ok(_orderServiceApplication.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] OrderDto orderDto)
        {
            try
            {
                if (orderDto == null)
                    return NotFound();


                _orderServiceApplication.Add(orderDto);
                return Ok("The order has been successfully registered");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] OrderDto orderDto)
        {

            try
            {
                if (orderDto == null)
                    return NotFound();

                _orderServiceApplication.Update(orderDto);
                return Ok("The order has been updated successfully!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] OrderDto orderDto)
        {
            try
            {
                if (orderDto == null)
                    return NotFound();

                _orderServiceApplication.Remove(orderDto);
                return Ok("The order has been removed successfully!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
