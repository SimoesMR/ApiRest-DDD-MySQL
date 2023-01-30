using API.DDD.Application;
using API.DDD.Application.Dtos;
using API.DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace RestApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        private readonly IClientApplicationService _clientServiceApplication;


        public ClientController(IClientApplicationService clientServiceApplication)
        {
            _clientServiceApplication = clientServiceApplication;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_clientServiceApplication.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            return Ok(_clientServiceApplication.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                _clientServiceApplication.Add(clientDto);
                return Ok("Client Registered Successfully!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                _clientServiceApplication.Update(clientDto);
                return Ok("Client Updated Successfully!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                _clientServiceApplication.Remove(clientDto);
                return Ok("Client Removed Successfully!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
