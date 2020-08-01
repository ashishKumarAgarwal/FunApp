using FunApp.Common.Models;
using FunApp.WebApI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FunApp.WebApI.Controllers
{
    [Route("api/Retrospection")]
    [ApiController]
    public class RetrospectionController : ControllerBase
    {
        private readonly IRetrospectionRepository _retrospectionRepository;

        public RetrospectionController(IRetrospectionRepository retrospectionRepository)

        {
            _retrospectionRepository = retrospectionRepository;
        }


        [HttpGet]
        public async Task<ActionResult> GetRetrospection()
        {
            try
            {
                return Ok(await _retrospectionRepository.GetRetrospections());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetRetrospection(int id)
        {
            try
            {
                return Ok(await _retrospectionRepository.GetRetrospection(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<TeamMember>> CreateRetrospection(Retrospection retrospection)
        {
            try
            {
                if (retrospection == null)
                {
                    return BadRequest();
                }

                var createdRetrospection = await _retrospectionRepository.AddRetrospection(retrospection);

                return CreatedAtAction(nameof(GetRetrospection), new { id = createdRetrospection.RetrospectionId },
                    createdRetrospection);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPut]
        public async Task<ActionResult<Retrospection>> UpdateRetrospection(Retrospection retrospection)
        {
            try
            {
                var retrospectionToUpdate = await _retrospectionRepository.GetRetrospection(retrospection.RetrospectionId);

                if (retrospectionToUpdate == null)
                {
                    return NotFound($"RetrospectionToUpdate with Id = {retrospection.RetrospectionId} not found");
                }

                return await _retrospectionRepository.UpdateRetrospection(retrospection);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

    }

}