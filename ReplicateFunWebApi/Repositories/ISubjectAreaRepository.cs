using FunApp.Common.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FunApp.WebApI.Repositories
{
    public interface ISubjectAreaRepository
    {
        Task<IEnumerable<SubjectArea>> GetSubjectAreas();
        Task<IEnumerable<SubjectArea>> GetSubjectArea(int subjectAreaId);
    }
}