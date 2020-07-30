using System.ComponentModel.DataAnnotations;

namespace FunApp.Common.Models
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public SubjectArea RelatedArea { get; set; }
    }
}