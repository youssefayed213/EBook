#pragma checksum "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b1f7e7ee1ab47662e5c360df360852ba25ff26b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart_Index), @"mvc.1.0.view", @"/Views/Home/Cart/Index.cshtml")]
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
#line 1 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b1f7e7ee1ab47662e5c360df360852ba25ff26b", @"/Views/Home/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e41db38901caa7ad4a8a3e952bc38543ed5da1b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
  
    ViewBag.Title = "Cart";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container py-3 mx-auto\" >\r\n\r\n    <div class=\"d-flex justify-content-center row \">\r\n\r\n        <div class=\"col-md-7\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b1f7e7ee1ab47662e5c360df360852ba25ff26b4722", async() => {
                WriteLiteral("\r\n\r\n            <div class=\"p-2\">\r\n                <h4>Shopping cart</h4>\r\n            </div>\r\n            \r\n");
#nullable restore
#line 19 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                 for (var i = 0; i < Enumerable.Count(ViewBag.cart); i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"d-flex flex-row justify-content-between align-items-center p-2 bg-white mt-4 px-2 rounded  border-bottom\">\r\n                        <div class=\"mr-1 book\">\r\n                            <img class=\"rounded book-img\"");
                BeginWriteAttribute("src", " src=\"", 710, "\"", 778, 2);
                WriteAttributeValue("", 716, "/img/document/", 716, 14, true);
#nullable restore
#line 23 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
WriteAttributeValue("", 730, ViewBag.cart[i].Product.DocumentGroup.CoverPage, 730, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 779, "\"", 785, 0);
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                        \r\n                        <div class=\"d-flex flex-column align-items-center product-details\"><span class=\"font-weight-bold\">");
#nullable restore
#line 25 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                                                                                                                     Write(ViewBag.cart[i].Product.DocumentGroup.OriginalTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\r\n                        </div>\r\n                        <div>\r\n                            <span class=\"font-weight-bold text-grey\">");
#nullable restore
#line 29 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                                                                 Write(ViewBag.cart[i].Product.DocumentGroup.Price * ViewBag.cart[i].Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(" DT</span>\r\n                        </div>\r\n                        <div class=\"d-flex align-items-center\"><a");
                BeginWriteAttribute("onclick", " onclick=\"", 1320, "\"", 1387, 3);
                WriteAttributeValue("", 1330, "RemoveFromCart(", 1330, 15, true);
#nullable restore
#line 31 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
WriteAttributeValue("", 1345, ViewBag.cart[i].Product.DocumentGroup.Id, 1345, 41, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1386, ")", 1386, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"cursor-p\"><i class=\"fa fa-trash mb-1 text-danger\"></i></a></div>\r\n                    </div>\r\n                    <input id=\"IntList@i\"");
                BeginWriteAttribute("name", " name=\"", 1531, "\"", 1549, 3);
                WriteAttributeValue("", 1538, "ListDoc[", 1538, 8, true);
#nullable restore
#line 33 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
WriteAttributeValue("", 1546, i, 1546, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1548, "]", 1548, 1, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1564, "\"", 1613, 1);
#nullable restore
#line 33 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
WriteAttributeValue("", 1572, ViewBag.cart[i].Product.DocumentGroup.Id, 1572, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
#nullable restore
#line 34 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        
                <div class="" border mt-4"">

                    <div class=""row m-auto"">
                        <div class=""col-10 col-md-7  m-auto"">
                            <div class=""bt-drop-in-wrapper mx-auto"">
                                <div id=""bt-dropin""></div>
                            </div>
                        </div>

                        <div class=""col-8 col-md-4 mx-auto mt-5"">
");
#nullable restore
#line 47 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                             foreach (var price in @ViewBag.cart)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"row d-flex justify-content-between px-3\">\r\n                                    <p class=\"mb-1 text-left\">");
#nullable restore
#line 50 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                                                         Write(price.Product.DocumentGroup.OriginalTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <h6 class=\"mb-1 text-right\">");
#nullable restore
#line 51 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                                                           Write(price.Product.DocumentGroup.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" DT</h6>\r\n                                </div>\r\n");
#nullable restore
#line 53 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            <div class=\"row d-flex justify-content-between px-3\" id=\"tax\">\r\n                                <p class=\"mb-1 text-left\">Total </p>\r\n                                <h6 class=\"mb-1 text-right\">");
#nullable restore
#line 58 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                                                       Write(ViewBag.total);

#line default
#line hidden
#nullable disable
                WriteLiteral(" DT</h6>\r\n                            </div>\r\n                            <div class=\"row d-flex justify-content-center px-3\" >\r\n\r\n");
#nullable restore
#line 62 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"hidden\" name=\"Nonce\" id=\"nonce\"/>\r\n                                <input type=\"hidden\" name=\"Total\" id=\"total\"");
                BeginWriteAttribute("value", " value=\"", 3202, "\"", 3224, 1);
#nullable restore
#line 66 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
WriteAttributeValue("", 3210, ViewBag.total, 3210, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                                <input type=\"hidden\" name=\"UserId\" id=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 3307, "\"", 3362, 1);
#nullable restore
#line 67 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
WriteAttributeValue("", 3315, User.FindFirstValue(ClaimTypes.NameIdentifier), 3315, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                                <button class=\"btn-block pay-button\" type=\"submit\"> <span> <span id=\"checkout\">Checkout</span> <span id=\"check-amt\">");
#nullable restore
#line 68 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                                                                                                                                               Write(ViewBag.total);

#line default
#line hidden
#nullable disable
                WriteLiteral(" DT</span> </span> </button>\r\n");
#nullable restore
#line 69 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <button class=\"btn-block pay-button btn-outline-\" type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3750, "\"", 3807, 3);
                WriteAttributeValue("", 3760, "location.href=\'", 3760, 15, true);
#nullable restore
#line 72 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
WriteAttributeValue("", 3775, Url.Action("Login", "Account"), 3775, 31, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3806, "\'", 3806, 1, true);
                EndWriteAttribute();
                WriteLiteral("> <span> <span id=\"checkout\">Login</span> <span id=\"check-amt\">");
#nullable restore
#line 72 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                                                                                                                                                                                                                   Write(ViewBag.total);

#line default
#line hidden
#nullable disable
                WriteLiteral(" DT</span> </span> </button>\r\n");
#nullable restore
#line 73 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>       \r\n    </div>\r\n</div>\r\n\r\n<script src=\"https://js.braintreegateway.com/web/dropin/1.22.0/js/dropin.min.js\"></script>\r\n\r\n\r\n<script>\r\n    let client_token = \"");
#nullable restore
#line 88 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Cart\Index.cshtml"
                   Write(ViewBag.ClientToken);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
    
    braintree.dropin.create({
        authorization: client_token,
        container: '#bt-dropin',
    }, function (createErr, instance) {
        document.querySelector('#payment-form').addEventListener('submit', function (event) {
            event.preventDefault();

            instance.requestPaymentMethod(function (err, payload) {
                if (err) {
                    return;
                }
                
                document.querySelector('#nonce').value = payload.nonce;
                let form = $('#payment-form').serialize();
                $.ajax({
                    type: ""POST"",
                    url: ""/Home/Create/"",
                    data: form,
                    success: function (data) {
                        if (data.data.success){
                      
                           setTimeout(function () {
                               window.location.href = '/Home/MyDocuments/'
                           },3000)
                 ");
            WriteLiteral(@"       }else{
                           setTimeout(function () {
                               window.location.href = '/Home/'
                           },3000)                            
                        }

                    }
                });
            });
            
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
