#pragma checksum "C:\Projects\cps422-apartment-app\Pages\EditProperty.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a77548b02d332c40a1866d99dff22aca613bcf78"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace apartment_app.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\cps422-apartment-app\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\cps422-apartment-app\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\cps422-apartment-app\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\cps422-apartment-app\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\cps422-apartment-app\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\cps422-apartment-app\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\cps422-apartment-app\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\cps422-apartment-app\_Imports.razor"
using apartment_app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\cps422-apartment-app\_Imports.razor"
using apartment_app.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\cps422-apartment-app\_Imports.razor"
using apartment_app.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projects\cps422-apartment-app\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Projects\cps422-apartment-app\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Projects\cps422-apartment-app\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\cps422-apartment-app\Pages\EditProperty.razor"
using apartment_app.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\cps422-apartment-app\Pages\EditProperty.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\cps422-apartment-app\Pages\EditProperty.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editproperty/{Id:int}")]
    public partial class EditProperty : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Projects\cps422-apartment-app\Pages\EditProperty.razor"
       

    [Parameter]
    public int? Id { get; set; }

    public Property Property { get; set; } = new Property();

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            Property = await PropertiesDB.Property.FirstOrDefaultAsync(m => m.ID == Id);
            if (Property == null)
            {
                NavManager.NavigateTo("/NotFound");
            }
        }
        else
        {
            NavManager.NavigateTo("/NotFound");
        }
    }

    private async Task EditPropertyFunction(Property newProperty)
    {
        this.Property = newProperty;
        PropertiesDB.Attach(Property).State = EntityState.Modified;

        try
        {
            await PropertiesDB.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PropertyExists(Property.ID))
            {
                NavManager.NavigateTo("/NotFound");
            }
            else
            {
                throw;
            }
        }

        NavManager.NavigateTo("/viewproperty/" + this.Property.ID);
    }

    private bool PropertyExists(int id)
    {
        return PropertiesDB.Property.Any(e => e.ID == id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PropertiesContext PropertiesDB { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
