using FunApp.WebApI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Threading.Tasks;

namespace FunApp.WebApI.Controllers
{
    [Route("api/Document")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentController(IDocumentRepository documentRepository)

        {
            _documentRepository = documentRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetDocument()
        {
            try
            {
                return Ok(await _documentRepository.GetDocuments());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetDocumentBySubArea(int id)
        {
            try
            {
                var retrospection = await _documentRepository.GetDocumentBySubArea(id);
                if (retrospection == null)
                {
                    return NotFound();
                }

                return Ok(retrospection);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}