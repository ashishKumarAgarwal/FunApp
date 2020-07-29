using System.Collections.Generic;
using System.Threading.Tasks;
using FunApp.Common.Models;

namespace FunApp.Services
{
    public interface ITeamMemberService
    {
        Task<IEnumerable<TeamMember>> GetTeamMembers();
        Task<TeamMember> GetTeamMember(int id);
        Task<TeamMember> UpdateTeamMember(TeamMember teamMember);
        Task<TeamMember> CreateTeamMember(TeamMember teamMember);
        Task DeleteTeamMember(int id);
    }
}