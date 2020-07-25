using FunApp.Common.Models;
using FunApp.WebApI.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FunApp.WebApI.Repositories
{
    public class TeamMemberRepository : ITeamMembersRepository
    {
        private readonly AppDbContext _appDbContext;

        public TeamMemberRepository(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        public async Task<IEnumerable<TeamMember>> GetTeamMembers()
        {
            return await _appDbContext.TeamMembers.ToListAsync();
        }

        public async Task<TeamMember> GetTeamMember(int teamMemberId)
        {
            return await _appDbContext.TeamMembers.
                FirstOrDefaultAsync(tm => tm.Id == teamMemberId);
        }

        public Task<TeamMember> AddTeamMember(TeamMember teamMember)
        {
            throw new System.NotImplementedException();
        }

        public Task<TeamMember> UpdateTeamMember(TeamMember teamMember)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteTeamMember(int teamMemberId)
        {
            throw new System.NotImplementedException();
        }
    }
}