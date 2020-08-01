using FunApp.Common.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FunApp.Services
{
    public interface IRetrospectionService
    {
        Task<Retrospection> GetRetrospectionDetails(int MemberId);

        Task<IEnumerable<Retrospection>> GetRetrospection();

        Task<Retrospection> UpdateRetrospection(Retrospection retrospection);

        Task<Retrospection> CreateRetrospection(Retrospection retrospection);
    }
}