#pragma checksum "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a59a4a90d4f890705be5655455210c9f6bea3d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebAppl.Pages.Pages_Search), @"mvc.1.0.razor-page", @"/Pages/Search.cshtml")]
namespace WebAppl.Pages
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
#line 1 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\_ViewImports.cshtml"
using WebAppl;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a59a4a90d4f890705be5655455210c9f6bea3d8", @"/Pages/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3fbdb61d14caac9630cc4a8d5efa5e89c70e682", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Search : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("application/x-www-form-urlencoded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:200px;width:200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Search</h1>\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a59a4a90d4f890705be5655455210c9f6bea3d85265", async() => {
                WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<style>
    * {
        box-sizing: border-box;
    }

    #myInput {
        background-image: url('/css/searchicon.png');
        background-position: 10px 12px;
        background-repeat: no-repeat;
        width: 100%;
        font-size: 16px;
        padding: 12px 20px 12px 40px;
        border: 1px solid #ddd;
        margin-bottom: 12px;
    }

    #myUL {
        list-style-type: none;
        padding: 0;
        margin: 0;
    }

        #myUL li a {
            border: 1px solid #ddd;
            margin-top: -1px; /* Prevent double borders */
            background-color: #f6f6f6;
            padding: 12px;
            text-decoration: none;
            font-size: 18px;
            color: black;
            display: block
        }

            #myUL li a:hover:not(.header) {
                background-color: #eee;
            }
</style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a59a4a90d4f890705be5655455210c9f6bea3d87201", async() => {
                WriteLiteral("\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a59a4a90d4f890705be5655455210c9f6bea3d87471", async() => {
                    WriteLiteral("\r\n        <input name=\"search\" placeholder=\"Search for\" />\r\n        <input type=\"submit\" value=\"search\" />\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <h2>Fisiere cu acest nume: ");
#nullable restore
#line 59 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
                          Write(Html.DisplayFor(model => Model.mediaResultByName.Count));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n");
#nullable restore
#line 60 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
     foreach (var item in Model.mediaResultByName)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 64 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
   Write(Html.DisplayFor(modelItem => item.Id_Media));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 67 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
   Write(Html.DisplayFor(modelItem => item.Media_name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 70 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
   Write(Html.DisplayFor(modelItem => item.Media_path));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a59a4a90d4f890705be5655455210c9f6bea3d811050", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1742, "~/PictureManager-DBPictures/", 1742, 28, true);
#nullable restore
#line 73 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
AddHtmlAttributeValue("", 1770, Html.ValueFor(modelItem=> item.Media_name), 1770, 43, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 76 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <h2>Fisiere cu acest tag: ");
#nullable restore
#line 77 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
                         Write(Html.DisplayFor(model => Model.mediaResultByTag.Count));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n");
#nullable restore
#line 78 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
     foreach (var item in Model.mediaResultByTag)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 82 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
   Write(Html.DisplayFor(modelItem => item.Id_Media));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 85 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
   Write(Html.DisplayFor(modelItem => item.Media_name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 88 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
   Write(Html.DisplayFor(modelItem => item.Media_path));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a59a4a90d4f890705be5655455210c9f6bea3d814848", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2292, "~/PictureManager-DBPictures/", 2292, 28, true);
#nullable restore
#line 91 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
AddHtmlAttributeValue("", 2320, Html.ValueFor(modelItem=> item.Media_name), 2320, 43, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 94 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <h2>Fisiere cu aceasta categorie: ");
#nullable restore
#line 95 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
                                 Write(Html.DisplayFor(model =>  Model.mediaResultByTagType.Count));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n");
#nullable restore
#line 96 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
     foreach ( var item in Model.mediaResultByTagType)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 100 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
   Write(Html.DisplayFor(modelItem => item.Id_Media));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 103 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
   Write(Html.DisplayFor(modelItem => item.Media_name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 106 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
   Write(Html.DisplayFor(modelItem => item.Media_path));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a59a4a90d4f890705be5655455210c9f6bea3d818675", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2859, "~/PictureManager-DBPictures/", 2859, 28, true);
#nullable restore
#line 109 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
AddHtmlAttributeValue("", 2887, Html.ValueFor(modelItem=> item.Media_name), 2887, 43, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 112 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("<h2>Fisiere cu acest Id: ");
#nullable restore
#line 113 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
                    Write(Html.DisplayFor(model =>  Model.mediaRezultById.Count));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n");
#nullable restore
#line 114 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
     foreach ( var item in Model.mediaRezultById)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 118 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
   Write(Html.DisplayFor(modelItem => item.Id_Media));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 121 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
   Write(Html.DisplayFor(modelItem => item.Media_name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 124 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
   Write(Html.DisplayFor(modelItem => item.Media_path));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a59a4a90d4f890705be5655455210c9f6bea3d822470", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3403, "~/PictureManager-DBPictures/", 3403, 28, true);
#nullable restore
#line 127 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
AddHtmlAttributeValue("", 3431, Html.ValueFor(modelItem=> item.Media_name), 3431, 43, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 130 "C:\Users\Amalia\Desktop\Ami\git Organize\laboratoare organizate TSP.NET git\Laborator-12-Proiect-3\Proiectul 3\WebAppl\Pages\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppl.SearchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAppl.SearchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAppl.SearchModel>)PageContext?.ViewData;
        public WebAppl.SearchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
