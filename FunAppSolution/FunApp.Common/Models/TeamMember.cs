using System.ComponentModel.DataAnnotations;

namespace FunApp.Common.Models
{
    public class TeamMember
    {
        public string Name { get; set; }

        [Key]
        public int Id { get; set; }
        public string Designation { get; set; }
        public string FunName { get; set; }
        public string PrimarySkills { get; set; }
        public string SecondarySkills { get; set; }
        public float Experience { get; set; }
        public string imgUrl { get; set; }
    }
}