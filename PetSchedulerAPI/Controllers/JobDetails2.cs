using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetSchedulerAPI.ApiModels;
using PetSchedulerAPI.Core.Services;
using Microsoft.AspNetCore.Mvc;
using PetSchedulerAPI.Core.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetSchedulerAPI.Controllers
{
    [Route("api/[controller]")]
    public class JobDetails2Controller : Controller
    {
        private IJobDetailsRepository _jobDetailsService;

        public JobDetails2Controller(IJobDetailsRepository jobDetailsService)
        {
            _jobDetailsService = jobDetailsService;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var jobDetails = _jobDetailsService
                .GetAll()
                .ToApiModels();

            return Ok(jobDetails);

        }
        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var jobDetails = _jobDetailsService.Get(id);

            if (jobDetails == null) return NotFound();
            return Ok(jobDetails.ToApiModel());
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] JobDetailsModel jobDetails)
        {
            try
            {
                _jobDetailsService.Add(jobDetails.ToDomainModel());
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("AddJobDetails", ex.GetBaseException().Message);
                return BadRequest(ModelState);
            }
            return CreatedAtAction("Get", new { Id = jobDetails.Id }, jobDetails);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] JobDetailsModel updatedJobDetails)
        {
            var jobDetails = _jobDetailsService.Update(updatedJobDetails.ToDomainModel());
            if (jobDetails == null) return NotFound();
            return Ok(jobDetails.ToApiModel());
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var jobDetails = _jobDetailsService.Get(id);
            if (jobDetails == null) return NotFound();
            _jobDetailsService.Remove(jobDetails);
            return NoContent();
        }
    }
}
