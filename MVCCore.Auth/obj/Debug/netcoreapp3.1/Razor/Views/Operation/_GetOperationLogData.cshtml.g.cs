#pragma checksum "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3099cd0d851dc39f952b86daca4a1df7ec077dd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operation__GetOperationLogData), @"mvc.1.0.view", @"/Views/Operation/_GetOperationLogData.cshtml")]
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
#nullable restore
#line 1 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
using EF.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3099cd0d851dc39f952b86daca4a1df7ec077dd7", @"/Views/Operation/_GetOperationLogData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac839b09ebec20598a531d11fe4a085c8ec9251", @"/Views/_ViewImports.cshtml")]
    public class Views_Operation__GetOperationLogData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EF.Core.DTO.OperationLog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .operationLogModal {
        background-color: lightblue;
    }
    .modalWindow {
        max-width: 80% !important;
    }
</style>

<div class=""modal fade"" id=""operationLog"">
    <div class=""modal-dialog modalWindow"">
        <div class=""modal-content"">
            <div class=""modal-header operationLogModal"">
                <h4 class=""modal-title"" id=""operationLogLabel"">
                    Operation Log Data
                </h4>

                <button type=""button"" class=""close"" data-dismiss=""modal"">
                    <span>X</span>
                </button>
            </div>


            <div class=""modal-body"">

                <div>
");
#nullable restore
#line 30 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                      
                        var opNumber = "";
                        if (@Model.OperationNumber == (int)OperationNumber.Spindle)
                        {
                            opNumber = "Spindle - 10";
                        }
                        if (@Model.OperationNumber == (int)OperationNumber.Hub_Single_Head)
                        {
                            opNumber = "Hub_Single_Head - 20";
                        }
                        if (@Model.OperationNumber == (int)OperationNumber.Hub_Double_Head)
                        {
                            opNumber = "Hub_Double_Head - 30";
                        }
                        if (@Model.OperationNumber == (int)OperationNumber.Push_Cups)
                        {
                            opNumber = "Push_Cups - 40";
                        }
                        if (@Model.OperationNumber == (int)OperationNumber.Assembly_Spindle_Hub)
                        {
                            opNumber = "Assembly_Spindle_Hub - 50";
                        }
                        if (@Model.OperationNumber == (int)OperationNumber.Paint)
                        {
                            opNumber = "Paint - 60";
                        }
                        if (@Model.OperationNumber == (int)OperationNumber.Packaging)
                        {
                            opNumber = "Packaging - 70";
                        }
                        if (@Model.OperationNumber == (int)OperationNumber.Rework_Spindle)
                        {
                            opNumber = "Rework_Spindle - 80";
                        }
                        if (@Model.OperationNumber == (int)OperationNumber.Rework_Hub)
                        {
                            opNumber = "Rework_Hub - 90";
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5>Operation # ");
#nullable restore
#line 69 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                               Write(Model.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5>Operation : [");
#nullable restore
#line 70 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                Write(Model.OperationNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("] ");
#nullable restore
#line 70 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                                        Write(opNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5>Work Order # ");
#nullable restore
#line 71 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                Write(Model.WorkOrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    <table class=""table"" id=""operationsTable"">
                        <thead>
                            <tr>
                                <th>
                                    Operator
                                </th>
                                <th>
                                    Start Time
                                </th>
                                <th>
                                    Pause Time
                                </th>
                                <th>
                                    Cycle Time
                                </th>
                                <th>
                                    Qty Done
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 93 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                             foreach (var item in Model.OperationHistory) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    [ ");
#nullable restore
#line 96 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                 Write(item.OperatorId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ] ");
#nullable restore
#line 96 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                                    Write(item.OperatorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 98 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                  
                                    if (@item.OpStartRunTime != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            ");
#nullable restore
#line 102 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                       Write(item.OpStartRunTime.Value.ToString("dd, MMM hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 104 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            N/A\r\n                                        </td>\r\n");
#nullable restore
#line 110 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 113 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                  
                                    if (@item.OpPauseRunTime != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            ");
#nullable restore
#line 117 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                       Write(item.OpPauseRunTime.Value.ToString("dd, MMM hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 119 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            N/A\r\n                                        </td>\r\n");
#nullable restore
#line 125 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 128 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                  
                                    if (@item.CycleTime != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            ");
#nullable restore
#line 132 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                       Write(item.CycleTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 134 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            N/A\r\n                                        </td>\r\n");
#nullable restore
#line 140 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 143 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                  
                                    if (@item.QtyDone != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            ");
#nullable restore
#line 147 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                       Write(item.QtyDone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 149 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            N/A\r\n                                        </td>\r\n");
#nullable restore
#line 155 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 158 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Operation\_GetOperationLogData.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>                 
                </div>
                <p></p>
            </div>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EF.Core.DTO.OperationLog> Html { get; private set; }
    }
}
#pragma warning restore 1591
