#pragma checksum "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "388fb6cf6d51093c0eb4e37d809e2ca01a2f3f47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(scotusPages.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(scotusPages.Pages.Pages_Index), null)]
namespace scotusPages.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"388fb6cf6d51093c0eb4e37d809e2ca01a2f3f47", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74462937c7beed1e0c302dd269e2d8f3377df69d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 200, true);
            WriteLiteral("\r\n<!-- Navigation -->\r\n<div id=\"fh5co-main-nav-wrap\">\r\n    <div class=\"fh5co-nav-overlay\"></div>\r\n    <div class=\"fh5co-nav-inner\">\r\n        <ul id=\"fh5co-main-nav\">\r\n            <li class=\"active\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 271, "\"", 300, 1);
#line 12 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
WriteAttributeValue("", 278, Url.Content("/index"), 278, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(301, 34, true);
            WriteLiteral(">Home</a></li>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 335, "\"", 364, 1);
#line 13 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
WriteAttributeValue("", 342, Url.Content("/about"), 342, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(365, 1606, true);
            WriteLiteral(@">About</a></li>
            <li><a href=""portfolio.html"">Get Involved</a></li>
            <li><a href=""contact.html"">Contact</a></li>
        </ul>
        <ul class=""fh5co-social"">
            <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
            <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
            <li><a href=""#""><i class=""fa fa-instagram""></i></a></li>
            <li><a href=""#""><i class=""fa fa-linkedin""></i></a></li>
        </ul>
    </div>
</div>
<!-- Navigation -->
 <!-- Header -->
<header id=""fh5co-header"" role=""banner"">
    <a href=""#"" class=""js-fh5co-nav-toggle fh5co-nav-toggle fh5co-nav-white menu-controls""><i></i></a>
    <div id=""fh5co-logo"" class=""text-center""><h1 class=""stencil"">Take Back the Court</h1></div>
</header>
<!-- Header -->

<!-- Mobile Header -->
<header class=""mobile-header"" role=""banner"">
    <a href=""#"" class=""menu-controls fh5co-nav-toggle js-fh5co-nav-toggle""><i></i></a>
    <div class=""text-center""><h1 class=""logo stencil-sm");
            WriteLiteral(@"all"">Take Back the Court</h1></div>
</header>
<!-- Mobile Header-->

<div class=""container"">
    <div class=""row"" style=""min-height: 250px"">
        <div class=""scotus col-xs-12""></div>
    </div>
    <!-- Main -->
    <main role=""main"">
        <!-- Issue Areas -->
        <div id=""fh5co-crew"">
            <div class=""container"">
                <div class=""fh5co-section-heading"">
                    <h1 class=""stencil-med"">Issues Before the Court</h1>
                </div>

                <div class=""image-row"">
                    <div class=""column"">
");
            EndContext();
#line 55 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                         for(var i = 0; i < 3; i++)
                        {
                            var url = IndexModel.GetImages()[i].Item1;
                            var name = IndexModel.GetImages()[i].Item2;
                            var path = IndexModel.GetImages()[i].Item3;

#line default
#line hidden
            BeginContext(2267, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(2297, 17, true);
            WriteLiteral("<figure><a href=\"");
            EndContext();
            BeginContext(2315, 26, false);
#line 60 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                                          Write(Url.Page("./issues" + url));

#line default
#line hidden
            EndContext();
            BeginContext(2341, 34, true);
            WriteLiteral("\"><img class=\"img-responsive\" src=");
            EndContext();
            BeginContext(2376, 4, false);
#line 60 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                                                                                                       Write(path);

#line default
#line hidden
            EndContext();
            BeginContext(2380, 5, true);
            WriteLiteral(" alt=");
            EndContext();
            BeginContext(2386, 4, false);
#line 60 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                                                                                                                 Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(2390, 15, true);
            WriteLiteral("></a></figure>\n");
            EndContext();
#line 61 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2432, 70, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"column\">\r\n");
            EndContext();
#line 64 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                         for(var i = 3; i < 6; i++)
                        {
                            var url = IndexModel.GetImages()[i].Item1;
                            var name = IndexModel.GetImages()[i].Item2;
                            var path = IndexModel.GetImages()[i].Item3;

#line default
#line hidden
            BeginContext(2800, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(2830, 17, true);
            WriteLiteral("<figure><a href=\"");
            EndContext();
            BeginContext(2848, 26, false);
#line 69 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                                          Write(Url.Page("./issues" + url));

#line default
#line hidden
            EndContext();
            BeginContext(2874, 34, true);
            WriteLiteral("\"><img class=\"img-responsive\" src=");
            EndContext();
            BeginContext(2909, 4, false);
#line 69 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                                                                                                       Write(path);

#line default
#line hidden
            EndContext();
            BeginContext(2913, 5, true);
            WriteLiteral(" alt=");
            EndContext();
            BeginContext(2919, 4, false);
#line 69 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                                                                                                                 Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(2923, 19, true);
            WriteLiteral("></a></figure>   \r\n");
            EndContext();
#line 70 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2969, 70, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"column\">\r\n");
            EndContext();
#line 73 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                         for(var i = 6; i < 9; i++)
                        {
                            var url = IndexModel.GetImages()[i].Item1;
                            var name = IndexModel.GetImages()[i].Item2;
                            var path = IndexModel.GetImages()[i].Item3;

#line default
#line hidden
            BeginContext(3337, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(3367, 17, true);
            WriteLiteral("<figure><a href=\"");
            EndContext();
            BeginContext(3385, 26, false);
#line 78 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                                          Write(Url.Page("./issues" + url));

#line default
#line hidden
            EndContext();
            BeginContext(3411, 34, true);
            WriteLiteral("\"><img class=\"img-responsive\" src=");
            EndContext();
            BeginContext(3446, 4, false);
#line 78 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                                                                                                       Write(path);

#line default
#line hidden
            EndContext();
            BeginContext(3450, 5, true);
            WriteLiteral(" alt=");
            EndContext();
            BeginContext(3456, 4, false);
#line 78 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                                                                                                                 Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(3460, 16, true);
            WriteLiteral("></a></figure>\r\n");
            EndContext();
#line 79 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3503, 374, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
        <!-- Issue Areas -->
        <!-- Resources -->
        <div class=""container-fluid"">
            <div class=""fh5co-section-heading"">
                <h3 class=""stencil-med"">Learn more, get involved, and make change.</h3>
            </div>
            <div class=""row"">
");
            EndContext();
#line 91 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                 foreach(var r in IndexModel.GetResources())
                {
                    var url = r.Item1;
                    var title = r.Item2;
                    var text = r.Item3;


#line default
#line hidden
            BeginContext(4080, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(4102, 57, true);
            WriteLiteral("<div class=\"col-md-3 col-sm-6\">\r\n                        ");
            EndContext();
            BeginContext(4161, 64, true);
            WriteLiteral("<article class=\"fh5co-post-entry\">\r\n                            ");
            EndContext();
            BeginContext(4227, 89, true);
            WriteLiteral("<h3 class=\"fh5co-blog-title fh5co-heading-with-border\">\r\n                                ");
            EndContext();
            BeginContext(4318, 9, true);
            WriteLiteral("<a href=\"");
            EndContext();
            BeginContext(4328, 29, false);
#line 100 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                                      Write(Url.Page("./resources" + url));

#line default
#line hidden
            EndContext();
            BeginContext(4357, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(4360, 5, false);
#line 100 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                                                                      Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(4365, 39, true);
            WriteLiteral("</a> \r\n                                ");
            EndContext();
            BeginContext(4406, 82, true);
            WriteLiteral("<span class=\"fh5co-border fh5co-border-gray\"></span>\r\n                            ");
            EndContext();
            BeginContext(4490, 35, true);
            WriteLiteral("</h3>\r\n                            ");
            EndContext();
            BeginContext(4527, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(4531, 4, false);
#line 103 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                            Write(text);

#line default
#line hidden
            EndContext();
            BeginContext(4535, 30, true);
            WriteLiteral("</p>\r\n                        ");
            EndContext();
            BeginContext(4567, 32, true);
            WriteLiteral("</article>\r\n                    ");
            EndContext();
            BeginContext(4601, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 106 "/Users/macbook/Projects/scotusPages/Pages/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4627, 1518, true);
            WriteLiteral(@"            </div>
        </div>
        <!-- Resources -->
    </main>
    <!-- Main -->
</div>
<!-- Footer -->
<footer role=""contentinfo"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-2"">
                <h2 class=""fh5co-footer-title"">Get Involved</h2>
                <ul class=""fh5co-footer-links"">
                    <li><a href=""#"">Check your voter registration</a></li>
                    <li><a href=""#"">Call your respresentatives</a></li>
                    <li><a href=""#"">Option 3</a></li>
                    <li><a href=""#"">Option 4</a></li>
                </ul>
            </div>
            <div class=""col-md-2"">
                <h2 class=""fh5co-footer-title"">Connect</h2>
                <ul class=""fh5co-footer-links"">
                    <li><a href=""#"" class=""fh5co-link""><i class=""fa fa-twitter""></i>Twitter</a></li>
                    <li><a href=""#"" class=""fh5co-link""><i class=""fa fa-facebook-square""></i>Facebook</a></li>
      ");
            WriteLiteral(@"              <li><a href=""#"" class=""fh5co-link""><i class=""fa fa-github""></i>Github</a></li>
                    <li><a href=""#"" class=""fh5co-link""><i class=""fa fa-linkedin-square""></i>LinkedIn</a></li>
                    <li><a href=""#"" class=""fh5co-link""><i class=""fa fa-google""></i>Google Plus</a></li>
                </ul>
            </div>
        </div>
    </div>
</footer>
<!-- Footer -->
<!-- Go To Top -->
<a href=""#"" class=""fh5co-gotop""><i class=""ti-angle-up""></i></a>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
