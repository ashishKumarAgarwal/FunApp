using System.ComponentModel.DataAnnotations;

namespace FunApp.Common.Models
{
    public class Retrospection
    {
        [Key]
        public int RetrospectionId { get; set; }
        public string Wentwell { get; set; }
        public string AreaOfImprovement { get; set; }
        public string HappinessIndex { get; set; }
        public int TeamMemberId { get; set; }
    }
}