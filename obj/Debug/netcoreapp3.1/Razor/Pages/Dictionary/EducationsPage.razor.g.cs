#pragma checksum "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26ee2617d6f1066c8faed9f5297f1ecd32978e96"
// <auto-generated/>
#pragma warning disable 1591
namespace BlzMON.Pages.Dictionary
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
#line 3 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
using BlzMON.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
using BlzMON.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/educationpage")]
    public partial class EducationsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Образование</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-success");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                          AddNew

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "Добавить новый");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<Educations>>(6);
            __builder.AddAttribute(7, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 16 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                         Radzen.FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                                                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                                                                                    4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Educations>>(
#nullable restore
#line 17 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                       сonclusions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ColumnWidth", "150px");
            __builder.AddAttribute(14, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Educations>>(16);
                __builder2.AddAttribute(17, "Property", "EduName");
                __builder2.AddAttribute(18, "Title", "Образование");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Educations>>(20);
                __builder2.AddAttribute(21, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 22 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                        Radzen.TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Width", "60px");
                __builder2.AddAttribute(23, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Educations>)((сonclusion) => (__builder3) => {
                    __builder3.AddMarkupContent(24, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(25);
                    __builder3.AddAttribute(26, "Icon", "edit");
                    __builder3.AddAttribute(27, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                   args => Edit(сonclusion)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Educations>>(30);
                __builder2.AddAttribute(31, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 27 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                        Radzen.TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "Width", "60px");
                __builder2.AddAttribute(33, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Educations>)((сonclusion) => (__builder3) => {
                    __builder3.AddMarkupContent(34, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(35);
                    __builder3.AddAttribute(36, "Icon", "delete");
                    __builder3.AddAttribute(37, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                     args => Delete(сonclusion)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n\r\n\r\n");
#nullable restore
#line 37 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
 if (ShowPopup)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "modal");
            __builder.AddAttribute(44, "tabindex", "-1");
            __builder.AddAttribute(45, "style", "display:block");
            __builder.AddAttribute(46, "role", "dialog");
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "modal-dialog");
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "modal-content");
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "modal-header");
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "h3");
            __builder.AddAttribute(58, "class", "modal-title");
            __builder.AddContent(59, 
#nullable restore
#line 43 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                             title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "type", "button");
            __builder.AddAttribute(63, "class", "close");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                      ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.AddMarkupContent(66, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "modal-body");
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.OpenElement(72, "span");
            __builder.AddAttribute(73, "style", "color:red");
            __builder.AddContent(74, 
#nullable restore
#line 50 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                             strError

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                    ");
            __builder.OpenElement(76, "table");
            __builder.AddAttribute(77, "class", "table");
            __builder.AddMarkupContent(78, "\r\n\r\n                        ");
            __builder.OpenElement(79, "tr");
            __builder.AddMarkupContent(80, "\r\n                            ");
            __builder.AddMarkupContent(81, "<td>Должность</td>\r\n                            ");
            __builder.OpenElement(82, "td");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "type", "text");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                                сonclusion.EduName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => сonclusion.EduName = __value, сonclusion.EduName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n                        ");
            __builder.OpenElement(90, "tr");
            __builder.AddMarkupContent(91, "\r\n                            ");
            __builder.OpenElement(92, "td");
            __builder.AddMarkupContent(93, "\r\n                                ");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "class", "btn btn-primary");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
                                                                          Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(97, "\r\n                                    Сохранить\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                            <td></td>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
#nullable restore
#line 72 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Dictionary\EducationsPage.razor"
       

    private List<Educations> сonclusions = new List<Educations>();

    private Educations сonclusion = new Educations();

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    ApplicationUser objUser;
    string strError = "";
    string title = "";
    bool ShowPopup = false;


    void AddNew()
    {
        сonclusion = new Educations();
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
                Educations lt = await db.Education.FindAsync(сonclusion.Id);
                lt.Id = сonclusion.Id;
                lt.EduName = сonclusion.EduName;
                await db.SaveChangesAsync();
            }
            else
            {
                db.Education.Add(сonclusion);
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
    async Task Edit(Educations lt)
    {
        title = "Редактирование";
        сonclusion = lt;
        ShowPopup = true;
    }
    async Task Delete(Educations lt)
    {
        ShowPopup = false;
        var obj = await db.Education.FindAsync(lt.Id);
        if (obj != null)
        {
            db.Education.Remove(obj);
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
        сonclusion = new Educations();
        сonclusions = db.Education.OrderBy(x => x.EduName).ToList();

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591
