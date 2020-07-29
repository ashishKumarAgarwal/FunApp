using FunApp.Common.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FunApp.Services
{
    public class TeamMemberService : ITeamMemberService
    {
        private readonly HttpClient _httpClient;
        private const string BaseApi = "api/teammembers";

        public TeamMemberService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<TeamMember>> GetTeamMembers()
        {
            var result = await _httpClient.GetJsonAsync<TeamMember[]>(BaseApi);
            return result;
        }

        public async Task<TeamMember> GetTeamMember(int id)
        {
            var result = await _httpClient.GetJsonAsync<TeamMember>($"{BaseApi}/{id}");
            return result;
        }

        public async Task<TeamMember> UpdateTeamMember(TeamMember teamMember)
        {
            return await _httpClient.PutJsonAsync<TeamMember>(BaseApi, teamMember);
        }

        public async Task<TeamMember> CreateTeamMember(TeamMember teamMember)
        {
            return await _httpClient.PostJsonAsync<TeamMember>(BaseApi, teamMember);
        }

        public async Task DeleteTeamMember(int id)
        {
            await _httpClient.DeleteAsync($"{BaseApi}/{id}");
        }
    }
}