using System.Linq;
using FunApp.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace FunApp.Pages.Retrospection
{
    public class RetrospectionDetailsBase : ComponentBase
    {
        [Inject]
        public IRetrospectionService RetrospectionService { get; set; }

        public Common.Models.Retrospection Retrospection { get; set; }
       [Parameter]
        public int MemberId { get; set; } 

       
        protected override async Task OnInitializedAsync()
        {
            var allRetrospections = await RetrospectionService.GetRetrospection();
            var retrospection = allRetrospections.FirstOrDefault(retro => retro.TeamMemberId == MemberId);
            Retrospection = retrospection??new Common.Models.Retrospection();
        }

        protected async Task HandleValidSubmit()
        {
            if (Retrospection.RetrospectionId != 0)
            {
                await RetrospectionService.UpdateRetrospection(Retrospection);
            }
            else
            {
                await RetrospectionService.CreateRetrospection(Retrospection);
            }
        } 
        public async Task Test()
        {
            if (Retrospection.RetrospectionId != 0)
            {
                await RetrospectionService.UpdateRetrospection(Retrospection);
            }
            else
            {
                await RetrospectionService.CreateRetrospection(Retrospection);
            }
        }
    }
}