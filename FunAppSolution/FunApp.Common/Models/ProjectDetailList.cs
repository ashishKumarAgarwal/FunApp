using System.ComponentModel.DataAnnotations;

namespace FunApp.Common.Models
{
    public class ProjectDetailList
    {
        public Video VideoList { get; set; } = new Video();
        public Doc DocumentList { get; set; } = new Doc();
       
    }
}