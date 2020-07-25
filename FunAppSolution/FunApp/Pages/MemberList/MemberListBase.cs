using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunApp.Common.Models;
using FunApp.Services;
using Microsoft.AspNetCore.Components;

namespace FunApp.Pages.MemberList
{
    public class MemberListBase : ComponentBase
    {
        [Inject]
        public ITeamMemberService TeamMemberService { get; set; }

        public IEnumerable<TeamMember> Members { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Members = (await TeamMemberService.GetTeamMembers()).ToList();
        }
    }
}