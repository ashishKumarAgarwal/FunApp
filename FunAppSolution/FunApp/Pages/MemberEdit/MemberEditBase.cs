using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunApp.Common.Models;
using FunApp.Services;
using Microsoft.AspNetCore.Components;

namespace FunApp.Pages.MemberEdit
{
    public class MemberEditBase : ComponentBase
    {
        [Inject]
        private ITeamMemberService TeamMemberService { get; set; }

        public TeamMember TeamMember { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            TeamMember = (await TeamMemberService.GetTeamMember(int.Parse(Id)));
        }
    }
}
