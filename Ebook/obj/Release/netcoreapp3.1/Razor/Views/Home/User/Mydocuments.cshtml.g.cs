#pragma checksum "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc17f4f0088a20585c3b9258ea49e5c8347b00f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_User_Mydocuments), @"mvc.1.0.view", @"/Views/Home/User/Mydocuments.cshtml")]
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
#line 1 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\_ViewImports.cshtml"
using Ebook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\_ViewImports.cshtml"
using Ebook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\_ViewImports.cshtml"
using Ebook.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc17f4f0088a20585c3b9258ea49e5c8347b00f4", @"/Views/Home/User/Mydocuments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e41db38901caa7ad4a8a3e952bc38543ed5da1b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_User_Mydocuments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ebook.Models.Entity.Document.DocumentInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "View", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container py-3 mx-auto mt-3 mb-45 \">\r\n    \r\n    <div class=\"col-12 mb-3\">\r\n        <div class=\"text-center\">\r\n            <h4>Documents</h4>\r\n        </div>\r\n    </div>\r\n    <div class=\"row justify-content-md-center\">\r\n\r\n");
#nullable restore
#line 18 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
         if (!Model.Any())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img loading=\"lazy\" width=\"auto\" src=\"/img/assets/empty.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 477, "\"", 483, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 21 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"

        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
             foreach (var document in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-auto"">
                    <div class=""item"">
                        <div class=""gallery"">
                            <div class=""hoverfx"">
                                <div class=""figure"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc17f4f0088a20585c3b9258ea49e5c8347b00f46622", async() => {
                WriteLiteral("<i class=\"icon fa fa-eye\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
                                                                               WriteLiteral(User.FindFirst(ClaimTypes.NameIdentifier).Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
                                                                                                                                               WriteLiteral(document.DocumentGroup.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"figure\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc17f4f0088a20585c3b9258ea49e5c8347b00f49948", async() => {
                WriteLiteral("<i class=\"icon fa fa-download\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
                                                                   WriteLiteral(User.FindFirst(ClaimTypes.NameIdentifier).Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
                                                                                                                                   WriteLiteral(document.DocumentGroup.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"price\">");
#nullable restore
#line 37 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
                                              Write(document.DocumentGroup.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" DT</div>\r\n\r\n                                <div class=\"overlay\">\r\n                                </div>\r\n                                <a target=\"_blank\"");
            BeginWriteAttribute("href", "  href=\"", 1625, "\"", 1660, 1);
#nullable restore
#line 41 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
WriteAttributeValue("", 1633, document.DocumentGroup.Url, 1633, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1704, "\"", 1757, 2);
            WriteAttributeValue("", 1710, "/img/document/", 1710, 14, true);
#nullable restore
#line 42 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
WriteAttributeValue("", 1724, document.DocumentGroup.CoverPage, 1724, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1758, "\"", 1801, 1);
#nullable restore
#line 42 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
WriteAttributeValue("", 1764, document.DocumentGroup.OriginalTitle, 1764, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"620\" height=\"450\">\r\n                                </a>\r\n    \r\n                            </div>\r\n\r\n                            \r\n\r\n                            <div class=\"desc\"><a   target=\"_blank\"");
            BeginWriteAttribute("href", "  href=\"", 2010, "\"", 2045, 1);
#nullable restore
#line 49 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
WriteAttributeValue("", 2018, document.DocumentGroup.Url, 2018, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
                                                                                                  Write(document.DocumentGroup.OriginalTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                        </div>\r\n                        \r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 54 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
                
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\User\Mydocuments.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWebHostEnvironment _webHostEnvironment { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor _httpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ebook.Models.Entity.Document.DocumentInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
