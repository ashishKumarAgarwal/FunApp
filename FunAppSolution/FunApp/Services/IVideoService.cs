using FunApp.Common.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FunApp.Services
{
    public interface IVideoService
    {
        Task<IEnumerable<Video>> GetVideos();
        Task<IEnumerable<Video>> GetVideosBySubjectArea(int SubjectAreaId);
    }
}