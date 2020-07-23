using System.Collections.Generic;
using System.Threading.Tasks;
using FunApp.Common.Models;

namespace FunApp.Services
{
    public interface ITeamMemberService
    {
        Task<IEnumerable<TeamMember>> GetTeamMembers();
    }
}