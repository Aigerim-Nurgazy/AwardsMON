#pragma checksum "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f750e8f3cc54821cc17adf2b52542d37fb62f7db"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 20 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
 if (!ShowPopup)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<div class=\"row\">\r\n        <div class=\"col-md-4\"></div>\r\n        <div class=\"col-md-4\"><h4>Приказы</h4></div>\r\n        <div class=\"col-md-4\"></div>\r\n    </div>\r\n    ");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "td");
            __builder.AddAttribute(8, "width", "30%");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "placeholder", "Поиск");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                                 item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item = __value, item));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            <td width=\"40%\"></td>\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddAttribute(16, "width", "30%");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-success");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                                                      AddNew

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "Добавить новый");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table table-striped");
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.AddMarkupContent(27, @"<thead>
            <tr>
                <th>ID</th>
                <th>Приказ </th>
                <th>Номер приказа</th>
                <th>Дата</th>
                <th></th>
                <th></th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(28, "tbody");
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 46 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
             foreach (var item in orders)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 49 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                         item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                    e => NavigateToOrderPage(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.AddContent(39, 
#nullable restore
#line 51 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                         item.OrderName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 54 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                         item.OrderCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 55 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                         item.OrderDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "td");
            __builder.AddMarkupContent(49, "\r\n                        \r\n                        ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "class", "btn btn-primary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                          (() => Edit(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "\r\n                            Редактировать\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 69 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 72 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(60, "\r\n\r\n");
#nullable restore
#line 75 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
 if (ShowPopup)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "    ");
            __builder.AddMarkupContent(62, "<div class=\"row\">\r\n        <div class=\"col-md-4\"></div>\r\n        <div class=\"col-md-4\"><h4>Редактирование</h4></div>\r\n        <div class=\"col-md-4\"></div>\r\n    </div>\r\n    ");
            __builder.OpenElement(63, "table");
            __builder.AddAttribute(64, "class", "table");
            __builder.AddMarkupContent(65, "\r\n\r\n        ");
            __builder.OpenElement(66, "tr");
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.AddMarkupContent(68, "<td>Приказ</td>\r\n            ");
            __builder.OpenElement(69, "td");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "type", "text");
            __builder.AddAttribute(72, "class", "form-control");
            __builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 86 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                                                order.OrderName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => order.OrderName = __value, order.OrderName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n        ");
            __builder.OpenElement(77, "tr");
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.AddMarkupContent(79, "<td>Номер приказа</td>\r\n            ");
            __builder.OpenElement(80, "td");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "type", "text");
            __builder.AddAttribute(83, "class", "form-control");
            __builder.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 91 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                                                order.OrderCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => order.OrderCode = __value, order.OrderCode));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n        ");
            __builder.OpenElement(88, "tr");
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.AddMarkupContent(90, "<td>Дата приказа</td>\r\n            ");
            __builder.OpenElement(91, "td");
            __Blazor.BlzMON.Pages.OrdersPage.TypeInference.CreateRadzenDatePicker_0(__builder, 92, 93, "d", 94, 
#nullable restore
#line 96 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                                                                         false

#line default
#line hidden
#nullable disable
            , 95, "false", 96, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, 
#nullable restore
#line 96 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                                                                                                      args => Change(args, "DatePicker", "MM/dd/yyyy")

#line default
#line hidden
#nullable disable
            ), 97, 
#nullable restore
#line 96 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                               order.OrderDate

#line default
#line hidden
#nullable disable
            , 98, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => order.OrderDate = __value, order.OrderDate)), 99, () => order.OrderDate);
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
            __builder.AddContent(103, "    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<Initializers>>(104);
            __builder.AddAttribute(105, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Initializers>>(
#nullable restore
#line 103 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                       initializers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 104 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 104 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 104 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "StartsWithText", "Поиск");
            __builder.AddAttribute(110, "ColumnWidth", "200px");
            __builder.AddAttribute(111, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(112, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(113);
                __builder2.AddAttribute(114, "Property", "Id");
                __builder2.AddAttribute(115, "Title", "ID");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(116, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(117);
                __builder2.AddAttribute(118, "Property", "Areak.AreaName");
                __builder2.AddAttribute(119, "Title", "Область");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(120, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(121);
                __builder2.AddAttribute(122, "Property", "PersonSurname");
                __builder2.AddAttribute(123, "Title", "ФИО");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(124, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(125);
                __builder2.AddAttribute(126, "Property", "Possition.PossName");
                __builder2.AddAttribute(127, "Title", "Должность");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(129);
                __builder2.AddAttribute(130, "Property", "Award.AwardName");
                __builder2.AddAttribute(131, "Title", "Награда");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(132, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Initializers>>(133);
                __builder2.AddAttribute(134, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Initializers>)((initializer) => (__builder3) => {
                    __builder3.AddMarkupContent(135, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(136);
                    __builder3.AddAttribute(137, "Icon", "delete");
                    __builder3.AddAttribute(138, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 113 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                                         args => Selected(initializer)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(139, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(140, "\r\n            \r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(141, "\r\n");
            __builder.AddContent(142, "    ");
            __builder.OpenElement(143, "table");
            __builder.AddAttribute(144, "class", "table table-striped");
            __builder.AddMarkupContent(145, "\r\n        ");
            __builder.AddMarkupContent(146, @"<thead>
            <tr>
                <th>ID</th>
                <th>Область</th>
                <th>ФИО</th>
                <th>Должность</th>
                <th>Награда</th>
                <th>Одобрение</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(147, "tbody");
            __builder.AddMarkupContent(148, "\r\n");
#nullable restore
#line 134 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
             foreach (var item in initializers)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(149, "                ");
            __builder.OpenElement(150, "tr");
            __builder.AddMarkupContent(151, "\r\n                    ");
            __builder.OpenElement(152, "td");
            __builder.AddContent(153, 
#nullable restore
#line 137 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                         item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n                    ");
            __builder.OpenElement(155, "td");
            __builder.AddContent(156, 
#nullable restore
#line 138 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                         item.Areak.AreaName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n                    ");
            __builder.OpenElement(158, "td");
            __builder.AddContent(159, 
#nullable restore
#line 139 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                         item.PersonSurname

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(160, " ");
            __builder.AddContent(161, 
#nullable restore
#line 139 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                             item.PersonName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(162, " ");
            __builder.AddContent(163, 
#nullable restore
#line 139 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                                              item.PersonPatronymic

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n                    ");
            __builder.OpenElement(165, "td");
            __builder.AddContent(166, 
#nullable restore
#line 140 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                         item.Possition.PossName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n                    ");
            __builder.OpenElement(168, "td");
            __builder.AddContent(169, 
#nullable restore
#line 141 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                         item.Award.AwardName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n                    ");
            __builder.AddMarkupContent(171, "<td>\r\n                        <input type=\"checkbox\">\r\n                        \r\n                    </td>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n");
#nullable restore
#line 147 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(173, "\r\n            ");
            __builder.OpenElement(174, "tr");
            __builder.AddMarkupContent(175, "\r\n                ");
            __builder.OpenElement(176, "td");
            __builder.AddMarkupContent(177, "\r\n");
#nullable restore
#line 151 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                     if (order.Id != 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(178, "\r\n                        ");
            __builder.OpenElement(179, "button");
            __builder.AddAttribute(180, "class", "btn btn-danger");
            __builder.AddAttribute(181, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 153 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                                                 Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(182, "\r\n                            Удалить\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n");
#nullable restore
#line 156 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(184, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(185, "\r\n                ");
            __builder.OpenElement(186, "td");
            __builder.AddMarkupContent(187, "\r\n                    ");
            __builder.OpenElement(188, "button");
            __builder.AddAttribute(189, "class", "btn btn-primary");
            __builder.AddAttribute(190, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 159 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
                                                              Save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(191, "\r\n                        Сохранить\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n");
#nullable restore
#line 166 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 168 "C:\Users\esept\Source\Repos\AwardsMON2\Pages\OrdersPage.razor"
       

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
            .ToList();
    }

    void AddNew()// Add new order
    {
        order = new Orders();
        order.Id = 0;
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
        ShowPopup = true;//open edit popup
    }

    async Task Delete()
    {
        // Close the Popup
        ShowPopup = false;
        // Get the user
        var rc = await db.Order.FindAsync(order.Id);
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

    // attach Init to Order
    private void Selected(Initializers init)
    {
        navigationManager.NavigateTo("Test/" + init.Id);
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
namespace __Blazor.BlzMON.Pages.OrdersPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDatePicker_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, System.Object __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<global::System.DateTime?> __arg3, int __seq4, global::System.Object __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "ShowTime", __arg1);
        __builder.AddAttribute(__seq2, "Utc", __arg2);
        __builder.AddAttribute(__seq3, "Change", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
