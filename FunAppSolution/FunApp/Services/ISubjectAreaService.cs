using FunApp.Common.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FunApp.Services
{
    public interface ISubjectAreaService
    {
        Task<IEnumerable<SubjectArea>> GetSubjectAreas();
        Task<IEnumerable<SubjectArea>> GetSubjectArea(int SubjectAreaId);
    }
}