#pragma checksum "C:\MVC-JQuery\WorkOrderTracking\Views\WorkOrder\_CustomerOrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fbd9f0deadc2ef6e0213e32a812b3fea75b5268"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkOrder__CustomerOrderDetails), @"mvc.1.0.view", @"/Views/WorkOrder/_CustomerOrderDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fbd9f0deadc2ef6e0213e32a812b3fea75b5268", @"/Views/WorkOrder/_CustomerOrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f45be0d4b3a1a0f535323d4294e29beb03308cee", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkOrder__CustomerOrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EF.Core.Models.CustomerOrder>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .detailsModal{
        background-color:lightgreen;
    }
    .h6Text {
        color : red;
    }
</style>

<div class=""modal fade "" id=""detailsCO"">
    <div class=""modal-dialog"">
        <div class=""modal-content "">
            <div class=""modal-header detailsModal"">
                <h4 class=""modal-title"" id=""detailsCOLabel"">
                    Customer Order Details !!!
                </h4>            

                <button type=""button"" class=""close"" data-dismiss=""modal"">
                    <span>X</span>
                </button>
            </div>


            <div class=""modal-body"">
           
                <div>
                    <h5>Customer Order # ");
#nullable restore
#line 29 "C:\MVC-JQuery\WorkOrderTracking\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                                    Write(Model.CustomerOrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5>Customer Name : ");
#nullable restore
#line 30 "C:\MVC-JQuery\WorkOrderTracking\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                                   Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <span>Product : ");
#nullable restore
#line 31 "C:\MVC-JQuery\WorkOrderTracking\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                               Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <br />\r\n                    <span>Product Desc : ");
#nullable restore
#line 33 "C:\MVC-JQuery\WorkOrderTracking\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                                    Write(Model.ProductDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <br />\r\n                    <h6 class=\"h6Text\">\r\n                        Order QTY : ");
#nullable restore
#line 36 "C:\MVC-JQuery\WorkOrderTracking\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                               Write(Model.OrderQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h6>\r\n                    <h6>Order Date : ");
#nullable restore
#line 38 "C:\MVC-JQuery\WorkOrderTracking\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                                Write(Model.OrderDate.Value.Date.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h6 class=\"h6Text\">Order Due Date : ");
#nullable restore
#line 39 "C:\MVC-JQuery\WorkOrderTracking\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                                                   Write(Model.OrderDueDate.Value.Date.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                </div>               
            </div>


            <div class=""modal-footer"">
                <button data-dismiss=""modal"" id=""cancel"" class=""btn btn-default"" type=""button"">Close</button>            
            </div>
        </div>
    </div>
</div>













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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EF.Core.Models.CustomerOrder> Html { get; private set; }
    }
}
#pragma warning restore 1591
