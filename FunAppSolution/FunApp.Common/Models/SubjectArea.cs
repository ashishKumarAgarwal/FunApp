using System.Collections.Generic;

namespace FunApp.Common.Models
{
    public class SubjectArea
    {
        public SubjectAreaType Type { get; set; }
        public IEnumerable<Video> Video { get; set; }
        public IEnumerable<Document> Document { get; set; }
    }
}