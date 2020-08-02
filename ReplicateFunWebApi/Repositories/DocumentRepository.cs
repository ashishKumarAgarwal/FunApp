using FunApp.Common.Models;
using FunApp.WebApI.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunApp.WebApI.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly AppDbContext _appDbContext;

        public DocumentRepository(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        public async Task<IEnumerable<Document>> GetDocuments()
        {
            return await _appDbContext.Documents.ToListAsync();
        }

        public async Task<IEnumerable<Document>> GetDocumentBySubArea(int subjectAreaId)
        {
            return await _appDbContext.Documents.Where(doc => doc.SubjectAreaId == subjectAreaId).ToListAsync();
        }
    }
}