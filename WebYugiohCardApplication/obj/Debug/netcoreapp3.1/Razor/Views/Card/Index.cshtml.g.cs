#pragma checksum "D:\Programing\C#\source\repos\WebYugiohCardApplication\WebYugiohCardApplication\WebYugiohCardApplication\Views\Card\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cee2edef15aa1fd540bfada9d95abc7d9b6e9a32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Card_Index), @"mvc.1.0.view", @"/Views/Card/Index.cshtml")]
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
#line 1 "D:\Programing\C#\source\repos\WebYugiohCardApplication\WebYugiohCardApplication\WebYugiohCardApplication\Views\_ViewImports.cshtml"
using WebYugiohCardApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programing\C#\source\repos\WebYugiohCardApplication\WebYugiohCardApplication\WebYugiohCardApplication\Views\_ViewImports.cshtml"
using WebYugiohCardApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cee2edef15aa1fd540bfada9d95abc7d9b6e9a32", @"/Views/Card/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22e11277a7b7e49d59f546d8fca3f47980eb179a", @"/Views/_ViewImports.cshtml")]
    public class Views_Card_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebYugiohCardApplication.Models.ApiResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Programing\C#\source\repos\WebYugiohCardApplication\WebYugiohCardApplication\WebYugiohCardApplication\Views\Card\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>All Cards</h2>\r\n\r\n");
#nullable restore
#line 10 "D:\Programing\C#\source\repos\WebYugiohCardApplication\WebYugiohCardApplication\WebYugiohCardApplication\Views\Card\Index.cshtml"
 using (Html.BeginForm("Index", "Card", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 13 "D:\Programing\C#\source\repos\WebYugiohCardApplication\WebYugiohCardApplication\WebYugiohCardApplication\Views\Card\Index.cshtml"
   Write(Html.TextBox("Search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button class=\"btn btn-outline\" type=\"submit\">Search</button>\r\n    </p>\r\n");
#nullable restore
#line 16 "D:\Programing\C#\source\repos\WebYugiohCardApplication\WebYugiohCardApplication\WebYugiohCardApplication\Views\Card\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<img src=\"https://storage.googleapis.com/ygoprodeck.com/pics/46986414.jpg\" />\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebYugiohCardApplication.Models.ApiResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
