#pragma checksum "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Product\OrderedProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab0e16c458d0ef30874f0b329f5da369fb633855"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_OrderedProducts), @"mvc.1.0.view", @"/Views/Product/OrderedProducts.cshtml")]
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
#line 1 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\_ViewImports.cshtml"
using Shop.BusinessLogic.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\_ViewImports.cshtml"
using Shop.Presentation.Web.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab0e16c458d0ef30874f0b329f5da369fb633855", @"/Views/Product/OrderedProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"663e2a0cefb8cb41d525881ff196224ed1405465", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_OrderedProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail default-img-size"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"header\">\r\n    <h1>Цена: ");
#nullable restore
#line 4 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Product\OrderedProducts.cshtml"
         Write(Model.Sum(x => x.Price).ToString("c", System.Globalization.CultureInfo.GetCultureInfo("Be")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n   \r\n</div>\r\n<div class=\"grid-items\">\r\n");
#nullable restore
#line 8 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Product\OrderedProducts.cshtml"
      
        foreach (var product in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card col-sm-4\">\r\n                <div class=\"card-body pb-0\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Product\OrderedProducts.cshtml"
                                      Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ab0e16c458d0ef30874f0b329f5da369fb6338555009", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Product\OrderedProducts.cshtml"
                  WriteLiteral(product.ImagePath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Product\OrderedProducts.cshtml"
AddHtmlAttributeValue("", 561, product.Name, 561, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 18 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Product\OrderedProducts.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <p>");
#nullable restore
#line 22 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Product\OrderedProducts.cshtml"
                  Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    <div class=\"edge-pressed\">\r\n                        <div class=\"horizontal-items\">\r\n                            <p class=\"ml-2\">");
#nullable restore
#line 26 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Product\OrderedProducts.cshtml"
                                       Write(product.Price.ToString("c", System.Globalization.CultureInfo.GetCultureInfo("Be")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n\r\n                        <div>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1082, "\"", 1140, 2);
            WriteAttributeValue("", 1089, "/Product/DeleteOrderedProduct?ProductId=", 1089, 40, true);
#nullable restore
#line 30 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Product\OrderedProducts.cshtml"
WriteAttributeValue("", 1129, product.Id, 1129, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                               class=\"btn btn-danger\">🧺</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 36 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Product\OrderedProducts.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"horizontal-center\">\r\n    <a href=\"/Product/PayOrderedProducts\" class=\"btn btn-success mr-2\">Купить</a>\r\n    <a href=\"#\" class=\"btn btn-primary\">Вверх</a>\r\n    <a href=\"/Category/GetAll\" class=\"btn btn-danger ml-2\">Назад</a>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ShopUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ShopUser> SignInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
