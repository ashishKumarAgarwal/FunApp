using FunApp.Common.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FunApp.Services
{
    public class TeamMemberService : ITeamMemberService
    {
        private HttpClient _httpClient;

        public TeamMemberService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<TeamMember>> GetTeamMembers()
        {
            var result = await _httpClient.GetJsonAsync<TeamMember[]>("api/teammembers");
            return result;
        }

        public async Task<TeamMember> GetTeamMember(int id)
        {
            var result = await _httpClient.GetJsonAsync<TeamMember>($"api/teammembers/{id}");
            return result;
        }
    }
}