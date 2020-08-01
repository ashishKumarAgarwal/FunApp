using System.ComponentModel.DataAnnotations;

namespace FunApp.Common.Models
{
    public class Video
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