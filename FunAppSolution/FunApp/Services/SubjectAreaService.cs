using FunApp.Common.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FunApp.Services
{
    public class SubjectAreaService : ISubjectAreaService
    {
        private readonly HttpClient _httpClient;
        private const string BaseApi = "api/subjectarea";

        public SubjectAreaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<SubjectArea>> GetSubjectAreas()
        {
            return await _httpClient.GetJsonAsync<IEnumerable<SubjectArea>>(BaseApi);
        }

        public async Task<IEnumerable<SubjectArea>> GetSubjectArea(int SubjectAreaId)
        {
            return await _httpClient.GetJsonAsync<IEnumerable<SubjectArea>>($"{BaseApi}/{SubjectAreaId}");
        }
    }
}