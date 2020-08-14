#pragma checksum "/Users/aigerim/Desktop/BlzMON/Pages/OrderPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae7a1a2be505f2b2c6d67f44ec2fda5712e92218"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlzMON.Pages
{
    #line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using BlzMON;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using BlzMON.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/aigerim/Desktop/BlzMON/_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aigerim/Desktop/BlzMON/Pages/OrderPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aigerim/Desktop/BlzMON/Pages/OrderPage.razor"
using BlzMON.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Desktop/BlzMON/Pages/OrderPage.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/OrderPage")]
    public partial class OrderPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "/Users/aigerim/Desktop/BlzMON/Pages/OrderPage.razor"
        // OrderId is route parameter
            [Parameter]
            public int OrderId { get; set; }

            private int CurrentValue { get; set; }
            public string itemValue { get; set; }
            public string item
            {
                get { return itemValue; }
                set
                {
                    CurrentValue = departaments.Count();
                    if (value.Length > 0)
                    {
                        departaments = departaments2.Where(x => x.Person.ToLower().Contains(value)).ToList();//wtf
                    }
                    else
                    {
                        departaments = departaments2;
                    }
                    itemValue = value;
                }
            }
            private List<Departaments> departaments = new List<Departaments>();
            private List<Departaments> departaments2;
            private Departaments departament = new Departaments();

            [CascadingParameter]
            private Task<AuthenticationState> authenticationStateTask { get; set; }
            System.Security.Claims.ClaimsPrincipal CurrentUser;

            ApplicationUser objUser;
            string strError = "";
            bool ShowPopup = false;


            void AddNew()
            {
                departament = new Departaments();
                //initializer.Code = "Test";   // What is it? double shit :0
                departament.Id = 0;
                ShowPopup = true;
            }
            async Task Save()
            {
                try
                {
                    // Is this an existing user?
                    if (departament.Id != 0)
                    {
                        Departaments depart = await db.Departaments.FindAsync(departament.Id);

                        //...IG dont forget this one
                        depart.Name = departament.Name;
                        depart.Person = departament.Person;
                        depart.InitPhone = departament.InitPhone;
                        depart.InitEmail = departament.InitEmail;
                        depart.InitAddress = departament.InitAddress;
                        await db.SaveChangesAsync();
                    }
                    else
                    {
                        // int maxId = db.Departaments.Max(x => x.Id);
                        //departament.Id = (maxId + 1);
                        db.Departaments.Add(departament);
                        await db.SaveChangesAsync();
                    }

                    // Close the Popup
                    ShowPopup = false;
                    // Refresh Users
                    LoadData();
                    departament = new Departaments();
                }
                catch (Exception ex)
                {
                    strError = ex.GetBaseException().Message;
                }
            }
            async Task Edit(Departaments rc)
            {
                departament = rc;
                //products = db.Products.Where(x => x.CategoryId == ).ToList();
                ShowPopup = true;
            }
            async Task Delete()
            {
                // Close the Popup
                ShowPopup = false;
                // Get the user
                var rc = await db.Departaments.FindAsync(departament.Id);
                if (rc != null)
                {
                    db.Departaments.Remove(rc);
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

                departament = new Departaments();
                LoadData();

                // Inititalize on page loaded

            }

            public void LoadData()
            {
                departaments = db.Departaments.OrderBy(x => x.Person).ToList();
                // initializers2 initializer= db.Initializers.OrderBy(x => x.PersonName).ToList(); double shit :)
            }



            private async Task Insert()
            {
                db.Departaments.Add(departament);
                await db.SaveChangesAsync();
                departaments.Add(departament);
                departament = new Departaments();
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591
