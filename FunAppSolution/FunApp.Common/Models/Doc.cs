using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FunApp.Common.Models
{
    public class Doc
    {
        public Dictionary<string,string> DocumentNameWithLink { get; set; } = new Dictionary<string, string>() { {"Replicate Architecture" , "https://confluence.csgicorp.com/display/VT/DNA+Deployment+Architecture" },
            {"Replicate Environment Details", "https://confluence.csgicorp.com/display/VT/DNA+Replicate+Environments" },
            {"Db2 Password Rotation Steps","https://confluence.csgicorp.com/display/VT/IBM+DB2+password+rotation" },
            { "Snowflake Password Rotation Steps","https://confluence.csgicorp.com/display/VT/Snowflake+password+rotation"},
            { "Rundeck Sandbox","https://rundecksb.csgidev.com/user/login"},
            { "Rundeck Non-Prod","https://rundeck.csgidev.com/user/login"}
        };

    }
}