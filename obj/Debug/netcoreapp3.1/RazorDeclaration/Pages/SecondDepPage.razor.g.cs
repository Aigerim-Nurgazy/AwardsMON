#pragma checksum "/Users/aigerim/Downloads/PFT/BlzMON/Pages/SecondDepPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1da6c334f9453367cff1cab5f59dbcc0c7c7a25b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlzMON.Pages
{
    #line hidden
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
#line 8 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using BlzMON;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using BlzMON.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/SecondDepPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/SecondDepPage.razor"
using BlzMON.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/SecondDepPage.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/SecondDepPage.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/SecondDepPage.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/SecondDepPage.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/SecondDepPage.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/SecondDepPage.razor"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/SecondDepPage.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/SecondDepPage.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/SecondDepPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SecondDepPage")]
    public partial class SecondDepPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/SecondDepPage.razor"
       

    private int CurrentValue { get; set; }
    public string itemValue { get; set; }
    public string item
    {
        get { return itemValue; }
        set
        {
            CurrentValue = seconddeps.Count();
            if (value.Length > 0)
            {
                seconddeps = seconddeps2.Where(x => x.Person.ToLower().Contains(value)).ToList();//wtf
            }
            else
            {
                seconddeps = seconddeps2;
            }
            itemValue = value;
        }
    }
    private List<SecondDeps> seconddeps = new List<SecondDeps>();
    private List<SecondDeps> seconddeps2;
    private SecondDeps seconddep = new SecondDeps();

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    ApplicationUser objUser;
    string strError = "";
    string title = "";
    bool ShowPopup = false;


    void AddNew()
    {
        seconddep = new SecondDeps();
        //initializer.Code = "Test";   // What is it? double shit :0
        seconddep.Id = 0;
        title = "Новая запись";
        ShowPopup = true;
    }
    async Task Save()
    {
        try
        {
            // Is this an existing user?
            if (seconddep.Id != 0)
            {
                SecondDeps secdep = await db.SecondDep.FindAsync(seconddep.Id);
                //...IG dont forget this one
                secdep.DepName = seconddep.DepName;
                secdep.Person = seconddep.Person;
                secdep.DepPhone = seconddep.DepPhone;
                secdep.DepEmail = seconddep.DepEmail;
                secdep.DepAddress = seconddep.DepAddress;
                await db.SaveChangesAsync();
            }
            else
            {
                //int maxId = db.SecondDep.Max(x => x.Id);
                // seconddep.Id = (maxId + 1);
                db.SecondDep.Add(seconddep);
                await db.SaveChangesAsync();
            }

            // Close the Popup
            ShowPopup = false;
            // Refresh Users
            LoadData();
            seconddep = new SecondDeps();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }
    async Task Edit(SecondDeps secdep)
    {
        seconddep = secdep;
        //products = db.Products.Where(x => x.CategoryId == ).ToList();

        title = "Редактирование";
        ShowPopup = true;
    }
    async Task Delete(SecondDeps secdep)
    {
        // Close the Popup
        ShowPopup = false;
        // Get the user
        var obj = await db.SecondDep.FindAsync(secdep.Id);
        if (obj != null)
        {
            db.SecondDep.Remove(obj);
            await db.SaveChangesAsync();
        }
        LoadData();
    }

    void ClosePopup()
    {
        // Close the Popup
        ShowPopup = false;
    }

    protected override async Task OnInitializedAsync()
    {
        CurrentUser = (await authenticationStateTask).User;
        objUser = await _userManager.FindByNameAsync(CurrentUser.Identity.Name);

        seconddep = new SecondDeps();
        LoadData();
    }

    public void LoadData()
    {

        //???...

        seconddeps = db.SecondDep.OrderBy(x => x.DepName).ToList();
        // initializers2 initializer= db.Initializers.OrderBy(x => x.PersonName).ToList(); double shit :)
    }



    private async Task Insert()
    {
        db.SecondDep.Add(seconddep);
        await db.SaveChangesAsync();
        seconddeps.Add(seconddep);
        seconddep = new SecondDeps();
    }
    Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();
    void Change(DateTime? value, string name, string format)
    {
        events.Add(DateTime.Now, $"{name} value changed to {value?.ToString(format)}");
        StateHasChanged();
    }
    bool CheckBox1Value;
    bool? CheckBox2Value;
    bool? CheckBox3Value = true;


    void Change(bool? value, string name)
    {
        events.Add(DateTime.Now, $"{name} value changed to {value}");
        StateHasChanged();
    }
    private void Selected(SecondDeps secondDeps)
    {
        navigationManager.NavigateTo("Test/" + secondDeps.Id);
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591
