#pragma checksum "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d49b8b85f40e8f41c41bd4fdf1a42d1ced0a4593"
// <auto-generated/>
#pragma warning disable 1591
namespace HospitalsBlz.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/aigerim/Downloads/HospitalsBlz/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aigerim/Downloads/HospitalsBlz/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aigerim/Downloads/HospitalsBlz/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Downloads/HospitalsBlz/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/aigerim/Downloads/HospitalsBlz/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/aigerim/Downloads/HospitalsBlz/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/aigerim/Downloads/HospitalsBlz/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/aigerim/Downloads/HospitalsBlz/_Imports.razor"
using HospitalsBlz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/aigerim/Downloads/HospitalsBlz/_Imports.razor"
using HospitalsBlz.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
using HospitalsBlz.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
using HospitalsBlz.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/emppage")]
    public partial class EmpPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\">\r\n    <div class=\"col-md-4\"></div>\r\n    <div class=\"col-md-4\"><h4>Список сотрудников </h4></div>\r\n    <div class=\"col-md-4\"></div>\r\n</div>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-success");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                          AddNewUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "Добавить новый");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-striped");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<thead>\r\n        <tr>\r\n            <th>ФИО</th>\r\n            <th>Должность</th>\r\n            <th>Примечание</th>\r\n            <td></td>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 27 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
         foreach (var item in emps)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "            ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 30 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                     item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 31 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                     item.Positions.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 32 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                     item.Desc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddMarkupContent(25, "\r\n                    \r\n                    ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-primary");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                      (() => EditUser(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "\r\n                        Редактировать\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 41 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n");
#nullable restore
#line 45 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
 if (ShowPopup)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal");
            __builder.AddAttribute(39, "tabindex", "-1");
            __builder.AddAttribute(40, "style", "display:block");
            __builder.AddAttribute(41, "role", "dialog");
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "modal-dialog");
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal-content");
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "modal-header");
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.AddMarkupContent(52, "<h3 class=\"modal-title\">Редактирование</h3>\r\n                    ");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "close");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                      ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.AddMarkupContent(58, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "modal-body");
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.OpenElement(64, "span");
            __builder.AddAttribute(65, "style", "color:red");
            __builder.AddContent(66, 
#nullable restore
#line 58 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                             strError

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "table");
            __builder.AddAttribute(69, "class", "table");
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.OpenElement(71, "tr");
            __builder.AddMarkupContent(72, "\r\n                            ");
            __builder.AddMarkupContent(73, "<td>ФИО</td>\r\n                            ");
            __builder.OpenElement(74, "td");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "type", "text");
            __builder.AddAttribute(77, "class", "form-control");
            __builder.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                                                                emp.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.Name = __value, emp.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.OpenElement(82, "tr");
            __builder.AddMarkupContent(83, "\r\n                            ");
            __builder.AddMarkupContent(84, "<td>Должность</td>\r\n                            ");
            __builder.OpenElement(85, "td");
            __builder.AddMarkupContent(86, "\r\n                                ");
            __builder.OpenElement(87, "select");
            __builder.AddAttribute(88, "class", "form-control");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                                                     emp.PositionsId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.PositionsId = __value, emp.PositionsId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 68 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                     foreach (var cnt in positions)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                                        ");
            __builder.OpenElement(93, "option");
            __builder.AddAttribute(94, "value", 
#nullable restore
#line 70 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                                        cnt.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(95, 
#nullable restore
#line 70 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                                                 cnt.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 71 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                        ");
            __builder.OpenElement(101, "tr");
            __builder.AddMarkupContent(102, "\r\n                            ");
            __builder.AddMarkupContent(103, "<td>Примечание</td>\r\n                            ");
            __builder.OpenElement(104, "td");
            __builder.OpenElement(105, "input");
            __builder.AddAttribute(106, "type", "text");
            __builder.AddAttribute(107, "class", "form-control");
            __builder.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                                                                emp.Desc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => emp.Desc = __value, emp.Desc));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                        ");
            __builder.OpenElement(112, "tr");
            __builder.AddMarkupContent(113, "\r\n                            ");
            __builder.OpenElement(114, "td");
            __builder.AddMarkupContent(115, "\r\n");
#nullable restore
#line 81 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                 if (emp.Id != 0)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(116, "                                    \r\n                                    ");
            __builder.OpenElement(117, "button");
            __builder.AddAttribute(118, "class", "btn btn-danger");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                                                             DeleteUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(120, "\r\n                                        Удалить\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n");
#nullable restore
#line 87 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                            ");
            __builder.OpenElement(124, "td");
            __builder.AddMarkupContent(125, "\r\n                                ");
            __builder.OpenElement(126, "button");
            __builder.AddAttribute(127, "class", "btn btn-primary");
            __builder.AddAttribute(128, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
                                                                          SaveUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(129, "\r\n                                    Сохранить\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n");
#nullable restore
#line 101 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "/Users/aigerim/Downloads/HospitalsBlz/Pages/EmpPage.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    ApplicationUser objUser;
    string strError = "";
    bool ShowPopup = false;

    private List<Emp> emps = new List<Emp>();
    private List<Positions> positions = new List<Positions>();
    private Emp emp = new Emp();

    void AddNewUser()
    {
        emp = new Emp();
        emp.CreateDate = DateTime.Now;
        emp.ApplicationUserId = objUser.Id;
        emp.HospitalsId = objUser.HospitalsId;
        emp.Id = 0;
        ShowPopup = true;
    }
    async Task SaveUser()
    {
        try
        {
            // Is this an existing user?
            if (emp.Id != 0)
            {
                Emp employee = await db.Emp.FindAsync(emp.Id);
                employee.Name = emp.Name;
                employee.Desc = emp.Desc;
                employee.PositionsId = emp.PositionsId;
                await db.SaveChangesAsync();
            }
            else
            {
                db.Emp.Add(emp);
                await db.SaveChangesAsync();
            }

            // Close the Popup
            ShowPopup = false;
            // Refresh Users
            LoadData();
            emp = new Emp();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }
    async Task EditUser(Emp rc)
    {
        emp = rc;
        //products = db.Products.Where(x => x.CategoryId == ).ToList();
        ShowPopup = true;
    }
    async Task DeleteUser()
    {
        // Close the Popup
        ShowPopup = false;
        // Get the user
        var rc = await db.Emp.FindAsync(emp.Id);
        if (rc != null)
        {
            db.Emp.Remove(rc);
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
        positions = db.Positions.ToList();
        emp = new Emp();
        LoadData();
    }

    public void LoadData()
    {
        emps= db.Emp.Where(x => x.ApplicationUserId == objUser.Id).ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
    }
}
#pragma warning restore 1591
