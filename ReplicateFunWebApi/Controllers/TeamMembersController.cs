using FunApp.Common.Models;
using FunApp.WebApI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FunApp.WebApI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMembersController : ControllerBase
    {
        private readonly ITeamMembersRepository _teamMemberRepository;

        public TeamMembersController(ITeamMembersRepository teamMembersRepository)

        {
            _teamMemberRepository = teamMembersRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetTeamMembers()
        {
            try
            {
                return Ok(await _teamMemberRepository.GetTeamMembers());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetTeamMember(int id)
        {
            try
            {
                return Ok(await _teamMemberRepository.GetTeamMember(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<TeamMember>> CreateTeamMember(TeamMember teamMember)
        {
            try
            {
                if (teamMember == null)
                {
                    return BadRequest();
                }

                var createdTeamMember = await _teamMemberRepository.AddTeamMember(teamMember);

                return CreatedAtAction(nameof(GetTeamMember), new { id = createdTeamMember.TeamMemberId },
                    createdTeamMember);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPut]
        public async Task<ActionResult<TeamMember>> UpdateTeamMember(TeamMember teamMember)
        {
            try
            {
                var teamMemberToUpdate = await _teamMemberRepository.GetTeamMember(teamMember.TeamMemberId);

                if (teamMemberToUpdate == null)
                {
                    return NotFound($"Team member with Id = {teamMember.TeamMemberId} not found");
                }

                return await _teamMemberRepository.UpdateTeamMember(teamMember);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<TeamMember>> DeleteTeamMember(int id)
        {
            try
            {
                var memberToDelete = await _teamMemberRepository.GetTeamMember(id);

                if (memberToDelete == null)
                {
                    return NotFound($"Team member with Id = {id} not found");
                }

                return await _teamMemberRepository.DeleteTeamMember(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }
    }
}