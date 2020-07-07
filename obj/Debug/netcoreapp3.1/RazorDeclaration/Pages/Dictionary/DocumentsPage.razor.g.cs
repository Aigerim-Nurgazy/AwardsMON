#pragma checksum "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Dictionary/DocumentsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9d888126430fee8e03fe997fa331cb7556cd5eb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlzMON.Pages.Dictionary
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using BlzMON;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using BlzMON.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Dictionary/DocumentsPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Dictionary/DocumentsPage.razor"
using BlzMON.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Dictionary/DocumentsPage.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Dictionary/DocumentsPage.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/documentspage")]
    public partial class DocumentsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Dictionary/DocumentsPage.razor"
       

    private List<Documents> сonclusions = new List<Documents>();

    private Documents сonclusion = new Documents();

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    ApplicationUser objUser;
    string strError = "";
    string title = "";
    bool ShowPopup = false;


    void AddNew()
    {
        сonclusion = new Documents();
        сonclusion.Id = 0;
        title = "Новоя запись";
        ShowPopup = true;
    }
    async Task Save()
    {
        try
        {
            if (сonclusion.Id != 0)
            {
                Documents lt = await db.Document.FindAsync(сonclusion.Id);
                lt.Id = сonclusion.Id;
                lt.DocName = сonclusion.DocName;
                await db.SaveChangesAsync();
            }
            else
            {
                db.Document.Add(сonclusion);
                await db.SaveChangesAsync();
            }

            ShowPopup = false;
            LoadData();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }
    async Task Edit(Documents lt)
    {
        title = "Редактирование";
        сonclusion = lt;
        ShowPopup = true;
    }
    async Task Delete(Documents lt)
    {
        ShowPopup = false;
        var obj = await db.Document.FindAsync(lt.Id);
        if (obj != null)
        {
            db.Document.Remove(obj);
            await db.SaveChangesAsync();
        }
        LoadData();
    }
    void ClosePopup()
    {
        ShowPopup = false;
    }

    protected override async Task OnInitializedAsync()
    {
        // CurrentUser = (await authenticationStateTask).User;
        // objUser = await _userManager.FindByNameAsync(CurrentUser.Identity.Name);
        LoadData();
    }

    public void LoadData()
    {
        сonclusion = new Documents();
        сonclusions = db.Document.OrderBy(x => x.DocName).ToList();

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591
