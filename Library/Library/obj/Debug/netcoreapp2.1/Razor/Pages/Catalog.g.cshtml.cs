#pragma checksum "C:\Users\Lhnet\Downloads\EmpWebAppDev\Library\Library\Pages\Catalog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3da3a784b07ceb462d2c0cbaad637e8b6b317ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Library.Pages.Pages_Catalog), @"mvc.1.0.razor-page", @"/Pages/Catalog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Catalog.cshtml", typeof(Library.Pages.Pages_Catalog), null)]
namespace Library.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Lhnet\Downloads\EmpWebAppDev\Library\Library\Pages\_ViewImports.cshtml"
using Library;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3da3a784b07ceb462d2c0cbaad637e8b6b317ac", @"/Pages/Catalog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13cb157343b014b5f6c9df1addca9d9a937b38a6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Catalog : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-Controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "asset.Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(54, 425, true);
            WriteLiteral(@"<div id=""assets"">
    <h3>Library Catalog</h3>
    <div id=""assetsTable"">
        <table class=""table table-condense"" id=""catalogIndexTable"">
            <thread>
                <tr>
                    <th>Image</th>
                    <th>Title</th>
                    <th>Author / Director</th>
                    <th>Dewey Call Number</th>
                </tr>
            </thread>
            <tbody>
");
            EndContext();
#line 16 "C:\Users\Lhnet\Downloads\EmpWebAppDev\Library\Library\Pages\Catalog.cshtml"
                 foreach (var asset in Model.Assets)
                {

#line default
#line hidden
            BeginContext(552, 111, true);
            WriteLiteral("                    <tr class=\"assetRow\">\r\n                        <td class=\" \">\r\n                            ");
            EndContext();
            BeginContext(663, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f61909cc3154c80bf022dd5692ee0fe", async() => {
                BeginContext(735, 38, true);
                WriteLiteral("\r\n                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 773, "\"", 794, 1);
#line 21 "C:\Users\Lhnet\Downloads\EmpWebAppDev\Library\Library\Pages\Catalog.cshtml"
WriteAttributeValue("", 779, asset.ImageUrl, 779, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(795, 51, true);
                WriteLiteral(" class=\"imageCell\" />\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(850, 71, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\" \">");
            EndContext();
            BeginContext(922, 11, false);
#line 24 "C:\Users\Lhnet\Downloads\EmpWebAppDev\Library\Library\Pages\Catalog.cshtml"
                                 Write(asset.Title);

#line default
#line hidden
            EndContext();
            BeginContext(933, 45, true);
            WriteLiteral("</td>\r\n                        <td class=\" \">");
            EndContext();
            BeginContext(979, 22, false);
#line 25 "C:\Users\Lhnet\Downloads\EmpWebAppDev\Library\Library\Pages\Catalog.cshtml"
                                 Write(asset.AuthorOrDirector);

#line default
#line hidden
            EndContext();
            BeginContext(1001, 45, true);
            WriteLiteral("</td>\r\n                        <td class=\" \">");
            EndContext();
            BeginContext(1047, 21, false);
#line 26 "C:\Users\Lhnet\Downloads\EmpWebAppDev\Library\Library\Pages\Catalog.cshtml"
                                 Write(asset.DeweyCallNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1068, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Lhnet\Downloads\EmpWebAppDev\Library\Library\Pages\Catalog.cshtml"
                }

#line default
#line hidden
            BeginContext(1121, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Catalog.AssetIndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Library.Models.Catalog.AssetIndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Library.Models.Catalog.AssetIndexModel>)PageContext?.ViewData;
        public Library.Models.Catalog.AssetIndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591