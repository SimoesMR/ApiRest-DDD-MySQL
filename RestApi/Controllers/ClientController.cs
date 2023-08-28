using API.DDD.Application;
using API.DDD.Application.Dtos;
using API.DDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace RestApi.Controllers
{
    [ApiController]
    public class ClientController : ControllerBase
    {

        private readonly IClientApplicationService _clientServiceApplication;


        public ClientController(IClientApplicationService clientServiceApplication)
        {
            _clientServiceApplication = clientServiceApplication;
        }
       
        [HttpGet]
        [Route("[controller]/GetAll")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_clientServiceApplication.GetAll());
        }

        [HttpGet]
        [Route("[controller]/GetById/Id")]
        public ActionResult<string> Get(Guid id)
        {
            return Ok(_clientServiceApplication.GetById(id));
        }

        [HttpPost]
        [Route("[controller]/Insert")]
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

        [HttpPut]
        [Route("[controller]/Update")]
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

        [HttpDelete()]
        [Route("[controller]/Delete")]
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
