#pragma checksum "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cdcf6ae644b70cd3572eb8bc2f7cafc6610a72d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search_Index), @"mvc.1.0.view", @"/Views/Home/Search/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cdcf6ae644b70cd3572eb8bc2f7cafc6610a72d", @"/Views/Home/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e41db38901caa7ad4a8a3e952bc38543ed5da1b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ebook.Models.Entity.Document.DocumentInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Home/Search/Search.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Search\Index.cshtml"
  
    ViewBag.Title = "Search";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<input type=\"hidden\" id=\"txtTheme\"");
            BeginWriteAttribute("value", " value=\"", 168, "\"", 204, 1);
#nullable restore
#line 10 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Search\Index.cshtml"
WriteAttributeValue("", 176, Context.Request.Query["id"], 176, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

<div class=""container "">
    <div class=""row extra-row m-auto"">
        <div class=""col-12 col-md-4"">
            <div class=""filter-book border mt-5 p-2"">    
                <span class=""title-filter"">FILTER BY</span>
                
                <div class=""col mb-3"">

                        <select class=""btn border w-100"" id=""sortType"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdcf6ae644b70cd3572eb8bc2f7cafc6610a72d5992", async() => {
                WriteLiteral("Sort by");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdcf6ae644b70cd3572eb8bc2f7cafc6610a72d7910", async() => {
                WriteLiteral("Name");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdcf6ae644b70cd3572eb8bc2f7cafc6610a72d9095", async() => {
                WriteLiteral("Date");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </select>\r\n                        \r\n                </div>\r\n");
#nullable restore
#line 27 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Search\Index.cshtml"
                 if (string.IsNullOrEmpty(Context.Request.Query["type"]))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col mb-3"">
                        <p>
                            <a class=""btn border w-100"" data-bs-toggle=""collapse"" href=""#collapseExample"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">
                                Document type
                            </a>
                        </p>
                        <div class=""collapse"" id=""collapseExample"">
                            <div class=""card card-body"">
                                <div class=""form-check"">
                                    <input class=""form-check-input documentTypeCheckbox"" type=""checkbox"" value=""Ebook"" id=""EBookChoice"" checked>
                                    <label class=""form-check-label"" for=""EBookChoice"">
                                        E-Book
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""for");
            WriteLiteral(@"m-check-input documentTypeCheckbox"" type=""checkbox"" value=""Ejournal"" id=""EJournalChoice"" checked>
                                    <label class=""form-check-label"" for=""EJournalChoice"">
                                        E-Journal
                                    </label>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 52 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Search\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col mb-3"">
                    <p>
                        <a class=""btn border w-100"" data-bs-toggle=""collapse"" href=""#PulisherExample"" role=""button"" aria-expanded=""false"" aria-controls=""PulisherExample"">
                            Publisher
                        </a>
                    </p>
                    <div class=""collapse"" id=""PulisherExample"">
                        <div class=""card card-body"" id=""PublisherList"">
                            
                        </div>
                    </div>
                </div>
                <div class=""col mb-3"">
                    <p>
                        <a class=""btn border w-100"" data-bs-toggle=""collapse"" href=""#Collectionxample"" role=""button"" aria-expanded=""false"" aria-controls=""Collectionxample"">
                            Collection
                        </a>
                    </p>
                    <div class=""collapse"" id=""Collectionxample"">
                        <div class=""car");
            WriteLiteral(@"d card-body"" id=""CollectionList"">
                            
                        </div>
                    </div>
                </div> 
                <div class=""col mb-3"">
                    <p>
                        <a class=""btn border w-100"" data-bs-toggle=""collapse"" href=""#AuthorExample"" role=""button"" aria-expanded=""false"" aria-controls=""AuthorExample"">
                            Author
                        </a>
                    </p>
                    <div class=""collapse"" id=""AuthorExample"">
                        <div class=""card card-body"" id=""AuthorList"">

                        </div>
                    </div>
                </div>
                <div class=""col mb-3"">
                    <p>
                        <a class=""btn border w-100"" data-bs-toggle=""collapse"" href=""#LanguageExample"" role=""button"" aria-expanded=""false"" aria-controls=""LanguageExample"">
                            Language
                        </a>
                    </p>");
            WriteLiteral(@"
                    <div class=""collapse"" id=""LanguageExample"">
                        <div class=""card card-body"">
                            <div class=""form-check"">
                                <input class=""form-check-input languageCheckbox"" type=""checkbox"" value=""English"" id=""EnglishLanguage"" checked>
                                <label class=""form-check-label"" for=""EnglishLanguage"">
                                    English
                                </label>
                            </div>
                            <div class=""form-check"">
                                <input class=""form-check-input languageCheckbox"" type=""checkbox"" value=""French"" id=""FrenchLanguage"" checked>
                                <label class=""form-check-label"" for=""FrenchLanguage"">
                                    French
                                </label>
                            </div>
                            <div class=""form-check"">
                                <inp");
            WriteLiteral(@"ut class=""form-check-input languageCheckbox"" type=""checkbox"" value=""Arabic"" id=""ArabicLanguage"" checked>
                                <label class=""form-check-label"" for=""ArabicLanguage"">
                                    Arabic
                                </label>
                            </div>
                            
                        </div>
                    </div>
                </div>
                
                <div class=""col mb-3"">
                    <p>
                        <a class=""btn border w-100"" data-bs-toggle=""collapse"" href=""#DateExample"" role=""button"" aria-expanded=""false"" aria-controls=""AuthorExample"">
                            Publication Date
                        </a>
                    </p>
                    <div class=""collapse"" id=""DateExample"">
                        <div class=""card card-body"" id=""DateList"">
                            
                        </div>
                    </div>
                </div>
 ");
            WriteLiteral(@"               
            </div>
            
        </div>
        <div class=""col-12 col-md-8"">
            <div class=""border mt-5 py-2 mb-5"" id=""SearchResult"">
            </div>
        </div>

    </div>
    
        

</div>
<script>var dataArr = ");
#nullable restore
#line 147 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Search\Index.cshtml"
                 Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdcf6ae644b70cd3572eb8bc2f7cafc6610a72d17328", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 148 "C:\Users\malek\OneDrive\سطح المكتب\EBook\Ebook\Ebook\Views\Home\Search\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
