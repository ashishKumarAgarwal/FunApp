using System.Collections.Generic;
using System.Threading.Tasks;
using FunApp.Common.Models;

namespace FunApp.WebApI.Repositories
{
    public interface ITeamMembersRepository
    {
        Task<IEnumerable<TeamMember>> GetTeamMembers();
        Task<TeamMember> GetTeamMember(int teamMemberId);
        Task<TeamMember> AddTeamMember(TeamMember teamMember);
        Task<TeamMember> UpdateTeamMember(TeamMember teamMember);
        void DeleteTeamMember(int teamMemberId);
    }
}