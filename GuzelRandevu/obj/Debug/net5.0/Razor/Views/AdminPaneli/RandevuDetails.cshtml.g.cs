#pragma checksum "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc460567fc59714b0d1cd8761dd72e6aca6f71c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPaneli_RandevuDetails), @"mvc.1.0.view", @"/Views/AdminPaneli/RandevuDetails.cshtml")]
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
#line 1 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\_ViewImports.cshtml"
using GuzelRandevu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\_ViewImports.cshtml"
using GuzelRandevu.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\_ViewImports.cshtml"
using GuzelRandevu.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc460567fc59714b0d1cd8761dd72e6aca6f71c9", @"/Views/AdminPaneli/RandevuDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa458cc8214f1dcdf8ceab643a609564142368d", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1058dda1f8b5306806396d30935f8919280fc563", @"/Views/AdminPaneli/_ViewImports.cshtml")]
    public class Views_AdminPaneli_RandevuDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GuzelRandevu.Models.Randevu>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RandevuIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
  
    ViewData["Title"] = "Randevu Detayları";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>Randevu Detayları</h5>\r\n\r\n<div>\r\n    <h4></h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Müşteri Adı Soyadı\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
       Write(Html.DisplayFor(model => model.uye.uyeAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
                                                   Write(Html.DisplayFor(model => model.uye.uyeSoyadi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Güzellik Merkezi\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
       Write(Html.DisplayFor(model => model.guzellikMerkezi.merkezAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.randevuDegerlendirmesi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n");
#nullable restore
#line 28 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
         if (DateTime.Now.Date < Model.randevuSaati)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-10\">\r\n                Gerçekleşmedi\r\n            </dd>\r\n");
#nullable restore
#line 33 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 37 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
           Write(Html.DisplayFor(model => model.randevuDegerlendirmesi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 39 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.randevuPuani));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n");
#nullable restore
#line 43 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
         if (DateTime.Now.Date < Model.randevuSaati)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-10\">\r\n                Gerçekleşmedi\r\n            </dd>\r\n");
#nullable restore
#line 48 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 52 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
           Write(Html.DisplayFor(model => model.randevuPuani));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 54 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.randevuSaati));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
       Write(Html.DisplayFor(model => model.randevuSaati));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.randevuTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
       Write(Html.DisplayFor(model => model.randevuTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 70 "C:\Users\Yıldız\Desktop\Yeni klasör (3)\GuzelRandevu\GuzelRandevu\Views\AdminPaneli\RandevuDetails.cshtml"
Write(Html.ActionLink("Düzenle", "RandevuEdit", new { merkezId = Model.merkezId, uyeId = Model.uyeId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc460567fc59714b0d1cd8761dd72e6aca6f71c910435", async() => {
                WriteLiteral("Randevu Listesine Geri Dön");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GuzelRandevu.Models.Randevu> Html { get; private set; }
    }
}
#pragma warning restore 1591
