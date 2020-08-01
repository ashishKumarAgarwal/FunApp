using System.Collections.Generic;
using System.Threading.Tasks;
using FunApp.Common.Models;

namespace FunApp.WebApI.Repositories
{
    public interface IRetrospectionRepository
    {
        Task<Retrospection> GetRetrospection(int teamMemberId);
        Task<Retrospection> AddRetrospection(Retrospection retrospection);
        Task<Retrospection> UpdateRetrospection(Retrospection retrospection);
        Task<IEnumerable<Retrospection>> GetRetrospections();
    }
}