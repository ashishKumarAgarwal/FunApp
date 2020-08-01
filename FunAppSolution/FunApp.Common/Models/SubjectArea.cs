using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FunApp.Common.Models
{
    public class SubjectArea
    {
        [Key]
        public int SubjectAreaId { get; set; }
        //snowflake,rundeck etc
        public string Name { get; set; }

    }
}