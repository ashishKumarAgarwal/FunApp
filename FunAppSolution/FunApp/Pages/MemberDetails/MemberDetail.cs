using FunApp.Common.Models;
using FunApp.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace FunApp.Pages.MemberDetails
{
    public class MemberDetailBase : ComponentBase
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