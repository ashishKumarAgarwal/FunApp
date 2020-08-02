using System.Collections.Generic;
using System.Threading.Tasks;
using FunApp.Common.Models;

namespace FunApp.WebApI.Repositories
{
    public interface IVideoRepository
    {
        Task<Video> GetVideo(int Id);
        Task<Video> AddVideo(Video video);
        Task<Video> GetGetVideoBySubjectArea(int subjectAreaId);
        Task<Video> UpdateVideo(Video video);
        Task<IEnumerable<Video>> GetVideos();
    }
}