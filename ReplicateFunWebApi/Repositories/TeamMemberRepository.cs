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

        public async Task<TeamMember> AddTeamMember(TeamMember teamMember)
        {
            var result = await _appDbContext.TeamMembers.AddAsync(teamMember);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<TeamMember> UpdateTeamMember(TeamMember teamMember)
        {
            var teamMemberInDb = await _appDbContext.TeamMembers
                .FirstOrDefaultAsync(e => e.Id == teamMember.Id);

            if (teamMemberInDb != null)
            {
                teamMemberInDb.Name = teamMember.Name;
                teamMemberInDb.FunName = teamMember.FunName;
                teamMemberInDb.Designation = teamMember.Designation;
                teamMemberInDb.Experience = teamMember.Experience;
                teamMemberInDb.PrimarySkills = teamMember.PrimarySkills;
                teamMemberInDb.SecondarySkills = teamMember.SecondarySkills;
                teamMemberInDb.imgUrl = teamMember.imgUrl;
                teamMemberInDb.Birthday = teamMember.Birthday;
                teamMemberInDb.HappinessIndex = teamMember.HappinessIndex;
                teamMemberInDb.Hobbies = teamMember.Hobbies;
                teamMemberInDb.InterestedTechnologies = teamMember.InterestedTechnologies;
                teamMemberInDb.JoinedOn = teamMember.JoinedOn;

                await _appDbContext.SaveChangesAsync();

                return teamMemberInDb;
            }

            return null;
        }

        public async Task<TeamMember> DeleteTeamMember(int teamMemberId)
        {
            var teamMemberInDb = await _appDbContext.TeamMembers
                .FirstOrDefaultAsync(e => e.Id == teamMemberId);
            if (teamMemberInDb != null)
            {
                _appDbContext.TeamMembers.Remove(teamMemberInDb);
                await _appDbContext.SaveChangesAsync();
                return teamMemberInDb;
            }

            return null;
        }
    }
}