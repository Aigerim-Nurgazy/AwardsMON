#pragma checksum "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3a61b20992b21a8e3c54d62c7a2b2dc0387e028"
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
#line 19 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
using BlzMON.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/OrdersPage")]
    public partial class OrdersPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 365 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
       

    // list of inits
    public List<Initializers> initializers = new List<Initializers>();

    // For search inits
    private int CurrentValue { get; set; }
    public string itemValue { get; set; }

    //
    public string item
    {
        get { return itemValue; }
        set
        {
            CurrentValue = orders.Count();
            if (value.Length > 0)
            {
                orders = orders2.Where(x => x.OrderName.ToLower().Contains(value)).ToList();
            }
            else
            {
                orders = orders2;
            }
            itemValue = value;
        }
    }

    //
    private List<Orders> orders = new List<Orders>();
    private List<Orders> orders2 = new List<Orders>();
    private Orders order = new Orders();
    //authentication
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    ApplicationUser objUser;
    string strError = "";
    bool ShowPopup = false;//Close edit popup


    public void LoadData()//Load data of Order
    {
        //
        orders = db.Order
        .Include(o => o.InitiList)
        .Include(o => o.InitiList)
        .Include(o => o.InitiList)
        .Include(o => o.InitiList)
        .OrderBy(x => x.OrderName)
        .ToList();

        //
        initializers = db.Initializers
            .OrderBy(x => x.PersonSurname)
            .Include(o => o.Possition)
            .Include(o => o.Education)
            .Include(o => o.Areak)
            .Include(o => o.Award)
            .Include(o => o.Region)
            .ToList();
    }

    void AddNew()// Add new order
    {
        order = new Orders();
        order.Id = 0;
        order.OrderDate = DateTime.Now;

        ShowPopup = true;
        //regions = db.Region.ToList();
    }
    async Task Save()//Save data in edit popup
    {
        try
        {
            // Is this an existing user?
            if (order.Id != 0)
            {
                Orders ord = await db.Order.FindAsync(order.Id);
                ord.OrderName = order.OrderName;//Set in DB changes
                ord.OrderCode = order.OrderCode;
                ord.OrderDate = order.OrderDate;
                ord.InitiList = order.InitiList;

                await db.SaveChangesAsync();
            }
            else
            {
                //  int maxId = db.Order.Max(x => x.Id);
                //  order.Id = (maxId + 1);
                db.Order.Add(order);//Set in DB new order
                await db.SaveChangesAsync();
            }

            // attaching Inits to Orders
            foreach (int initId in attachedInits)
            {
                // find init and change order id
                Initializers init = db.Initializers.Find(initId);
                init.OrdersId = order.Id;
                // update
                db.Initializers.Update(init);


                System.Diagnostics.Debug.Print(init.GetFullName);
            }
            await db.SaveChangesAsync();

            // Close the Popup
            ShowPopup = false;
            // Refresh Users
            LoadData();
            order = new Orders();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }
    void Edit(Orders rc)//edit order
    {
        order = rc;//load data
                   //products = db.Products.Where(x => x.CategoryId == ).ToList();

        order.OrderDate = DateTime.Now;
        ShowPopup = true; //open edit popup
    }

    async Task Delete(int orderId)
    {
        // Close the Popup
        ShowPopup = false;
        // Get the user
        var rc = await db.Order.FindAsync(orderId);

        if (rc != null)
        {
            db.Order.Remove(rc);
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
        order = new Orders();
        LoadData();

    }


    private async Task Insert()//it havent used
    {
        db.Order.Add(order);
        await db.SaveChangesAsync();
        orders.Add(order);
        order = new Orders();
    }

    //For DateTime calender
    Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();
    void Change(DateTime? value, string name, string format)
    {
        events.Add(DateTime.Now, $"{name} value changed to {value?.ToString(format)}");
        StateHasChanged();
    }

    // Method to navigate order page without refreshing page
    private void NavigateToOrderPage(int orderId)
    {
        navigationManager.NavigateTo("OrderPage/" + orderId);
    }


    // attach or deattach Init to Order
    List<int> attachedInits = new List<int>();

    private void AttachInitToOrder(Initializers init)
    {
        if (!attachedInits.Contains(init.Id))
        {
            // add Init id to array, to use in Save
            attachedInits.Add(init.Id);
        }
        else
        {
            // remove Init id from array
            attachedInits.Remove(init.Id);
        }
    }


    // Details dialog
    bool isShowDetailsDialog = false;
    Initializers showDetailsInitializer = new Initializers();

    void ShowDetailsDialog(Initializers initializer)
    {
        isShowDetailsDialog = true;

        // get from database, becouse file names will updated after upload
        showDetailsInitializer = db.Initializers.Find(initializer.Id);
        // showDetailsInitializer = initializer;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewLocalizer Localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591
