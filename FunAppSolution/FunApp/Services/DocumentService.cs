using FunApp.Common.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FunApp.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly HttpClient _httpClient;
        private const string BaseApi = "api/documents";

        public DocumentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Document>> GetDocuments()
        {
            return await _httpClient.GetJsonAsync<IEnumerable<Document>>(BaseApi);
        }

        public async Task<IEnumerable<Document>> GetDocumentsBySubjectArea(int SubjectAreaId)
        {
            //return new List<Document>()
            //{
            //    new Document()
            //    {
            //        Id = 1,
            //        Name = "test",
            //        SubjectArea = new SubjectArea()
            //        {
            //            Name = "Snowflake",
            //             SubjectAreaId = 1,
            //        },
            //        SubjectAreaId = 1,
            //        Value = "Test link",
            //        Type = "Test"
            //    },
            //    new Document()
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
             return await _httpClient.GetJsonAsync<IEnumerable<Document>>($"{BaseApi}/{SubjectAreaId}");
        }
    }
}