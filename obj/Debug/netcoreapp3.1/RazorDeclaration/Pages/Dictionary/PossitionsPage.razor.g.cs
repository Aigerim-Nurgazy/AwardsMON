#pragma checksum "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Dictionary/PossitionsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68068f17cee709be18f8f037b85edd41e7136548"
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
#line 3 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Dictionary/PossitionsPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Dictionary/PossitionsPage.razor"
using BlzMON.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Dictionary/PossitionsPage.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Dictionary/PossitionsPage.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Dictionary/PossitionsPage.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/possitionpage")]
    public partial class PossitionsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/Dictionary/PossitionsPage.razor"
       

    private List<Possitions> сonclusions = new List<Possitions>();

    private Possitions сonclusion = new Possitions();

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    ApplicationUser objUser;
    string strError = "";
    string title = "";
    bool ShowPopup = false;


    void AddNew()
    {
        сonclusion = new Possitions();
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
                Possitions lt = await db.Possition.FindAsync(сonclusion.Id);
                lt.Id = сonclusion.Id;
                lt.PossName = сonclusion.PossName;
                await db.SaveChangesAsync();
            }
            else
            {
                db.Possition.Add(сonclusion);
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
    async Task Edit(Possitions lt)
    {
        title = "Редактирование";
        сonclusion = lt;
        ShowPopup = true;
    }
    async Task Delete(Possitions lt)
    {
        ShowPopup = false;
        var obj = await db.Possition.FindAsync(lt.Id);
        if (obj != null)
        {
            db.Possition.Remove(obj);
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
        сonclusion = new Possitions();
        сonclusions = db.Possition.OrderBy(x => x.PossName).ToList();

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591