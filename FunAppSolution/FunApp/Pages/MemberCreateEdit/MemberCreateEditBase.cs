using System.Threading.Tasks;
using FunApp.Common.Models;
using FunApp.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace FunApp.Pages.MemberCreateEdit
{
    public class MemberCreateEditBase : ComponentBase
    {
        [CascadingParameter]
        public Task<AuthenticationState> authenticationStateTask { get; set; }

        [Inject]
        public ITeamMemberService TeamMemberService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public string PageHeaderText { get; set; }

        public TeamMember TeamMember { get; set; } = new TeamMember();

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            int.TryParse(Id, out int employeeId);

            if (employeeId != 0)
            {
                PageHeaderText = "Edit Member";
                TeamMember = await TeamMemberService.GetTeamMember(int.Parse(Id));
            }
            else
            {
                PageHeaderText = "Create Member";
                TeamMember = new TeamMember();
            }
        }

        protected async Task HandleValidSubmit()
        {
            TeamMember result = null;

            if (TeamMember.TeamMemberId != 0)
            {
                result = await TeamMemberService.UpdateTeamMember(TeamMember);
            }
            else
            {
                result = await TeamMemberService.CreateTeamMember(TeamMember);
            }
            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}