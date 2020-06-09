#pragma checksum "/Users/aigerim/Downloads/HospitalsBlz/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66dc05a53ab9a950cf2ee44f8259743ca1a471e5"
// <auto-generated/>
#pragma warning disable 1591
namespace HospitalsBlz.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>Мед.учреждения</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "/Users/aigerim/Downloads/HospitalsBlz/Shared/NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "/Users/aigerim/Downloads/HospitalsBlz/Shared/NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/Users/aigerim/Downloads/HospitalsBlz/Shared/NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "/Users/aigerim/Downloads/HospitalsBlz/Shared/NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Главная\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(28);
            __builder.AddAttribute(29, "Roles", "Admin, Normal");
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "li");
                __builder2.AddAttribute(33, "class", "nav-item px-3");
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
                __builder2.AddAttribute(36, "class", "nav-link");
                __builder2.AddAttribute(37, "href", "/hospitals/index");
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(39, "\r\n                    <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Учреждения\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenElement(42, "li");
                __builder2.AddAttribute(43, "class", "nav-item px-3");
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
                __builder2.AddAttribute(46, "class", "nav-link");
                __builder2.AddAttribute(47, "href", "categorypage");
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(49, "\r\n                    <span class=\"oi oi-grid-two-up\" aria-hidden=\"true\"></span> Категории\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.OpenElement(52, "li");
                __builder2.AddAttribute(53, "class", "nav-item px-3");
                __builder2.AddMarkupContent(54, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(55);
                __builder2.AddAttribute(56, "class", "nav-link");
                __builder2.AddAttribute(57, "href", "productpage");
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(59, "\r\n                    <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Ресурсы\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.OpenElement(62, "li");
                __builder2.AddAttribute(63, "class", "nav-item px-3");
                __builder2.AddMarkupContent(64, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(65);
                __builder2.AddAttribute(66, "class", "nav-link");
                __builder2.AddAttribute(67, "href", "userlist");
                __builder2.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(69, "\r\n                    <span class=\"oi oi-people\" aria-hidden=\"true\"></span> Пользователи\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n            ");
                __builder2.OpenElement(72, "li");
                __builder2.AddAttribute(73, "class", "nav-item px-3");
                __builder2.AddMarkupContent(74, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(75);
                __builder2.AddAttribute(76, "class", "nav-link");
                __builder2.AddAttribute(77, "href", "positionpage");
                __builder2.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(79, "\r\n                    <span class=\"oi oi-fork\" aria-hidden=\"true\"></span> Должности\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(82, "\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(83);
            __builder.AddAttribute(84, "Roles", "Manager");
            __builder.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(86, "\r\n            ");
                __builder2.OpenElement(87, "li");
                __builder2.AddAttribute(88, "class", "nav-item px-3");
                __builder2.AddMarkupContent(89, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(90);
                __builder2.AddAttribute(91, "class", "nav-link");
                __builder2.AddAttribute(92, "href", "departmentpage");
                __builder2.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(94, "\r\n                    <span class=\"oi oi-credit-card\" aria-hidden=\"true\"></span> Отделения\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(95, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.OpenElement(97, "li");
                __builder2.AddAttribute(98, "class", "nav-item px-3");
                __builder2.AddMarkupContent(99, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(100);
                __builder2.AddAttribute(101, "class", "nav-link");
                __builder2.AddAttribute(102, "href", "productcntpage");
                __builder2.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(104, "\r\n                    <span class=\"oi oi-aperture\" aria-hidden=\"true\"></span> Ресурсы\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n            ");
                __builder2.OpenElement(107, "li");
                __builder2.AddAttribute(108, "class", "nav-item px-3");
                __builder2.AddMarkupContent(109, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(110);
                __builder2.AddAttribute(111, "class", "nav-link");
                __builder2.AddAttribute(112, "href", "/emppage");
                __builder2.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(114, "\r\n                    <span class=\"oi oi-people\" aria-hidden=\"true\"></span> Сотрудники\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(117, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "/Users/aigerim/Downloads/HospitalsBlz/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
