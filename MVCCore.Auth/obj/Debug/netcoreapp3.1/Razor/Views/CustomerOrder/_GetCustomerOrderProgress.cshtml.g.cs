#pragma checksum "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a6bf21b96d845cdef68a03dc45dbe5a1249d9ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerOrder__GetCustomerOrderProgress), @"mvc.1.0.view", @"/Views/CustomerOrder/_GetCustomerOrderProgress.cshtml")]
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
#line 1 "C:\MVC-JQuery\MVCCore.Auth\Views\_ViewImports.cshtml"
using MVCCore.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MVC-JQuery\MVCCore.Auth\Views\_ViewImports.cshtml"
using MVCCore.Auth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
using EF.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a6bf21b96d845cdef68a03dc45dbe5a1249d9ba", @"/Views/CustomerOrder/_GetCustomerOrderProgress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac839b09ebec20598a531d11fe4a085c8ec9251", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerOrder__GetCustomerOrderProgress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EF.Core.DTO.CustomerOrderProgress>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .coProgressModal {
        background-color: lightgreen;
    }
    .modalWindow {
        max-width: 75% !important;
    }
    .daysLeftSpan{
        color : red;
        font-size: large;
    }
    .notAV {
        color: red;
        font-size: x-large;
    }
    .oprActivityTr {
        margin-left: 100px;
        color: brown;
        border: 2px solid brown;
    }
    .oprActivityTh {
        margin-left: 100px;
        color: brown;
        border: 2px solid brown;
    }
    .opTr{
        color:blue;
    }
    .trEmpty{
        height:50px;
    }
</style>

<div class=""modal fade "" id=""coProgress"">
    <div class=""modal-dialog modalWindow"">
        <div class=""modal-content "">
            <div class=""modal-header coProgressModal"">
                <h4 class=""modal-title"" id=""coProgressLabel"">
                    Customer Order Progress
                </h4>            

                <button type=""button"" class=""close"" data-dismiss=""modal"">
      ");
            WriteLiteral("              <span>X</span>\r\n                </button>\r\n            </div>\r\n\r\n\r\n            <div class=\"modal-body\">\r\n");
#nullable restore
#line 52 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                 if (Model.CustomerOrder != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <h4><u>Customer Order</u></h4>\r\n                        <h5>Customer Order # ");
#nullable restore
#line 56 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                        Write(Model.CustomerOrder.CustomerOrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h5>Customer Name : ");
#nullable restore
#line 57 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                       Write(Model.CustomerOrder.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <span>Order QTY : ");
#nullable restore
#line 58 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                     Write(Model.CustomerOrder.OrderQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <br />\r\n                        <span>Order Date : ");
#nullable restore
#line 60 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                      Write(Model.CustomerOrder.OrderDate.Value.Date.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <br />\r\n                        <span>Order Due Date : ");
#nullable restore
#line 62 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                          Write(Model.CustomerOrder.OrderDueDate.Value.Date.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <br />\r\n");
#nullable restore
#line 64 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                          
                            System.TimeSpan diffResult = (Model.CustomerOrder.OrderDueDate.Value.Date - DateTime.Now.Date);

                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"daysLeftSpan\">\r\n                            Days Left : ");
#nullable restore
#line 69 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                   Write(diffResult.Days);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                    <hr />\r\n");
#nullable restore
#line 73 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                     if (Model.WorkOrder != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            <h4><u>Work-Order</u></h4>\r\n                            <h5>Work Order # ");
#nullable restore
#line 77 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                        Write(Model.WorkOrder.WorkOrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <h5>Work Order Status : ");
#nullable restore
#line 78 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                               Write(Model.WorkOrder.WorkOrderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 79 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                               
                                string woStartDate = null;
                                if (Model.WorkOrder.WorkOrderStartDate != null) {
                                    woStartDate = Model.WorkOrder.WorkOrderStartDate.Value.Date.ToString("dd-MMM-yyyy");
                                }
                                else
                                {
                                    woStartDate = "N/A";
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>Work Order Start Date : ");
#nullable restore
#line 89 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                                     Write(woStartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <br />\r\n");
#nullable restore
#line 92 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                         if (Model.OperationDatas.Count() > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <h4><u>Operations</u></h4>
                            <table class=""table"" id=""operationsTable"">
                                <thead>
                                    <tr>
                                        <th>
                                            #
                                        </th>
                                        <th>
                                            Operation
                                        </th>
                                        <th>
                                            Start Date
                                        </th>
                                        <th>
                                            Qty Done
                                        </th>
                                        <th>
                                            Qty Required
                                        </th>
                                    </tr>
                                </t");
            WriteLiteral("head>\r\n                                <tbody>\r\n");
#nullable restore
#line 116 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                     foreach (var item in Model.OperationDatas)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"opTr\">\r\n");
#nullable restore
#line 119 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                         if (item.Operation.OpQTYDone >= item.Operation.OpQTYRequired)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>\r\n                                                <i class=\"fa fa-check\" aria-hidden=\"true\"></i>\r\n                                                ");
#nullable restore
#line 123 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                           Write(item.Operation.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n");
#nullable restore
#line 125 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>\r\n                                                ");
#nullable restore
#line 129 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                           Write(item.Operation.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n");
#nullable restore
#line 131 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            <span>\r\n");
#nullable restore
#line 134 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                                  
                                                    var opNumber = "";
                                                    if (@item.Operation.OperationNumber == (int)OperationNumber.Spindle)
                                                    {
                                                        opNumber = "Spindle - 10";
                                                    }
                                                    if (@item.Operation.OperationNumber == (int)OperationNumber.Hub_Single_Head)
                                                    {
                                                        opNumber = "Hub_Single_Head - 20";
                                                    }
                                                    if (@item.Operation.OperationNumber == (int)OperationNumber.Hub_Double_Head)
                                                    {
                                                        opNumber = "Hub_Double_Head - 30";
                                                    }
                                                    if (@item.Operation.OperationNumber == (int)OperationNumber.Push_Cups)
                                                    {
                                                        opNumber = "Push_Cups - 40";
                                                    }
                                                    if (@item.Operation.OperationNumber == (int)OperationNumber.Assembly_Spindle_Hub)
                                                    {
                                                        opNumber = "Assembly_Spindle_Hub - 50";
                                                    }
                                                    if (@item.Operation.OperationNumber == (int)OperationNumber.Paint)
                                                    {
                                                        opNumber = "Paint - 60";
                                                    }
                                                    if (@item.Operation.OperationNumber == (int)OperationNumber.Packaging)
                                                    {
                                                        opNumber = "Packaging - 70";
                                                    }
                                                    if (@item.Operation.OperationNumber == (int)OperationNumber.Rework_Spindle)
                                                    {
                                                        opNumber = "Rework_Spindle - 80";
                                                    }
                                                    if (@item.Operation.OperationNumber == (int)OperationNumber.Rework_Hub)
                                                    {
                                                        opNumber = "Rework_Hub - 90";
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
#nullable restore
#line 173 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                           Write(opNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                <br />\r\n                                                ");
#nullable restore
#line 175 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                           Write(item.Operation.OperationStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>                                            \r\n                                        </td>\r\n");
#nullable restore
#line 178 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                          
                                            var opStartDate = "";
                                            if (item.Operation.OperationStartDate != null)
                                            {
                                                opStartDate = item.Operation.OperationStartDate.Value.ToString("dd, MMM");
                                            }
                                            else
                                            {
                                                opStartDate = "N/A";
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            ");
#nullable restore
#line 190 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                       Write(opStartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n");
#nullable restore
#line 193 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                          
                                            var opQtyDn = "";
                                            if (item.Operation.OpQTYDone != null)
                                            {
                                                opQtyDn = item.Operation.OpQTYDone.ToString();
                                            }
                                            else
                                            {
                                                opQtyDn = "N/A";
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            ");
#nullable restore
#line 205 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                       Write(opQtyDn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n");
#nullable restore
#line 208 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                          
                                            var opQtyReq = "";
                                            if (item.Operation.OpQTYRequired != null)
                                            {
                                                opQtyReq = item.Operation.OpQTYRequired.ToString();
                                            }
                                            else
                                            {
                                                opQtyReq = "N/A";
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            ");
#nullable restore
#line 220 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                       Write(opQtyReq);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 224 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                         if (item.OperationHistory != null && item.OperationHistory.Count() > 0)
                                        {                                          

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <tr class=""oprActivityTh"">
                                                <th>Operator</th>
                                                <th>Operation</th>
                                                <th>Qty Done</th>
                                                <th>Start Time</th>
                                                <th>Pause Time</th>
                                                <th>Cycle Time</th>
                                            </tr>
");
#nullable restore
#line 236 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                             foreach (var opH in item.OperationHistory)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr class=\"oprActivityTr\">\r\n                                                    <td>\r\n                                                        # ");
#nullable restore
#line 240 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                                     Write(opH.OperatorId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ] ");
#nullable restore
#line 240 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                                                       Write(opH.Operator.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        <span>\r\n                                                            ");
#nullable restore
#line 244 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                                       Write(opH.OperationStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </span>\r\n                                                    </td>\r\n");
#nullable restore
#line 247 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                                      
                                                        var opQtyDone = "";
                                                        if (opH.OpQtyDone != null)
                                                        {
                                                            opQtyDone = opH.OpQtyDone.ToString();
                                                        }
                                                        else
                                                        {
                                                            opQtyDone = "N/A";
                                                        }
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>\r\n                                                        ");
#nullable restore
#line 259 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                                   Write(opQtyDone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n\r\n");
#nullable restore
#line 262 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                                      
                                                        var opStartTime = "";
                                                        if (opH.OpStartRunTime != null)
                                                        {
                                                            opStartTime = opH.OpStartRunTime.Value.ToString("dd, MMM hh:mm tt");
                                                        }
                                                        else
                                                        {
                                                            opStartTime = "N/A";
                                                        }
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>\r\n                                                        ");
#nullable restore
#line 274 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                                   Write(opStartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n\r\n");
#nullable restore
#line 277 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                                      
                                                        var opPauseTime = "";
                                                        if (opH.OpStartRunTime != null)
                                                        {
                                                            opPauseTime = opH.OpPauseRunTime.Value.ToString("dd, MMM hh:mm tt");
                                                        }
                                                        else
                                                        {
                                                            opPauseTime = "N/A";
                                                        }
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>\r\n                                                        ");
#nullable restore
#line 289 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                                   Write(opPauseTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 292 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                                   Write(opH.CycleTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 295 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr class=\"trEmpty\"></tr>\r\n");
#nullable restore
#line 297 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                        }
                                        else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                           <tr>
                                               <td colspan=""4"" class=""notAV"">
                                                   This Operation Not Started Yet !
                                               </td>
                                           </tr>              
");
#nullable restore
#line 304 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 304 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                                                                    
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n");
#nullable restore
#line 308 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <hr />\r\n                            <div class=\"notAV\">\r\n                                Operations Not Found !\r\n                            </div>\r\n");
#nullable restore
#line 315 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 315 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"notAV\">\r\n                            Work Order Not Found !\r\n                        </div>\r\n");
#nullable restore
#line 322 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 322 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"notAV\">\r\n                        Customer Order Not Found !\r\n                    </div>\r\n");
#nullable restore
#line 329 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\_GetCustomerOrderProgress.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


            </div>


            <div class=""modal-footer"">
                <button data-dismiss=""modal"" id=""cancel"" class=""btn btn-default"" type=""button"">Cancel</button>             
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EF.Core.DTO.CustomerOrderProgress> Html { get; private set; }
    }
}
#pragma warning restore 1591