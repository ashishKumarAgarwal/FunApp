using System.Collections.Generic;
using System.Threading.Tasks;
using FunApp.Common.Models;

namespace FunApp.WebApI.Repositories
{
    public interface ITeamMembersRepository
    {
        Task<IEnumerable<TeamMember>> GetTeamMembers();
    }
}