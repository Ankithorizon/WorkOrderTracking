#pragma checksum "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68ca53dc59698e7bc4a151b00a7a7c58fe155a3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OperatorLog_ViewMyLog), @"mvc.1.0.view", @"/Views/OperatorLog/ViewMyLog.cshtml")]
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
#line 1 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
using MVCCore.Auth.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
using EF.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ca53dc59698e7bc4a151b00a7a7c58fe155a3f", @"/Views/OperatorLog/ViewMyLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac839b09ebec20598a531d11fe4a085c8ec9251", @"/Views/_ViewImports.cshtml")]
    public class Views_OperatorLog_ViewMyLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EF.Core.DTO.OperatorLogDataView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("LogDataRange"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myLogDataForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("myLogDataForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetMyLogData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
  
    ViewData["Title"] = "View My-Log Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .titleSpan {
        background-color: lightgoldenrodyellow;
        color: red;
    }

    .operatorData {
        color: blue;
        font-size: small;
        border: 2px solid red;
        padding: 5px;
        width: 400px;
    }
    table, th, td {
        border: 1px dotted blue;
    }
</style>


<div class=""text-center"">
    <h3 class=""display-6""><span class=""titleSpan""><u>View My-Log</u></span></h3>
</div>


");
#nullable restore
#line 38 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
  
    var user = await UserManager.GetUserAsync(User);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-left operatorData\">\r\n    Operator : ");
#nullable restore
#line 42 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
          Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    First Name : ");
#nullable restore
#line 43 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
            Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    Last Name : ");
#nullable restore
#line 44 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
           Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    User Id : ");
#nullable restore
#line 45 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
         Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n</div>\r\n\r\n\r\n\r\n<p></p>\r\n<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68ca53dc59698e7bc4a151b00a7a7c58fe155a3f8098", async() => {
                WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 56 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68ca53dc59698e7bc4a151b00a7a7c58fe155a3f8598", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 58 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-3\">\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Select Log-Data Range</label>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68ca53dc59698e7bc4a151b00a7a7c58fe155a3f10472", async() => {
                    WriteLiteral("\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 64 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LogDataRange);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 67 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<ViewMyLogData>();

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
                <div class=""form-group text-center"">
                    <button type=""button"" class=""btn btn-primary viewMyLogData"">
                        View My-Log Data !
                    </button>
                </div>
                <div");
                BeginWriteAttribute("id", " id=\"", 2014, "\"", 2027, 1);
#nullable restore
#line 75 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
WriteAttributeValue("", 2019, user.Id, 2019, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""userIdClass"">
                </div>
            </div>
            <div class=""col-sm-9"">
                 <table id=""logData"" width=""100%"" border=""1"" >
                    <thead>
                        <tr style=""font-weight:bold; color: darkcyan;"">
                            <th>#</th>
                            <th>WorkOrder #</th>
                            <th>Operation</th>
                            <th>Status</th>
                            <th>Qty Done</th>
                            <th>Start Time</th>
                            <th>Pause Time</th>
                            <th>Cycle Time</th>
                        </tr>
                    </thead>
                    <tbody>
                    </tbody>
                 </table>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            function getOperationStatus(opStatus) {
                if (opStatus == 0)
                    return 'Start';
                else
                    return 'Pause';
            }

            function getOperation(opNumber) {
                if (opNumber == 10)
                    return 'Spindle';
                else if (opNumber == 20)
                    return 'Hub_Single_Head';
                else if (opNumber == 30)
                    return 'Hub_Double_Head';
                else if (opNumber == 40)
                    return 'Push_Cups';
                else if (opNumber == 50)
                    return 'Assembly_Spindle_Hub';
                else if (opNumber == 60)
                    return 'Paint';
                else if (opNumber == 70)
                    return 'Packaging' ;
                else if (opNumber == 80)
                    return 'Rework_Spindle';
         ");
                WriteLiteral(@"       else if (opNumber == 90)
                    return 'Rework_Hub' ;
                else
                    return opNumber;
            }


            $('.viewMyLogData').click(function () {

                var form = $('#myLogDataForm');
                var sendData = form.serialize();              
                var userId = $('.userIdClass').attr(""id"");

                var data = form.serialize() + '&UserId=' + userId;
                var url = '");
#nullable restore
#line 146 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
                      Write(Url.Action("GetMyLogData", "OperatorLog"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';


                $.post(url, data).done(function (response) {
                    // console.log(response);

                    if (response.result.statusCode == 0) {
                        // success
                        console.log(response.myLog);
                        console.log(response.result.message);

                        $(""#logData > tbody"").empty();

                        $.each(response.myLog, function (index, value) {
                            // alert(index + "": "" + value);

                            /*
                            var opStartTime = new Date(value.opStartRunTime);
                            console.log(opStartTime);
                            console.log(opStartTime.getMonth());
                            const month = opStartTime.toLocaleString('default', { month: 'long' });
                            console.log(month);
                            console.log(opStartTime.getDate());
                            const time = opStart");
                WriteLiteral(@"Time.toLocaleString('default', { hour: 'numeric', minute: 'numeric', hour12: true });
                            console.log(time);
                            */

                            var qtyDisplay;
                            if (value.opQtyDone != null)
                                qtyDisplay = value.opQtyDone;
                            else
                                qtyDisplay = ""N/A"";


                            var opStartTime;
                            var monthStartTime_;
                            var dateStartTime_;
                            var startTime_;
                            var opStartTimeDisplay;
                            if (value.opStartRunTime != null) {
                                opStartTime = new Date(value.opStartRunTime);
                                monthStartTime_ = opStartTime.toLocaleString('default', { month: 'long' });
                                dateStartTime_ = opStartTime.getDate();
                             ");
                WriteLiteral(@"   startTime_ = opStartTime.toLocaleString('default', { hour: 'numeric', minute: 'numeric', hour12: true });
                                opStartTimeDisplay = monthStartTime_ + "", "" + dateStartTime_ + "" ["" + startTime_ + ""] "";
                            }
                            else
                                opStartTimeDisplay = ""N/A"";


                            var opPauseTime;
                            var monthPauseTime_;
                            var datePauseTime_;
                            var pauseTime_;
                            var opPauseTimeDisplay;
                            if (value.opPauseRunTime != null) {
                                opPauseTime = new Date(value.opPauseRunTime);
                                monthPauseTime_ = opPauseTime.toLocaleString('default', { month: 'long' });
                                datePauseTime_ = opPauseTime.getDate();
                                pauseTime_ = opPauseTime.toLocaleString('default', { hour: 'n");
                WriteLiteral(@"umeric', minute: 'numeric', hour12: true });
                                opPauseTimeDisplay = monthPauseTime_ + "", "" + datePauseTime_ + "" ["" + pauseTime_ + ""] "";
                            }
                            else
                                opPauseTimeDisplay = ""N/A"";


                            var hours_;
                            var minutes_;
                            var timeDisplay;
                            if (value.cycleTime != null) {
                                hours_ = value.cycleTime.value.hours;
                                minutes_ = value.cycleTime.value.minutes;
                                timeDisplay = hours_ + "":"" + minutes_;
                            }
                            else
                                timeDisplay = ""N/A"";
                       

                            var tr;
                            tr = $('<tr/>');
                            tr.append(""<td>"" + value.operatorActivityId + ""</td>"");
    ");
                WriteLiteral(@"                        tr.append(""<td>"" + value.workOrderId + ""</td>"");
                            tr.append(""<td>"" + getOperation(value.operationNumber) + ""<br />"" + ""[ "" + value.operationNumber + "" ]"" + ""</td>"");
                            tr.append(""<td>"" + getOperationStatus(value.operationStatus) + ""</td>"");
                            tr.append(""<td>"" + qtyDisplay + ""</td>"");
                            tr.append(""<td>"" + opStartTimeDisplay + ""</td>"");
                            tr.append(""<td>"" + opPauseTimeDisplay + ""</td>"");
                            tr.append(""<td>"" + timeDisplay + ""</td>"");

                            $('#logData').append(tr);
                        });
                      

                    }
                    if (response.result.statusCode == -1) {
                        // server error
                        console.log(response.result.message);
                    }
                }).fail(function (error) {
                    console.log(""Aj");
                WriteLiteral("ax Call Error\");\r\n                });\r\n            });\r\n\r\n        });\r\n    </script>\r\n\r\n\r\n");
#nullable restore
#line 253 "C:\MVC-JQuery\MVCCore.Auth\Views\OperatorLog\ViewMyLog.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EF.Core.DTO.OperatorLogDataView> Html { get; private set; }
    }
}
#pragma warning restore 1591
