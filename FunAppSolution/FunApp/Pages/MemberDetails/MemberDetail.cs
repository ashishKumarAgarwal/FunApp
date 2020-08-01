using FunApp.Common.Models;
using FunApp.Pages.Retrospection;
using FunApp.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace FunApp.Pages.MemberDetails
{
    public class MemberDetailBase : ComponentBase
    {
        [Inject]
        private ITeamMemberService TeamMemberService { get; set; }

        public bool IsEditMode { get; set; }
        public TeamMember TeamMember { get; set; }

        [Parameter]
        public string Id { get; set; }

        [Parameter]
        public string EditSaveButtonName { get; set; } = "Edit";

        protected override async Task OnInitializedAsync()
        {
            TeamMember = (await TeamMemberService.GetTeamMember(int.Parse(Id)));
        }

        public RetrospectionEditBase retrospectionEditBase;

        protected async void ToggleEdit()
        {
            if (IsEditMode)
            {
                await retrospectionEditBase.HandleValidSubmit();
            }
            else
            {
                IsEditMode = true;
                EditSaveButtonName = "Save";
            }
        }

        public void Saved(bool status)
        {
            if (status)
            {
                IsEditMode = false;
                EditSaveButtonName = "Edit";
            }
           
        }
    }
}