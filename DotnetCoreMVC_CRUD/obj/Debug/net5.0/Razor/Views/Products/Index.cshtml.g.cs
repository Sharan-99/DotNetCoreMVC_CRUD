#pragma checksum "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a0699ac9d9e691a98aad081bc16b59f32b6a60f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a0699ac9d9e691a98aad081bc16b59f32b6a60f", @"/Views/Products/Index.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DotnetCoreMVC_CRUD.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Products List</h2>\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Name</th>\r\n        <th>Price</th>\r\n        <th>Action</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Index.cshtml"
     foreach(var prod in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 18 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Index.cshtml"
                   Write(prod.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Index.cshtml"
                   Write(prod.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Index.cshtml"
                   Write(prod.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 22 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", "Products", new { id = prod.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 23 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", "Products", new { id = prod.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 24 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", "Products", new { id = prod.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DotnetCoreMVC_CRUD.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
