#pragma checksum "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22f76cc00a757049241f49e9b14b70662cd9c155"
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
#line 1 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/_ViewImports.cshtml"
using kwh;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22f76cc00a757049241f49e9b14b70662cd9c155", @"/Pages/Inventory/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acb38667fc91185887bcc079cebc0854c8deb1f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Inventory_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/Notepad-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("popover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/icons8-link-26.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary py-2 mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
  
    ViewData["Title"] = "Component Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22f76cc00a757049241f49e9b14b70662cd9c1556501", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <script src=\"https://cdn.jsdelivr.net/npm/chart.js@2.9.3/dist/Chart.bundle.min.js\"></script>\r\n    <title>Details</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22f76cc00a757049241f49e9b14b70662cd9c1557650", async() => {
                WriteLiteral(@"
    <div class=""text-center"">
        <br />
        <div class=""row justify-content-center"">
            <h4 class=""m-2 text-center"">Component Details</h4>
        </div>

        <div class=""row justify-content-center"">
            <div class=""w-75 bg-white m-3 rounded"">
                <canvas id=""priceChart"" />
            </div>
        </div>

        <div class=""row justify-content-center"">
            <p class=""text-center"">Zulu Time Zone is shown (UTC)</p>
        </div>
        <div class=""row justify-content-center"">
            <div class=""col-11"">
                <table class=""table border-hidden bg-white rounded"">
                    <thead>
                        <tr>
                            <th>
                                ");
#nullable restore
#line 39 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Component[0].PartNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 42 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Component[0].PartName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 45 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Component[0].Category));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 48 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Component[0].Vendor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 51 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Component[0].UnitCost));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 54 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Component[0].Notes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 57 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Component[0].Maturity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 60 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Component[0].Url));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 63 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Component[0].QuantityCurrent));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 66 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Component[0].QuantityNeeded));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 69 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Component[0].Project));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 72 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Component[0].AppUser));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </th>
                            <th>
                                Date Added/Modified
                            </th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 81 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                         foreach (var item in Model.Component)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 85 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.PartNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 88 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.PartName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 91 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 94 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Vendor.VendorName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 97 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.UnitCost));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22f76cc00a757049241f49e9b14b70662cd9c15516664", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                                                                                                                             Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-content", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 103 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Maturity.MaturityStatus));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 4691, "\"", 4707, 1);
#nullable restore
#line 106 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
WriteAttributeValue("", 4698, item.Url, 4698, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22f76cc00a757049241f49e9b14b70662cd9c15519636", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </a>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 111 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.QuantityCurrent));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 114 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.QuantityNeeded));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 117 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Project.ProjectName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 120 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.AppUser.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 123 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Timestamp));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 126 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"text-center m-3\">\r\n        <button class=\"btn btn-primary py-2 mb-4\" onclick=\"window.history.back()\">&larr; Back</button>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22f76cc00a757049241f49e9b14b70662cd9c15523646", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 135 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                                             WriteLiteral(Model.Component[0].Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
    $(""[data-toggle=popover]"").popover();

    //Line graph styling: https://www.chartjs.org/docs/latest/charts/line.html
    //Time Axis: https://www.chartjs.org/docs/latest/axes/cartesian/time.html
    Chart.defaults.global.legend.display = false;
    var ctx = document.getElementById('priceChart').getContext('2d');
    var tti = [");
#nullable restore
#line 147 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
          Write(Model.TimestampsList);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"];
    var LineChart = new Chart(ctx, {
        responsive: true, 
        type: 'line',
        data: {
            datasets: [{
                fill: false,
                borderColor: 'rgb(162, 202, 153)',
                pointBackgroundColor: 'rgb(162, 202, 153)', 
                borderWidth: 2,
                lineTension: 0.3,
                data: [");
#nullable restore
#line 158 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
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
                fontSize: 20,
                fontFamily: 'Helvetica',
                fontColor: '#272727',
                fontStyle: 'bold',
            },
            scales: {
                xAxes: [{
                    type: 'time',
                    offset: true,
                    scaleLabel: {
                        labelString: 'Time',
                        display: true
                    },
                    labels: tti,
                    time: {
                        parser: 'MM/DD/YYYY HH:mm',
                        format: ""MM/DD/YYYY HH:mm"",
                        displayFormats: {
                            millisecond: 'HH:mm',
                            second: 'HH:mm',
                            minute: 'HH:mm',
                            hour: 'HH:mm',
                            quarter: 'MMM YYYY'
           ");
            WriteLiteral(@"             }
                    },
                    ticks: {
                        maxTicksLimit: 10
                    }
                }],
                yAxes: [{
                    ticks: {
                        beginAtZero: true,
                        maxTicksLimit: 5,
                        callback: function (value) {
                            if (value.toString().length == 1) {
                                return '$' + value + '.00';
                            }
                            return '$' + value;
                        }
                    },
                    scaleLabel: {
                        labelString: '$ Cost',
                        display: true
                    }
                }]
            },
            tooltips: {
                callbacks: {
                    title: function (tooltipItem, data) {
                        return 'Date: ' + tti[tooltipItem[0].index];
                    },
                    label:");
            WriteLiteral(" function (tooltipItem, data) {\r\n                        return \"Unit Cost: $\" + tooltipItem.yLabel;\r\n                    }\r\n                }\r\n            }\r\n        }\r\n    });\r\n</script>");
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
