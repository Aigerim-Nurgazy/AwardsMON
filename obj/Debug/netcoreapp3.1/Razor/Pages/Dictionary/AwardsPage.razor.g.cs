#pragma checksum "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6441ba87ebc993f3c99be52526c384cdfedaad6"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
using BlzMON.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/awardspage")]
    public partial class AwardsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Награды</h3>\r");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-success");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                                          AddNew

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "Добавить новый");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r");
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<Awards>>(6);
            __builder.AddAttribute(7, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 10 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                                                         Radzen.FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                                                                                                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                                                                                                                                    4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Awards>>(
#nullable restore
#line 11 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                                       сonclusions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ColumnWidth", "150px");
            __builder.AddAttribute(14, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "\r        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Awards>>(16);
                __builder2.AddAttribute(17, "Property", "AwardName");
                __builder2.AddAttribute(18, "Title", "Награда");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\r        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Awards>>(20);
                __builder2.AddAttribute(21, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 15 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                                                    Radzen.TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Width", "60px");
                __builder2.AddAttribute(23, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Awards>)((сonclusion) => (__builder3) => {
                    __builder3.AddMarkupContent(24, "\r                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(25);
                    __builder3.AddAttribute(26, "Icon", "edit");
                    __builder3.AddAttribute(27, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                                                   args => Edit(сonclusion)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Awards>>(30);
                __builder2.AddAttribute(31, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 20 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                                                    Radzen.TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "Width", "60px");
                __builder2.AddAttribute(33, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Awards>)((сonclusion) => (__builder3) => {
                    __builder3.AddMarkupContent(34, "\r                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(35);
                    __builder3.AddAttribute(36, "Icon", "delete");
                    __builder3.AddAttribute(37, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                                                     args => Delete(сonclusion)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\r    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\r\r");
#nullable restore
#line 27 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
 if (ShowPopup){

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "modal");
            __builder.AddAttribute(44, "tabindex", "-1");
            __builder.AddAttribute(45, "style", "display:block");
            __builder.AddAttribute(46, "role", "dialog");
            __builder.AddMarkupContent(47, "\r        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "modal-dialog");
            __builder.AddMarkupContent(50, "\r            ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "modal-content");
            __builder.AddMarkupContent(53, "\r                ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "modal-header");
            __builder.AddMarkupContent(56, "\r                    ");
            __builder.OpenElement(57, "h3");
            __builder.AddAttribute(58, "class", "modal-title");
            __builder.AddContent(59, 
#nullable restore
#line 33 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                                             title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r                    ");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "type", "button");
            __builder.AddAttribute(63, "class", "close");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                                      ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "\r                        ");
            __builder.AddMarkupContent(66, "<span aria-hidden=\"true\">X</span>\r                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r                ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "modal-body");
            __builder.AddMarkupContent(71, "\r                    ");
            __builder.OpenElement(72, "span");
            __builder.AddAttribute(73, "style", "color:red");
            __builder.AddContent(74, 
#nullable restore
#line 40 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                                             strError

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r                    ");
            __builder.OpenElement(76, "table");
            __builder.AddAttribute(77, "class", "table");
            __builder.AddMarkupContent(78, "\r                       \r                        ");
            __builder.OpenElement(79, "tr");
            __builder.AddMarkupContent(80, "\r                            ");
            __builder.AddMarkupContent(81, "<td>Награда</td>\r                            ");
            __builder.OpenElement(82, "td");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "type", "text");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                                                                                сonclusion.AwardName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => сonclusion.AwardName = __value, сonclusion.AwardName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\r                        ");
            __builder.OpenElement(90, "tr");
            __builder.AddMarkupContent(91, "\r                            ");
            __builder.OpenElement(92, "td");
            __builder.AddMarkupContent(93, "\r                                ");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "class", "btn btn-primary");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
                                                                          Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(97, "\r                                    Сохранить\r                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r                            <td></td>\r                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\r        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r");
#nullable restore
#line 60 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\AwardsPage.razor"
           private List<Awards> сonclusions = new List<Awards>();    private Awards сonclusion = new Awards();    [CascadingParameter]    private Task<AuthenticationState> authenticationStateTask { get; set; }    System.Security.Claims.ClaimsPrincipal CurrentUser;    ApplicationUser objUser;    string strError = "";    string title = "";    bool ShowPopup = false;    void AddNew()    {        сonclusion = new Awards();        сonclusion.Id = 0;        title = "Новоя запись";        ShowPopup = true;    }    async Task Save()    {        try        {            if (сonclusion.Id != 0)            {                Awards lt = await db.Award.FindAsync(сonclusion.Id);                lt.Id = сonclusion.Id;                lt.AwardName = сonclusion.AwardName;                await db.SaveChangesAsync();            }            else            {                db.Award.Add(сonclusion);                await db.SaveChangesAsync();            }            ShowPopup = false;            LoadData();        }        catch (Exception ex)        {            strError = ex.GetBaseException().Message;        }    }    async Task Edit(Awards lt)    {        title = "Редактирование";        сonclusion = lt;        ShowPopup = true;    }    async Task Delete(Awards lt)    {        ShowPopup = false;        var obj = await db.Award.FindAsync(lt.Id);        if (obj != null)        {            db.Award.Remove(obj);            await db.SaveChangesAsync();        }        LoadData();    }    void ClosePopup()    {        ShowPopup = false;    }    protected override async Task OnInitializedAsync()    {        // CurrentUser = (await authenticationStateTask).User;        // objUser = await _userManager.FindByNameAsync(CurrentUser.Identity.Name);        LoadData();    }    public void LoadData()    {        сonclusion = new Awards();        сonclusions = db.Award.OrderBy(x => x.AwardName).ToList();    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591
