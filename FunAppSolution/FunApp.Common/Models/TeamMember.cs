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
        public string Experience { get; set; }
        public string imgUrl { get; set; }
        public string InterestedTechnologies { get; set; }
        public string HappinessIndex { get; set; }
        public string Hobbies { get; set; }
        public string Birthday { get; set; }
        public string JoinedOn { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string LinkedInLink { get; set; }
    }
}