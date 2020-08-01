using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace FunApp.Common.Models
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        //Title
        public string Name { get; set; }
        //Link
        public string Value { get; set; }
        //Demo,Architecture,tutoril
        public string Type { get; set; }
        //Snowfalke,Rundeck,etc
        public SubjectArea SubjectArea { get; set; }
        public int SubjectAreaId { get; set; }
    }
}