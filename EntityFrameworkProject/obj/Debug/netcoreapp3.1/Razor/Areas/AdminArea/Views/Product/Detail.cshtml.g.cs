#pragma checksum "C:\Users\hp\Desktop\bruh\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0521873f0d90fc440bc88e9d220c1eef6194e3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Product_Detail), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\bruh\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using EntityFrameworkProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\bruh\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using EntityFrameworkProject.ViewModels.SliderViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\bruh\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using EntityFrameworkProject.ViewModels.ProductViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Desktop\bruh\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using EntityFrameworkProject.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0521873f0d90fc440bc88e9d220c1eef6194e3d", @"/Areas/AdminArea/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b36d6cd12e0682ceffcf66c5befffe1d52b22b1", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminArea_Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Desktop\bruh\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container my-5\">\r\n    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            Category detail\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\hp\Desktop\bruh\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\Product\Detail.cshtml"
                            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">");
#nullable restore
#line 13 "C:\Users\hp\Desktop\bruh\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\Product\Detail.cshtml"
                            Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\hp\Desktop\bruh\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\Product\Detail.cshtml"
                            Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\hp\Desktop\bruh\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\Product\Detail.cshtml"
                            Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">\r\n");
#nullable restore
#line 17 "C:\Users\hp\Desktop\bruh\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\Product\Detail.cshtml"
                 foreach (var item in Model.ProductImages.Where(m=>m.IsMain))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0521873f0d90fc440bc88e9d220c1eef6194e3d5893", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 603, "~/img/", 603, 6, true);
#nullable restore
#line 19 "C:\Users\hp\Desktop\bruh\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 609, item.Image, 609, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\hp\Desktop\bruh\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\Product\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
