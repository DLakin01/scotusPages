#pragma checksum "/Users/macbook/Projects/scotusPages/Pages/Shared/_IssuePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae00f5764cae4c6fb94ed7902b7d6b01ecccf785"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(scotusPages.Pages.Shared.Pages_Shared__IssuePartial), @"mvc.1.0.razor-page", @"/Pages/Shared/_IssuePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Shared/_IssuePartial.cshtml", typeof(scotusPages.Pages.Shared.Pages_Shared__IssuePartial), null)]
namespace scotusPages.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/macbook/Projects/scotusPages/Pages/_ViewImports.cshtml"
using scotusPages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae00f5764cae4c6fb94ed7902b7d6b01ecccf785", @"/Pages/Shared/_IssuePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74462937c7beed1e0c302dd269e2d8f3377df69d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__IssuePartial : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/macbook/Projects/scotusPages/Pages/Shared/_IssuePartial.cshtml"
  
    //var issue = Model.;

#line default
#line hidden
            BeginContext(51, 35, true);
            WriteLiteral("\n<h1 class=\"stencil\">The Court and ");
            EndContext();
            BeginContext(87, 5, false);
#line 7 "/Users/macbook/Projects/scotusPages/Pages/Shared/_IssuePartial.cshtml"
                             Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(92, 8, true);
            WriteLiteral("</h1>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<string> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<string>)PageContext?.ViewData;
        public string Model => ViewData.Model;
    }
}
#pragma warning restore 1591
