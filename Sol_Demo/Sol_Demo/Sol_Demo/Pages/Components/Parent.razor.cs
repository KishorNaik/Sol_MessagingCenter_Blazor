using AKSoftware.Blazor.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Components
{
    public partial class Parent
    {
        private string MyMessage { get; set; }

        private void SubscribeToMessage()
        {
            MessagingCenter.Subscribe<Child, string>(this, "Message", (sender, value) =>
             {
                 MyMessage = value;
                 base.StateHasChanged();
             });
        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                SubscribeToMessage();
                base.StateHasChanged();
            }
        }
    }
}