using API.DDD.Application.Dtos;
using API.DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace RestApi.Controllers
{
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderApplicationService _orderServiceApplication;

        public OrderController(IOrderApplicationService orderServiceApplication)
        {
            _orderServiceApplication = orderServiceApplication;
        }

        [HttpGet]
        [Route("[controller]/GetAll")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_orderServiceApplication.GetAll());
        }

        [HttpGet]
        [Route("[controller]/GetById/Id")]
        public ActionResult<string> Get(Guid id)
        {
            return Ok(_orderServiceApplication.GetById(id));
        }

        // POST api/values
        [HttpPost]
        [Route("[controller]/Insert")]
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

        [HttpPut]
        [Route("[controller]/Update")]
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

        [HttpDelete()]
        [Route("[controller]/Delete")]
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
