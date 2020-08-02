using FunApp.Common.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FunApp.Services
{
    public interface IDocumentService
    {
        Task<IEnumerable<Document>> GetDocuments();
        Task<IEnumerable<Document>> GetDocumentsBySubjectArea(int SubjectAreaId);
    }
}