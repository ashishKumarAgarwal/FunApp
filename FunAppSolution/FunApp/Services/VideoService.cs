using FunApp.Common.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FunApp.Services
{
    public class VideoService : IVideoService
    {
        private readonly HttpClient _httpClient;
        private const string BaseApi = "api/video";

        public VideoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Video>> GetVideos()
        {
            return await _httpClient.GetJsonAsync<IEnumerable<Video>>(BaseApi);
        }

        public async Task<IEnumerable<Video>> GetVideosBySubjectArea(int SubjectAreaId)
        {
            return await _httpClient.GetJsonAsync<IEnumerable<Video>>($"{BaseApi}/{SubjectAreaId}");
            //return new List<Video>()
            //{
            //    new Video()
            //    {
            //        Id = 1,
            //        Name = "test",
            //        SubjectArea = new SubjectArea()
            //        {
            //            Name = "Snowflake",
            //            SubjectAreaId = 1,
            //        },
            //        SubjectAreaId = 1,
            //        Value = "Test link",
            //        Type = "Test"
            //    },
            //    new Video()
            //    {
            //        Id = 1,
            //        Name = "test",
            //        SubjectArea = new SubjectArea()
            //        {
            //            Name = "Rundeck",
            //            SubjectAreaId = 2,
            //        },
            //        SubjectAreaId = 2,
            //        Value = "Test link",
            //        Type = "Test"
            //    }
            //};
        }
    }
}