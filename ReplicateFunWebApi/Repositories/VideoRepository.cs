using System.Collections.Generic;
using System.Linq;
using FunApp.Common.Models;
using FunApp.WebApI.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FunApp.WebApI.Repositories
{
    public class VideoRepository : IVideoRepository
    {
        private readonly AppDbContext _appDbContext;

        public VideoRepository(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        public async Task<Video> AddVideo(Video video)
        {
            var result = await _appDbContext.Videos.AddAsync(video);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Video> UpdateVideo(Video video)
        {
            var videosInDb = await _appDbContext.Videos
                .FirstOrDefaultAsync(e => e.Id == video.Id);

            if (videosInDb != null)
            {
                videosInDb.Name = video.Name;
                videosInDb.Value = video.Value;
                videosInDb.SubjectArea = video.SubjectArea;
                videosInDb.SubjectAreaId = video.SubjectAreaId;
                await _appDbContext.SaveChangesAsync();

                return videosInDb;
            }

            return null;
        }

        public async Task<IEnumerable<Video>> GetVideos()
        {
            return await _appDbContext.Videos.ToListAsync();
        }

        public async Task<Video> GetVideo(int Id)
        {
            return await _appDbContext.Videos.FirstOrDefaultAsync(vid => vid.Id == Id);
        }

        public async Task<IEnumerable<Video>> GetGetVideoBySubjectArea(int sujectAreaId)
        {
            return await _appDbContext.Videos.Where(vid => vid.SubjectAreaId == sujectAreaId).ToListAsync();
        }
    }
}