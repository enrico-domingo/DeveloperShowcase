#pragma checksum "C:\Users\enrico.domingo\source\repos\DeveloperShowcaseWeb\DeveloperShowcaseWeb\Views\Card\ShuffleCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "989887ec3faf29e021dc66c4cddb085b3d074b33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Card_ShuffleCard), @"mvc.1.0.view", @"/Views/Card/ShuffleCard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Card/ShuffleCard.cshtml", typeof(AspNetCore.Views_Card_ShuffleCard))]
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
#line 1 "C:\Users\enrico.domingo\source\repos\DeveloperShowcaseWeb\DeveloperShowcaseWeb\Views\_ViewImports.cshtml"
using DeveloperShowcaseWeb;

#line default
#line hidden
#line 2 "C:\Users\enrico.domingo\source\repos\DeveloperShowcaseWeb\DeveloperShowcaseWeb\Views\_ViewImports.cshtml"
using DeveloperShowcaseWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"989887ec3faf29e021dc66c4cddb085b3d074b33", @"/Views/Card/ShuffleCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37b5c262ff6ca8a66ff2df8462ddf44330dbeef4", @"/Views/_ViewImports.cshtml")]
    public class Views_Card_ShuffleCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CardModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\enrico.domingo\source\repos\DeveloperShowcaseWeb\DeveloperShowcaseWeb\Views\Card\ShuffleCard.cshtml"
  
    ViewData["Title"] = "ShuffleCard";

#line default
#line hidden
            BeginContext(72, 24, true);
            WriteLiteral("\r\n<h1>ShuffleCard</h1>\r\n");
            EndContext();
#line 7 "C:\Users\enrico.domingo\source\repos\DeveloperShowcaseWeb\DeveloperShowcaseWeb\Views\Card\ShuffleCard.cshtml"
 foreach (var t in Model)
{
    

#line default
#line hidden
            BeginContext(131, 6, false);
#line 9 "C:\Users\enrico.domingo\source\repos\DeveloperShowcaseWeb\DeveloperShowcaseWeb\Views\Card\ShuffleCard.cshtml"
Write(t.Type);

#line default
#line hidden
            EndContext();
            BeginContext(144, 7, false);
#line 10 "C:\Users\enrico.domingo\source\repos\DeveloperShowcaseWeb\DeveloperShowcaseWeb\Views\Card\ShuffleCard.cshtml"
Write(t.Value);

#line default
#line hidden
            EndContext();
#line 10 "C:\Users\enrico.domingo\source\repos\DeveloperShowcaseWeb\DeveloperShowcaseWeb\Views\Card\ShuffleCard.cshtml"
            
}

#line default
#line hidden
            BeginContext(156, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CardModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
