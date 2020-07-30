using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunApp.Common.Models;
using FunApp.Services;
using Microsoft.AspNetCore.Components;

namespace FunApp.Pages.ProjectDetails
{
    public class ProjectDetailsBase : ComponentBase
    {
        [Inject]
        public ITeamMemberService TeamMemberService { get; set; }

        public IEnumerable<TeamMember> Members { get; set; }
        public ProjectDetailList _projectDetail;

        protected override async Task OnInitializedAsync()
        {
            Members = (await TeamMemberService.GetTeamMembers()).ToList();
            _projectDetail = new ProjectDetailList();
        }
    }
}