#pragma checksum "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ab1944738df351f8d1039412233dc5b02bc10c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ab1944738df351f8d1039412233dc5b02bc10c4", @"/Views/Products/Details.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotnetCoreMVC_CRUD.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n<dl>\r\n    <dt>");
#nullable restore
#line 8 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Details.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd>");
#nullable restore
#line 9 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Details.cshtml"
   Write(Html.DisplayFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n    <dt>");
#nullable restore
#line 11 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Details.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd>");
#nullable restore
#line 12 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Details.cshtml"
   Write(Html.DisplayFor(Model => Model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n    <dt>");
#nullable restore
#line 14 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Details.cshtml"
   Write(Html.DisplayNameFor(Model => Model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd>");
#nullable restore
#line 15 "C:\Users\2091199\source\repos\DotnetCoreMVC_CRUD\DotnetCoreMVC_CRUD\Views\Products\Details.cshtml"
   Write(Html.DisplayFor(Model => Model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n</dl>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotnetCoreMVC_CRUD.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
