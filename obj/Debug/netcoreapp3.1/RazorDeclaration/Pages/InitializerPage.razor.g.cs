#pragma checksum "/Users/aigerim/Downloads/PFT/BlzMON/Pages/InitializerPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e3e3bf9497648f4aa581d39c106ffd7bef6dd87"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlzMON.Pages
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
#line 11 "/Users/aigerim/Downloads/PFT/BlzMON/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/InitializerPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/InitializerPage.razor"
using BlzMON.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/InitializerPage.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/InitializerPage.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/InitializerPage.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/InitializerPage.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/InitializerPage.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/InitializerPage")]
    public partial class InitializerPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 222 "/Users/aigerim/Downloads/PFT/BlzMON/Pages/InitializerPage.razor"
       
    public List<Initializers> initializers = new List<Initializers>();
    public List<Initializers> initializers2 = new List<Initializers>();
    public Initializers initializer = new Initializers();


    List<Possitions> possitions = new List<Possitions>();
    List<Educations> educations = new List<Educations>();
    List<Areass> areas = new List<Areass>();
    //List<Regions> regions = new List<Regions>();
    //List<Initializers> initializers = new List<Initializers>();
    // List<Documents> documents = new List<Documents>();
    // Initializers initializer = new Initializers();


    private int CurrentValue { get; set; }
    public string itemValue { get; set; }
    public string item
    {
        get { return itemValue; }
        set
        {
            CurrentValue = initializers.Count();
            if (value.Length > 0)
            {
                initializers = initializers2.Where(x => x.PersonSurname.ToLower().Contains(value)).ToList();
            }
            else
            {
                initializers = initializers2;
            }
            itemValue = value;
        }
    }

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    ApplicationUser objUser;
    string strError = "";
    bool ShowPopup = false;


    void AddNew()
    {
        initializer = new Initializers();
        possitions = db.Possition.ToList();
        educations = db.Education.ToList();
        areas = db.Areaq.ToList();
        //maay
        // initializers = db.Initializers.ToList();
        //regions = db.Region.ToList();
        // documents = db.Document.ToList();
        initializer.Id = 0;
        ShowPopup = true;

    }
    async Task Save()
    {
        try
        {
            // Is this an existing user?
            if (initializer.Id != 0)
            {
                Initializers init = await db.Initializers.FindAsync(initializer.Id);
                //...IG dont forget this one

                init.PersonName = initializer.PersonName;
                init.PersonSurname = initializer.PersonSurname;
                init.PersonPatronymic = initializer.PersonPatronymic;
                init.DateOfBirth = initializer.DateOfBirth;
                init.CellPhone = initializer.CellPhone;
                init.EmailAddress = initializer.EmailAddress;
                init.PersonAddress = initializer.PersonAddress;

                await db.SaveChangesAsync();
            }
            else
            {
                // int maxId = db.Initializers.Max(x => x.Id);
                // initializer.Id = (maxId + 1);
                db.Initializers.Add(initializer);
                await db.SaveChangesAsync();
            }

            // Close the Popup
            ShowPopup = false;
            // Refresh Users
            LoadData();
            initializer = new Initializers();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }
    async Task Edit(Initializers rc)
    {
        initializer = rc;
        //products = db.Products.Where(x => x.CategoryId == ).ToList();
        ShowPopup = true;
    }
    async Task Delete()
    {
        // Close the Popup
        ShowPopup = false;
        // Get the user
        var rc = await db.Initializers.FindAsync(initializer.Id);
        if (rc != null)
        {
            db.Initializers.Remove(rc);
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

        initializer = new Initializers();
        LoadData();
    }
    public void LoadData()
    {
        initializers = db.Initializers.OrderBy(x => x.PersonSurname).ToList();
        // initializers2 initializer= db.Initializers.OrderBy(x => x.PersonName).ToList(); //double shit :)
    }
    private async Task Insert()
    {
        db.Initializers.Add(initializer);
        await db.SaveChangesAsync();
        initializers.Add(initializer);
        initializer = new Initializers();
    }



    DateTime? value = DateTime.Now;

    IEnumerable<DateTime> dates = new DateTime[] { DateTime.Today.AddDays(-1), DateTime.Today.AddDays(1) };

    Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();

    void Change(DateTime? value, string name, string format)
    {
        events.Add(DateTime.Now, $"{name} value changed to {value?.ToString(format)}");
        StateHasChanged();
    }

    void DateRenderSpecial(DateRenderEventArgs args)
    {
        if (dates.Contains(args.Date))
        {
            args.Attributes.Add("style", "background-color: #ff6d41; border-color: white;");
        }
    }

    void DateRender(DateRenderEventArgs args)
    {
        args.Disabled = dates.Contains(args.Date);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591
