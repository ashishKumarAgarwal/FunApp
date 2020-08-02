using FunApp.Common.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
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
            //return await _httpClient.GetJsonAsync<IEnumerable<SubjectArea>>(BaseApi);
            return new List<SubjectArea>()
            {
                new SubjectArea()
                {
                        Name = "Snowflake",
                         SubjectAreaId = 1,
                    },
                new SubjectArea()
                {
                        Name = "Rundeck",
                         SubjectAreaId = 2,
                    },
                new SubjectArea()
                {
                        Name = "Attunity",
                         SubjectAreaId = 3,
                    } ,
                new SubjectArea()
                {
                        Name = "Chef",
                         SubjectAreaId = 4,
                    }};
        }

        public async Task<IEnumerable<SubjectArea>> GetSubjectArea(int SubjectAreaId)
        {
            return new List<SubjectArea>()
            {
                new SubjectArea()
                {
                        Name = "Snowflake",
                         SubjectAreaId = 1,
                    },
                new SubjectArea()
                {
                        Name = "Rundeck",
                         SubjectAreaId = 2,
                    },
                new SubjectArea()
                {
                        Name = "Attunity",
                         SubjectAreaId = 3,
                    },
                new SubjectArea()
                {
                        Name = "Chef",
                         SubjectAreaId = 4,
                    } }.Where(doc => doc.SubjectAreaId == SubjectAreaId);
            //return await _httpClient.GetJsonAsync<IEnumerable<SubjectArea>>($"{BaseApi}/{SubjectAreaId}");
        }
    }
}