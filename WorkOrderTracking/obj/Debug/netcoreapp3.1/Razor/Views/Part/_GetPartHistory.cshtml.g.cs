#pragma checksum "C:\MVC-JQuery\WorkOrderTracking\Views\Part\_GetPartHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7913483a39ecaaa77a854e6e8d7e5efd8b4e10a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Part__GetPartHistory), @"mvc.1.0.view", @"/Views/Part/_GetPartHistory.cshtml")]
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
#nullable restore
#line 1 "C:\MVC-JQuery\WorkOrderTracking\Views\Part\_GetPartHistory.cshtml"
using EF.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7913483a39ecaaa77a854e6e8d7e5efd8b4e10a5", @"/Views/Part/_GetPartHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f45be0d4b3a1a0f535323d4294e29beb03308cee", @"/Views/_ViewImports.cshtml")]
    public class Views_Part__GetPartHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EF.Core.DTO.PartHistoryData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .partHistoryModal {
        background-color: lightblue;
    }
</style>

<div class=""modal fade"" id=""partHistory"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header partHistoryModal"">
                <h4 class=""modal-title"" id=""partHistoryLabel"">
                    Operation v/s Parts Data
                </h4>

                <button type=""button"" class=""close"" data-dismiss=""modal"">
                    <span>X</span>
                </button>
            </div>


            <div class=""modal-body"">

                <div>
");
#nullable restore
#line 27 "C:\MVC-JQuery\WorkOrderTracking\Views\Part\_GetPartHistory.cshtml"
                      
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
#line 66 "C:\MVC-JQuery\WorkOrderTracking\Views\Part\_GetPartHistory.cshtml"
                               Write(Model.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5>Operation : [");
#nullable restore
#line 67 "C:\MVC-JQuery\WorkOrderTracking\Views\Part\_GetPartHistory.cshtml"
                                Write(Model.OperationNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("] ");
#nullable restore
#line 67 "C:\MVC-JQuery\WorkOrderTracking\Views\Part\_GetPartHistory.cshtml"
                                                        Write(opNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5>Work Order # ");
#nullable restore
#line 68 "C:\MVC-JQuery\WorkOrderTracking\Views\Part\_GetPartHistory.cshtml"
                                Write(Model.WorkOrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 69 "C:\MVC-JQuery\WorkOrderTracking\Views\Part\_GetPartHistory.cshtml"
                     foreach (var item in Model.PartList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <hr />\r\n                        <h6>Part # ");
#nullable restore
#line 72 "C:\MVC-JQuery\WorkOrderTracking\Views\Part\_GetPartHistory.cshtml"
                              Write(item.PartId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <h6>Part Name : ");
#nullable restore
#line 73 "C:\MVC-JQuery\WorkOrderTracking\Views\Part\_GetPartHistory.cshtml"
                                   Write(item.PartName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <h6>QTY XFER # ");
#nullable restore
#line 74 "C:\MVC-JQuery\WorkOrderTracking\Views\Part\_GetPartHistory.cshtml"
                                  Write(item.XFERQTY);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 75 "C:\MVC-JQuery\WorkOrderTracking\Views\Part\_GetPartHistory.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EF.Core.DTO.PartHistoryData> Html { get; private set; }
    }
}
#pragma warning restore 1591
