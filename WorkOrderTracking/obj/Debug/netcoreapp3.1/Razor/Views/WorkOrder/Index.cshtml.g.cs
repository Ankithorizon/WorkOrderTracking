#pragma checksum "C:\MVC-JQuery\WorkOrderTracking\Views\WorkOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b1e883ccb2e292e375de5e41d1b7b4b4e885bb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkOrder_Index), @"mvc.1.0.view", @"/Views/WorkOrder/Index.cshtml")]
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
#line 1 "C:\MVC-JQuery\WorkOrderTracking\Views\_ViewImports.cshtml"
using WorkOrderTracking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MVC-JQuery\WorkOrderTracking\Views\_ViewImports.cshtml"
using WorkOrderTracking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1e883ccb2e292e375de5e41d1b7b4b4e885bb8", @"/Views/WorkOrder/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f45be0d4b3a1a0f535323d4294e29beb03308cee", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 1 "C:\MVC-JQuery\WorkOrderTracking\Views\WorkOrder\Index.cshtml"
  
    ViewData["Title"] = "Work Order - Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Work Orders</h1>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b1e883ccb2e292e375de5e41d1b7b4b4e885bb83633", async() => {
                WriteLiteral("Create - [Work Order]");
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
            WriteLiteral(@"
</div>

<!-- this will hold partial view (modal) -->
<div id=""PlaceHolderHere""></div>

<hr />
<p></p>
<table id=""workOrdersTable""
       class=""table table-sm table-bordered table-striped""
       style=""width:100%"">
    <thead>
        <tr>
            <th>#</th>
            <th>Customer</th>
            <th>WO Start Date</th>
            <th>WO Status</th>
            <th>Status Note</th>
        </tr>
    </thead>
</table>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(document).ready(function () {

            var PlaceHolderElement = $('#PlaceHolderHere');

            var table = $('#workOrdersTable').DataTable({
                processing: true,
                ordering: true,
                paging: true,
                searching: true,
                ajax: ""WorkOrder/GetAllWorkOrders"",
                columns: [
                    { ""data"": ""workOrderId"" },
                    {
                        ""data"": ""null"", render: function (data, type, row) {//data
                            return ""<button type='button' id='btnCODetails' class='btn btn-link'>""+row.customer+""</a>"";
                        }
                    },
                    {
                        ""data"": ""workOrderStartDate"", render: function (data, type, row) {//data

                            if (row.workOrderStartDate == null) {
                                return 'No - Date';
                            } else");
                WriteLiteral(@" {
                                return moment(row.workOrderStartDate).format('DD MMM, YYYY');
                            }
                        }
                    },
                    { ""data"": ""workOrderStatus"" },
                    { ""data"": ""statusNote"" },
                  
                ],
            });


            // customer order details
            // get
            $('#workOrdersTable tbody').on('click', '[id*=btnCODetails]', function () {
                var data = table.row($(this).parents('tr')).data();
                console.log(data);
                var customerOrderId = data.customerOrderId;
                console.log(customerOrderId);
                var url = 'WorkOrder\\GetCustomerOrderDetails\\' + customerOrderId;
                $.get(url).done(function (data) {
                    // console.log(data);
                    PlaceHolderElement.html(data);
                    PlaceHolderElement.find('.modal').modal('show');
                });
");
                WriteLiteral("            });\r\n\r\n\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
