#pragma checksum "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "182806095c5caddbe7779f87a165b33a46ef25d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182806095c5caddbe7779f87a165b33a46ef25d0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Dishes | <a href=""/Index"">Chefs</a></h1>
    <h3><a href=""/NewDish"">Add a Dish!</a></h3>
    <p>Yum, take a look at our tasty dishes</p>

    <div class=""container"">
        <div class=""table-responsive"">
            <table class=""table table-striped table-bordered"" style=""width: 850px;"">
                <tr>
                    <th>Name</th>
                    <th>Chef</th>
                    <th>Tastiness</th>
                    <th>Calories</th>
                </tr>");
#nullable restore
#line 19 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\Index.cshtml"
                          
                    foreach(var d in ViewBag.All)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\Index.cshtml"
                       Write(d.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 23 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\Index.cshtml"
                       Write(d.Cook.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\Index.cshtml"
                                         Write(d.Cook.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\Index.cshtml"
                       Write(d.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\Index.cshtml"
                       Write(d.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 27 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
