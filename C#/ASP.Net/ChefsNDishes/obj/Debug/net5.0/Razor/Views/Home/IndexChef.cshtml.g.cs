#pragma checksum "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\IndexChef.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f5a4881433cbae663ef4372d24f900d030c91de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexChef), @"mvc.1.0.view", @"/Views/Home/IndexChef.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f5a4881433cbae663ef4372d24f900d030c91de", @"/Views/Home/IndexChef.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexChef : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chef>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\IndexChef.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <div>    
        <h1 class=""display-4""><a href=""/"">Dishes</a> | Chefs</h1>
        <h3><a href=""/NewChef"">Add a Chef</a></h3>
    </div>

    <p>Check out our roster of Chefs!</p>

    <div class=""container"">
        <div class=""table-responsive"">
            <table class=""table table-striped table-bordered"" style=""width: 850px;"">
         <tr>
                    <th>Name</th>
                    <th>Age</th>
                    <th># of Dishes</th>
                </tr>
");
#nullable restore
#line 22 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\IndexChef.cshtml"
          
                    foreach(var c in ViewBag.All)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\IndexChef.cshtml"
                       Write(c.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\IndexChef.cshtml"
                                    Write(c.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\IndexChef.cshtml"
                       Write(Chef.CountAge(@c.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\IndexChef.cshtml"
                       Write(c.DishByChef.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\kylee\OneDrive\Documents\GitHub\Web-Fundamentals\C#\ASP.Net\ChefsNDishes\Views\Home\IndexChef.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chef> Html { get; private set; }
    }
}
#pragma warning restore 1591
