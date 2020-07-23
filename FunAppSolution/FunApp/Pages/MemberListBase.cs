using FunApp.Common.Models;
using FunApp.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunApp.Pages
{
    public class MemberListBase : ComponentBase
    {
        [Inject]
        public ITeamMemberService TeamMemberService { get; set; }

        public IEnumerable<TeamMember> Members { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Members = (await TeamMemberService.GetTeamMembers()).ToList();
            //return result;
            // return base.OnInitializedAsync(result);
        }
    }
}