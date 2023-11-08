﻿using DataBase.Interface;
using DTO;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using Services.ServicesRepos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LevviaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditMasterController : ControllerBase
    {
        private readonly IAudtiMasterService _audtiMasterService;
        public AuditMasterController(IAudtiMasterService audtiMasterService)
        {
            _audtiMasterService = audtiMasterService;
        }
        // GET: api/<AuditMasterController>
        [HttpGet("GetAllAudits")]
        public async Task<ActionResult<IEnumerable<AuditMasterDTO>>> GetAllAudits()
        {
            try
            {
                var  auditMaster = await _audtiMasterService.GetAuditMaster();
                return Ok(auditMaster);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Error while retrieving user skills.");
                return StatusCode(500, "Internal server error");
            }
        }


        // GET api/<AuditMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AuditMasterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AuditMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuditMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}