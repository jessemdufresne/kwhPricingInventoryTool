<<<<<<< HEAD
#pragma checksum "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83129804b0012acdb34091420cb245a76004f72f"
=======
#pragma checksum "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d390b50770954ff1d9c1ae4bdbfc4cb92c5f2fc8"
>>>>>>> master
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(kwh.Pages.Inventory.Pages_Inventory_Details), @"mvc.1.0.razor-page", @"/Pages/Inventory/Details.cshtml")]
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
#line 1 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/_ViewImports.cshtml"
using kwh;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d390b50770954ff1d9c1ae4bdbfc4cb92c5f2fc8", @"/Pages/Inventory/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acb38667fc91185887bcc079cebc0854c8deb1f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Inventory_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
  
    ViewData["Title"] = "Component Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83129804b0012acdb34091420cb245a76004f72f4112", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d390b50770954ff1d9c1ae4bdbfc4cb92c5f2fc83757", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <script src=\"https://cdn.jsdelivr.net/npm/chart.js@2.9.3/dist/Chart.bundle.min.js\"></script>\r\n    <style>\r\n\r\n    </style>\r\n    <title>Details</title>\r\n");
>>>>>>> master
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
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83129804b0012acdb34091420cb245a76004f72f5159", async() => {
                WriteLiteral("\r\n\r\n    <div>\r\n        <h4>Component</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 22 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.PartNumber));
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d390b50770954ff1d9c1ae4bdbfc4cb92c5f2fc84941", async() => {
                WriteLiteral(@"
    <div>
        <h4>Component</h4>
        <hr />
        <div style=""width: 55%; margin-left: auto; margin-right: auto;"">
            <canvas id=""priceChart"" width=""500"" height=""400""></canvas>
        </div>
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 30 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].PartNumber));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 25 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayFor(model => model.Component.PartNumber));
=======
#line 33 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].PartName));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 28 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.PartName));
=======
#line 36 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].Category));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 31 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayFor(model => model.Component.PartName));
=======
#line 39 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].Vendor));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 34 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.Category));
=======
#line 42 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].UnitCost));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 37 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayFor(model => model.Component.Category.CategoryName));
=======
#line 45 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].Notes));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 40 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.Vendor));
=======
#line 48 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].Maturity));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 43 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayFor(model => model.Component.Vendor.VendorName));
=======
#line 51 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].Url));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 46 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.UnitCost));
=======
#line 54 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].QuantityCurrent));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 49 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayFor(model => model.Component.UnitCost));
=======
#line 57 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].QuantityNeeded));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 52 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.Notes));
=======
#line 60 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].Project));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 55 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayFor(model => model.Component.Notes));
=======
#line 63 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].Volunteer));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
<<<<<<< HEAD
#line 58 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.Maturity));
=======
#line 69 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                 foreach (var item in Model.Component)
                {
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
<<<<<<< HEAD
#line 61 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayFor(model => model.Component.Maturity.MaturityStatus));
=======
#line 73 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PartNumber));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
<<<<<<< HEAD
#line 64 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.Url));
=======
#line 76 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PartName));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
<<<<<<< HEAD
#line 67 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayFor(model => model.Component.Url));
=======
#line 79 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Category.CategoryName));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
<<<<<<< HEAD
#line 70 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.QuantityCurrent));
=======
#line 82 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Vendor.VendorName));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
<<<<<<< HEAD
#line 73 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayFor(model => model.Component.QuantityCurrent));
=======
#line 85 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UnitCost));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
<<<<<<< HEAD
#line 76 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.QuantityNeeded));
=======
#line 88 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Notes));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
<<<<<<< HEAD
#line 79 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayFor(model => model.Component.QuantityNeeded));
=======
#line 91 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Maturity.MaturityStatus));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
<<<<<<< HEAD
#line 82 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.Project));
=======
#line 94 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Url));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
<<<<<<< HEAD
#line 85 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayFor(model => model.Component.Project.ProjectName));
=======
#line 97 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.QuantityCurrent));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
<<<<<<< HEAD
#line 88 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Component.Volunteer));
=======
#line 100 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.QuantityNeeded));
>>>>>>> master

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
<<<<<<< HEAD
#line 91 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
           Write(Html.DisplayFor(model => model.Component.Volunteer.LastName));
=======
#line 103 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Project.ProjectName));
>>>>>>> master

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n<div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83129804b0012acdb34091420cb245a76004f72f14684", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "/Users/JesseDuFresne/Desktop/School/Project/branches/css/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                           WriteLiteral(Model.Component.ComponentId);
=======
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 106 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Volunteer.LastName));
>>>>>>> master

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
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
                WriteLiteral(" |\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83129804b0012acdb34091420cb245a76004f72f16945", async() => {
=======
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 109 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d390b50770954ff1d9c1ae4bdbfc4cb92c5f2fc815364", async() => {
>>>>>>> master
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            WriteLiteral(@"
</html>

<script>
    //Line graph styling: https://www.chartjs.org/docs/latest/charts/line.html
    //Time Axis: https://www.chartjs.org/docs/latest/axes/cartesian/time.html
    Chart.defaults.global.legend.display = false;
    var ctx = document.getElementById('priceChart').getContext('2d');
    var LineChart = new Chart(ctx, {
        type: 'line',
        data: {
            datasets: [{
                fill: false,
                borderColor: 'rgb(162, 202, 153)',
                borderWidth: 2,
                lineTension: 0.2,
                data: [");
#nullable restore
#line 132 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                  Write(Model.UnitCostList);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"]
            }]
        },
        options: {
            title: {
                display: true,
                text: 'Price History',
                fontSize: 16,
                fontFamily: 'Helvetica',
                fontColor: '#272727',
                fontStyle: 'bold',
            },
            scales: {
                xAxes: [{
                    type: 'time',
                    labels: [");
#nullable restore
#line 147 "/Users/audreykan/Documents/GitHub/pit/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                        Write(Model.TimestampsList);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"],
                    distribution: 'linear',
                    time: {
                        parser: 'MM/DD/YYYY hh:mm a',
                        unit: 'day',
                        tooltipFormat: 'll hh:mm a'
                    }
                }]
            }
        }
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<kwh.Pages.Inventory.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<kwh.Pages.Inventory.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<kwh.Pages.Inventory.DetailsModel>)PageContext?.ViewData;
        public kwh.Pages.Inventory.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
