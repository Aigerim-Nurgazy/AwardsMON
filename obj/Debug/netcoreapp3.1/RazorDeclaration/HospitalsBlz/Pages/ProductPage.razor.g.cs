#pragma checksum "/Users/aigerim/Downloads/HospitalsBlz/HospitalsBlz/Pages/ProductPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "485683356c572010ce7b1005edd3649f814a24f8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HospitalsBlz.HospitalsBlz.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 10 "/Users/aigerim/Downloads/HospitalsBlz/_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/aigerim/Downloads/HospitalsBlz/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/aigerim/Downloads/HospitalsBlz/HospitalsBlz/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aigerim/Downloads/HospitalsBlz/HospitalsBlz/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aigerim/Downloads/HospitalsBlz/HospitalsBlz/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Downloads/HospitalsBlz/HospitalsBlz/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/aigerim/Downloads/HospitalsBlz/HospitalsBlz/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/aigerim/Downloads/HospitalsBlz/HospitalsBlz/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/aigerim/Downloads/HospitalsBlz/HospitalsBlz/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/aigerim/Downloads/HospitalsBlz/HospitalsBlz/_Imports.razor"
using HospitalsBlz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/aigerim/Downloads/HospitalsBlz/HospitalsBlz/_Imports.razor"
using HospitalsBlz.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aigerim/Downloads/HospitalsBlz/HospitalsBlz/Pages/ProductPage.razor"
using HospitalsBlz.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Downloads/HospitalsBlz/HospitalsBlz/Pages/ProductPage.razor"
using HospitalsBlz.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productpage")]
    public partial class ProductPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "/Users/aigerim/Downloads/HospitalsBlz/HospitalsBlz/Pages/ProductPage.razor"
       

    private List<Product> products;
    private List<Category> categories;
    private Product product = new Product();

    private async Task InsertHospitals()
    {
        db.Products.Add(product);
        await db.SaveChangesAsync();
        products.Add(product);
        product = new Product();
    }
    string strError = "";
    bool ShowPopup = false;



    void AddNewUser()
    {
        product = new Product();
        product.Id = 0;
        ShowPopup = true;
    }
    async Task SaveUser()
    {
        try
        {
            // Is this an existing user?
            if (product.Id != 0)
            {
                // Get the user
                Product pos = await db.Products.FindAsync(product.Id);
                pos.Name = product.Name;
                pos.CategoryId = product.CategoryId;
                pos.Desc = product.Desc;
                await db.SaveChangesAsync();
            }
            else
            {
                db.Products.Add(product);
                await db.SaveChangesAsync();
            }

            // Close the Popup
            ShowPopup = false;
            // Refresh Users
            LoadData();
            product = new Product();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }
    async Task EditUser(Product rc)
    {
        product = rc;
        //products = db.Products.Where(x => x.CategoryId == ).ToList();
        ShowPopup = true;
    }
    async Task DeleteUser()
    {
        // Close the Popup
        ShowPopup = false;
        // Get the user
        var rc = await db.Products.FindAsync(product.Id);
        if (rc != null)
        {
            db.Products.Remove(rc);
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
        LoadData();
    }

    public void LoadData()
    {
        categories = db.Categories.ToList();
        products = db.Products.ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
    }
}
#pragma warning restore 1591
