using System.Collections.Generic;
using System.Threading.Tasks;
using FunApp.Common.Models;

namespace FunApp.Services
{
    public interface IRetrospectionService
    {
        
        Task<Retrospection> GetRetrospectionDetails(int MemberId);
      
    }
}