using System.Collections.Generic;
using FunApp.Common.Models;
using FunApp.WebApI.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FunApp.WebApI.Repositories
{
    public class RetrospectionRepository : IRetrospectionRepository
    {
        private readonly AppDbContext _appDbContext;

        public RetrospectionRepository(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        public async Task<Retrospection> AddRetrospection(Retrospection retrospection)
        {
            var result = await _appDbContext.Retrospection.AddAsync(retrospection);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Retrospection> UpdateRetrospection(Retrospection retrospection)
        {
            var retrospectionInDb = await _appDbContext.Retrospection
                .FirstOrDefaultAsync(e => e.RetrospectionId == retrospection.RetrospectionId);

            if (retrospectionInDb != null)
            {
                retrospectionInDb.AreaOfImprovement = retrospection.AreaOfImprovement;
                retrospectionInDb.HappinessIndex = retrospection.HappinessIndex;
                retrospectionInDb.Wentwell = retrospection.Wentwell;
                await _appDbContext.SaveChangesAsync();

                return retrospectionInDb;
            }

            return null;
        }

        public async Task<IEnumerable<Retrospection>> GetRetrospections()
        {
            return await _appDbContext.Retrospection.ToListAsync();
        }

        public async Task<Retrospection> GetRetrospection(int teamMemberId)
        {
            return await _appDbContext.Retrospection.FirstOrDefaultAsync(tm => tm.TeamMemberId == teamMemberId);
        }
    }
}