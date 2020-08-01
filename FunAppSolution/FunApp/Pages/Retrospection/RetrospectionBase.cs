using FunApp.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace FunApp.Pages.Retrospection
{
    public class RetrospectionBase : ComponentBase
    {
        [Inject]
        public IRetrospectionService RetrospectionService { get; set; }

        public Common.Models.Retrospection Retrospection { get; set; }
        public int MemberId { get; set; } = 1;

        protected override async Task OnInitializedAsync()
        {
            Retrospection = (await RetrospectionService.GetRetrospectionDetails(MemberId));
        }
    }
}