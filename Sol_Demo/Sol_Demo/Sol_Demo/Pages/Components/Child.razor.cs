using AKSoftware.Blazor.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Components
{
    public partial class Child
    {
        private void OnSendDataFromChildToParent()
        {
            MessagingCenter.Send<Child, String>(this, "Message", "Hello from Child");
        }
    }
}