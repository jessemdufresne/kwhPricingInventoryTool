#pragma checksum "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d9dbde8240d4e77ecf8fd63219237fe9091da26"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d9dbde8240d4e77ecf8fd63219237fe9091da26", @"/Pages/Inventory/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acb38667fc91185887bcc079cebc0854c8deb1f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Inventory_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d9dbde8240d4e77ecf8fd63219237fe9091da263427", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d9dbde8240d4e77ecf8fd63219237fe9091da264576", async() => {
                WriteLiteral(@"
    <div>
        <br />
        <h4 class=""m-3"">Component Details</h4>
        <div class=""w-90 bg-white m-5 rounded"">
            <canvas id=""priceChart"" />
        </div>
        <table class=""table border-hidden bg-white mb-0 mt-3"">
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 28 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].PartNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 31 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].PartName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 34 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].Category));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 37 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].Vendor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 40 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].UnitCost));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 43 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].Notes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 46 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].Maturity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 49 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].Url));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 52 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].QuantityCurrent));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 55 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].QuantityNeeded));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 58 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].Project));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 61 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Component[0].AppUser));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 67 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                 foreach (var item in Model.Component)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 71 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PartNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 74 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PartName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 77 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 80 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Vendor.VendorName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 83 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UnitCost));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 86 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 89 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Maturity.MaturityStatus));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 92 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Url));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 95 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.QuantityCurrent));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 98 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.QuantityNeeded));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 101 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Project.ProjectName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 104 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AppUser.Username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 107 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"text-center m-3\">\r\n        <button class=\"btn btn-primary py-2 mb-4\" onclick=\"window.history.back()\">&larr; Back</button>\r\n    </div>\r\n");
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
    var tti = [");
#nullable restore
#line 122 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
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
                borderWidth: 2,
                lineTension: 0.2,
                data: [");
#nullable restore
#line 132 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
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
                    labels: [");
#nullable restore
#line 147 "/Users/JesseDuFresne/Desktop/School/Project/branches/ui_fix/kwhPricingInventoryTool/kwh/Pages/Inventory/Details.cshtml"
                        Write(Model.TimestampsList);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"],
                    distribution: 'linear',
                    time: {
                        displayFormats: {
                            'day': 'MMM DD',
                            'week': 'll',
                            'month': 'MMM YYYY',
                            'year': 'YYYY',
                        },
                        parser: 'M/DD/YYYY hh:mm a',
                        minUnit: 'day'
                    }
                }],
                yAxes: [{
                    ticks: {
                        beginAtZero: true,
                        callback: function (value, index, values) {
                            if (value.toString().length == 1) {
                                return '$' + value + '.00';
                            }
                            return '$' + value;
                        }
                    }
                }]
            },
            tooltips: {
                callbacks: {
                    title: function ");
            WriteLiteral(@"(tooltipItem, data) {
                        console.log(tooltipItem);
                        return 'Date: ' + tti[tooltipItem[0].index];
                    },
                    label: function (tooltipItem, data) {
                        return ""Unit Cost: $"" + tooltipItem.yLabel;
                    }
                }
            }
        }
    });
</script>");
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
