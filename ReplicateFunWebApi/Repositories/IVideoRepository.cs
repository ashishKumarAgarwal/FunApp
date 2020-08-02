using System.Collections.Generic;
using System.Threading.Tasks;
using FunApp.Common.Models;

namespace FunApp.WebApI.Repositories
{
    public interface IVideoRepository
    {
        Task<Video> GetVideo(int Id);
        Task<Video> AddVideo(Video video);
        Task<IEnumerable<Video>> GetGetVideoBySubjectArea(int sujectAreaId);
        Task<Video> UpdateVideo(Video video);
        Task<IEnumerable<Video>> GetVideos();
    }
}