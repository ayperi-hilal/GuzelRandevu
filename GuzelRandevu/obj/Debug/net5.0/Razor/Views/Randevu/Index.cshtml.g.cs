#pragma checksum "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\Randevu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b50ee5d0e07295a0cbb93147ef25c0c83c095d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Randevu_Index), @"mvc.1.0.view", @"/Views/Randevu/Index.cshtml")]
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
#line 1 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\_ViewImports.cshtml"
using GuzelRandevu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\_ViewImports.cshtml"
using GuzelRandevu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b50ee5d0e07295a0cbb93147ef25c0c83c095d1", @"/Views/Randevu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"973b5a7d959bdac9150681ff0d62b66816ca39b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Randevu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GuzelRandevu.Models.Randevu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\Randevu\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b50ee5d0e07295a0cbb93147ef25c0c83c095d13785", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\Randevu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.randevuGunu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\Randevu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.randevuSaati));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\Randevu\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.randevuPuani));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 28 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\Randevu\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 31 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\Randevu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.randevuGunu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 34 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\Randevu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.randevuSaati));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 37 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\Randevu\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.randevuPuani));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 40 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\Randevu\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 41 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\Randevu\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 42 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\Randevu\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 45 "C:\Users\Yıldız\Downloads\GuzelRandevu-master (1)\GuzelRandevu-master\GuzelRandevu\Views\Randevu\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GuzelRandevu.Models.Randevu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
