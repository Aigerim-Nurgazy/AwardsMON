#pragma checksum "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\ComissionsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dc2b2f85cc43fb3e4bcb57348a6cd3209feac7f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlzMON.Pages.Dictionary
{
    #line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using BlzMON;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using BlzMON.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\ComissionsPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\ComissionsPage.razor"
using BlzMON.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\ComissionsPage.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\ComissionsPage.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/comissionpage")]
    public partial class ComissionsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\ComissionsPage.razor"
           private List<Commissions> сonclusions = new List<Commissions>();    private Commissions сonclusion = new Commissions();    [CascadingParameter]    private Task<AuthenticationState> authenticationStateTask { get; set; }    System.Security.Claims.ClaimsPrincipal CurrentUser;    ApplicationUser objUser;    string strError = "";    string title = "";    bool ShowPopup = false;    void AddNew()    {        сonclusion = new Commissions();        сonclusion.Id = 0;        title = "Новая запись";        ShowPopup = true;    }    async Task Save()    {        try        {            if (сonclusion.Id != 0)            {                Commissions lt = await db.Commission.FindAsync(сonclusion.Id);                lt.Id = сonclusion.Id;                lt.Person = сonclusion.Person;                await db.SaveChangesAsync();            }            else            {                db.Commission.Add(сonclusion);                await db.SaveChangesAsync();            }            ShowPopup = false;            LoadData();        }        catch (Exception ex)        {            strError = ex.GetBaseException().Message;        }    }    async Task Edit(Commissions lt)    {        title = "Редактирование";        сonclusion = lt;        ShowPopup = true;    }    async Task Delete(Commissions lt)    {        ShowPopup = false;        var obj = await db.Commission.FindAsync(lt.Id);        if (obj != null)        {            db.Commission.Remove(obj);            await db.SaveChangesAsync();        }        LoadData();    }    void ClosePopup()    {        ShowPopup = false;    }    protected override async Task OnInitializedAsync()    {        // CurrentUser = (await authenticationStateTask).User;        // objUser = await _userManager.FindByNameAsync(CurrentUser.Identity.Name);        LoadData();    }    public void LoadData()    {        сonclusion = new Commissions();        сonclusions = db.Commission.OrderBy(x => x.Person).ToList();    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591
