using FunApp.Common.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FunApp.WebApI.Repositories
{
    public interface IDocumentRepository
    {
        Task<IEnumerable<Document>> GetDocuments();
        Task<IEnumerable<Document>> GetDocumentBySubArea(int subjectAreaId);
    }
}