using FunApp.WebApI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Threading.Tasks;

namespace FunApp.WebApI.Controllers
{
    [Route("api/SubjectArea")]
    [ApiController]
    public class SubjectAreaController : ControllerBase
    {
        private readonly ISubjectAreaRepository _subjectAreaRepository;

        public SubjectAreaController(ISubjectAreaRepository subjectAreaRepository)

        {
            _subjectAreaRepository = subjectAreaRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetSubjectAreas()
        {
            try
            {
                return Ok(await _subjectAreaRepository.GetSubjectAreas());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetSubjectArea(int id)
        {
            try
            {
                var SubArea = await _subjectAreaRepository.GetSubjectArea(id);
                if (SubArea == null)
                {
                    return NotFound();
                }

                return Ok(SubArea);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}