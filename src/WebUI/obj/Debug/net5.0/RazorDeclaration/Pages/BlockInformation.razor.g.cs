// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Github\DbSync.EFCore.Demo\src\WebUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Github\DbSync.EFCore.Demo\src\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Github\DbSync.EFCore.Demo\src\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Github\DbSync.EFCore.Demo\src\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Github\DbSync.EFCore.Demo\src\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Github\DbSync.EFCore.Demo\src\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Github\DbSync.EFCore.Demo\src\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Github\DbSync.EFCore.Demo\src\WebUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Github\DbSync.EFCore.Demo\src\WebUI\_Imports.razor"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Github\DbSync.EFCore.Demo\src\WebUI\_Imports.razor"
using WebUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Github\DbSync.EFCore.Demo\src\WebUI\Pages\BlockInformation.razor"
using Application.Handlers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BlockInformation")]
    public partial class BlockInformation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Github\DbSync.EFCore.Demo\src\WebUI\Pages\BlockInformation.razor"
       

    private Block block = new(); 

    private class Block
    {
        public int slotLeader { get; set; }
        public int blockNumber { get; set; }
    }


    private async Task GetBlockInformation()
    {

        block.blockNumber = await _mediator.Send(new GetBlockNumberBySlotLeaderQuery(block.slotLeader));


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MediatR.IMediator _mediator { get; set; }
    }
}
#pragma warning restore 1591
