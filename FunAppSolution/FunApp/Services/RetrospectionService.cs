using FunApp.Common.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace FunApp.Services
{
    public class RetrospectionService : IRetrospectionService
    {
        private readonly HttpClient _httpClient;
        private const string BaseApi = "api/retrospection";

        public RetrospectionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Retrospection> UpdateRetrospection(Retrospection retrospection)
        {
            return await _httpClient.PutJsonAsync<Retrospection>(BaseApi, retrospection);
        }

        public async Task<Retrospection> CreateRetrospection(Retrospection retrospection)
        {
            return await _httpClient.PostJsonAsync<Retrospection>(BaseApi, retrospection);
        }

        public async Task<Retrospection> GetRetrospectionDetails(int memberId)
        {
            var result = await _httpClient.GetJsonAsync<Retrospection>($"{BaseApi}/{memberId}");
            return result;
        }
    }
}