using FunApp.Common.Models;
using FunApp.WebApI.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunApp.WebApI.Repositories
{
    public class SubjectAreaRepository : ISubjectAreaRepository
    {
        private readonly AppDbContext _appDbContext;

        public SubjectAreaRepository(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        public async Task<IEnumerable<SubjectArea>> GetSubjectAreas()
        {
            return await _appDbContext.SubjectAreas.ToListAsync();
        }

        public async Task<IEnumerable<SubjectArea>> GetSubjectArea(int subjectAreaId)
        {
            return await _appDbContext.SubjectAreas.Where(doc => doc.SubjectAreaId == subjectAreaId).ToListAsync();
        }
    }
}