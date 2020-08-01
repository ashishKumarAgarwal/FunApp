using System;
using FunApp.Services;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;

namespace FunApp.Pages.Retrospection
{
    public class RetrospectionEditBase : ComponentBase
    {
        [Inject]
        public IRetrospectionService RetrospectionService { get; set; }

        public Common.Models.Retrospection Retrospection { get; set; }

        [Parameter]
        public int MemberId { get; set; }

        [Parameter] 
        public EventCallback<bool> OnSave { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var allRetrospections = await RetrospectionService.GetRetrospection();
            var retrospection = allRetrospections.FirstOrDefault(retro => retro.MemberId == MemberId);
            Retrospection = retrospection ?? new Common.Models.Retrospection();
        }

        public async Task HandleValidSubmit()
        {
            bool isSaveSuccessful;
            try
            {
                if (Retrospection.RetrospectionId != 0)
                {
                    await RetrospectionService.UpdateRetrospection(Retrospection);
                }
                else
                {
                    await RetrospectionService.CreateRetrospection(Retrospection);
                }

                isSaveSuccessful = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
         

            await OnSave.InvokeAsync(isSaveSuccessful);
        }
    }
}