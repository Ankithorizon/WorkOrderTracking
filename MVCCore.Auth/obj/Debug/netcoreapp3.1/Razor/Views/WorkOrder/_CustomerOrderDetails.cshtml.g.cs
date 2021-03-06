#pragma checksum "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\WorkOrder\_CustomerOrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b6996878a5f9ceaa7a1c34b40e625148d2c2d11"
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
#line 1 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\_ViewImports.cshtml"
using MVCCore.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\_ViewImports.cshtml"
using MVCCore.Auth.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b6996878a5f9ceaa7a1c34b40e625148d2c2d11", @"/Views/WorkOrder/_CustomerOrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac839b09ebec20598a531d11fe4a085c8ec9251", @"/Views/_ViewImports.cshtml")]
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
    .woNotFound {
        color: red;
        font-size: x-large;
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

");
#nullable restore
#line 32 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                 if (Model != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <h5>Customer Order # ");
#nullable restore
#line 35 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                                        Write(Model.CustomerOrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h5>Customer Name : ");
#nullable restore
#line 36 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                                       Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <span>Product : ");
#nullable restore
#line 37 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                                   Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <br />\r\n                        <span>Product Desc : ");
#nullable restore
#line 39 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                                        Write(Model.ProductDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <br />\r\n                        <h6 class=\"h6Text\">\r\n                            Order QTY : ");
#nullable restore
#line 42 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                                   Write(Model.OrderQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h6>\r\n                        <h6>Order Date : ");
#nullable restore
#line 44 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                                    Write(Model.OrderDate.Value.Date.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <h6 class=\"h6Text\">Order Due Date : ");
#nullable restore
#line 45 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                                                       Write(Model.OrderDueDate.Value.Date.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n");
#nullable restore
#line 47 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"container woNotFound\">\r\n                        Customer Order Details Not Found !\r\n                    </div>\r\n");
#nullable restore
#line 53 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\WorkOrder\_CustomerOrderDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

            <div class=""modal-footer"">
                <button data-dismiss=""modal"" 
                        id=""cancel"" 
                        class=""btn btn-default"" 
                        type=""button"">
                    Close
                </button>            
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
