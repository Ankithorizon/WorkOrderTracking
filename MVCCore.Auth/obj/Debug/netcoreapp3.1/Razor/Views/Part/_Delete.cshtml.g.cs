#pragma checksum "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Part\_Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23c97902d2f3f49a161e3020b4d8186b4ca3c297"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Part__Delete), @"mvc.1.0.view", @"/Views/Part/_Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23c97902d2f3f49a161e3020b4d8186b4ca3c297", @"/Views/Part/_Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac839b09ebec20598a531d11fe4a085c8ec9251", @"/Views/_ViewImports.cshtml")]
    public class Views_Part__Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EF.Core.Models.Part>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Part/Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .deleteModal{
        background-color:lightcoral;
    }
</style>

<div class=""modal fade"" id=""deletePart"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header deleteModal"">
                <h4 class=""modal-title"" id=""deletePartLabel"">
                    Are you sure want to delete !!!
                </h4>            

                <button type=""button"" class=""close"" data-dismiss=""modal"">
                    <span>X</span>
                </button>
            </div>


            <div class=""modal-body"">
                
                <div id=""floater""></div>
                <div id=""opStatus""></div>
                <p></p>

                <div>
                    <h5>Part # ");
#nullable restore
#line 30 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Part\_Delete.cshtml"
                          Write(Model.PartId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5>Name : ");
#nullable restore
#line 31 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Part\_Delete.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>                 \r\n                    <span>Desc : ");
#nullable restore
#line 32 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Part\_Delete.cshtml"
                            Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <br />\r\n                    <span>QTY : ");
#nullable restore
#line 34 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Part\_Delete.cshtml"
                           Write(Model.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23c97902d2f3f49a161e3020b4d8186b4ca3c2975500", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 38 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Part\_Delete.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 40 "C:\WorkOrder-Tracking-jQuery\MVCCore.Auth\Views\Part\_Delete.cshtml"
                   Write(Html.HiddenFor(model => model.PartId));

#line default
#line hidden
#nullable disable
                WriteLiteral("                        \r\n                    </div>                  \r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>


            <div class=""modal-footer"">
                <button data-dismiss=""modal"" id=""cancel"" class=""btn btn-default"" type=""button"">Cancel</button>
                <button class=""btn btn-primary""
                        data-save=""modal""
                        type=""button"">
                    Delete Part
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EF.Core.Models.Part> Html { get; private set; }
    }
}
#pragma warning restore 1591
