#pragma checksum "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2440dff9ed406252db1158b70dccb794feb50e16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(kwh.Pages.Inventory.Pages_Inventory_Delete), @"mvc.1.0.razor-page", @"/Pages/Inventory/Delete.cshtml")]
namespace kwh.Pages.Inventory
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
#line 1 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/_ViewImports.cshtml"
using kwh;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2440dff9ed406252db1158b70dccb794feb50e16", @"/Pages/Inventory/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acb38667fc91185887bcc079cebc0854c8deb1f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Inventory_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
  
    ViewData["Title"] = "Delete Component";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2440dff9ed406252db1158b70dccb794feb50e165101", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Delete</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2440dff9ed406252db1158b70dccb794feb50e166147", async() => {
                WriteLiteral("\r\n    <br />\r\n    <div class=\"justify-content-center text-center\">\r\n        <h3>Are you sure you want to delete this?</h3>\r\n\r\n        <dl class=\"row justify-content-center text-center\">\r\n            <dt class=\"col-6 text-right\">\r\n                ");
#nullable restore
#line 22 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.ComponentId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-6 text-left\">\r\n                ");
#nullable restore
#line 25 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Component.ComponentId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-right\">\r\n                ");
#nullable restore
#line 28 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.PartNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-6 text-left\">\r\n                ");
#nullable restore
#line 31 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Component.PartNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-right\">\r\n                ");
#nullable restore
#line 34 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.PartName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-6 text-left\">\r\n                ");
#nullable restore
#line 37 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Component.PartName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-right\">\r\n                ");
#nullable restore
#line 40 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.Category));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-6 text-left\">\r\n                ");
#nullable restore
#line 43 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Component.Category.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-right\">\r\n                ");
#nullable restore
#line 46 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.Vendor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-6 text-left\">\r\n                ");
#nullable restore
#line 49 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Component.Vendor.VendorName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-right\">\r\n                ");
#nullable restore
#line 52 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.UnitCost));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-6 text-left\">\r\n                ");
#nullable restore
#line 55 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Component.UnitCost));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-right\">\r\n                ");
#nullable restore
#line 58 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.Notes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-6 text-left\">\r\n                ");
#nullable restore
#line 61 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Component.Notes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-right\">\r\n                ");
#nullable restore
#line 64 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.Maturity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-6 text-left\">\r\n                ");
#nullable restore
#line 67 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Component.Maturity.MaturityStatus));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-right\">\r\n                ");
#nullable restore
#line 70 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.Url));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-6 text-left\">\r\n                ");
#nullable restore
#line 73 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Component.Url));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-right\">\r\n                ");
#nullable restore
#line 76 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.QuantityCurrent));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-6 text-left\">\r\n                ");
#nullable restore
#line 79 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Component.QuantityCurrent));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-right\">\r\n                ");
#nullable restore
#line 82 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.QuantityNeeded));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-6 text-left\">\r\n                ");
#nullable restore
#line 85 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Component.QuantityNeeded));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-right\">\r\n                ");
#nullable restore
#line 88 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.Project));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-6 text-left\">\r\n                ");
#nullable restore
#line 91 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Component.Project.ProjectName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-right\">\r\n                ");
#nullable restore
#line 94 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.AppUser));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-6 text-left\">\r\n                ");
#nullable restore
#line 97 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Component.AppUser.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2440dff9ed406252db1158b70dccb794feb50e1616180", async() => {
                    WriteLiteral("\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2440dff9ed406252db1158b70dccb794feb50e1616457", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 102 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Component.ComponentId);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2440dff9ed406252db1158b70dccb794feb50e1618327", async() => {
                        WriteLiteral("Cancel");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<kwh.Pages.Inventory.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<kwh.Pages.Inventory.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<kwh.Pages.Inventory.DeleteModel>)PageContext?.ViewData;
        public kwh.Pages.Inventory.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
