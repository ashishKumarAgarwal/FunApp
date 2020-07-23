using System.Collections.Generic;
using System.Threading.Tasks;
using FunApp.Common.Models;
using FunApp.WebApI.DBContext;
using Microsoft.EntityFrameworkCore;

namespace FunApp.WebApI.Repositories
{
    public class TeamMemberRepository : ITeamMembersRepository
    {
        private AppDbContext _appDbContexxt;

        public TeamMemberRepository(AppDbContext dbContext)
        {
            _appDbContexxt = dbContext;
        }
        public async Task<IEnumerable<TeamMember>> GetTeamMembers()
        {
            //var teamMembers= new List<TeamMember>()
            //{
            //    new TeamMember()
            //    {
            //        Name = "Ashish",Id=1
            //    }
            //};
           return await _appDbContexxt.TeamMembers.ToListAsync();
           // return teamMembers;
        }

      
    }
}