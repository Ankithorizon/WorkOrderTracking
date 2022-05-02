#pragma checksum "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3272db0c3b83a7e98e5d92fd5e51886a382b6d33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerOrder_Index), @"mvc.1.0.view", @"/Views/CustomerOrder/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3272db0c3b83a7e98e5d92fd5e51886a382b6d33", @"/Views/CustomerOrder/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac839b09ebec20598a531d11fe4a085c8ec9251", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\Index.cshtml"
  
    ViewData["Title"] = "Customer Order - Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .titleSpan {\r\n        background-color: lightgoldenrodyellow;\r\n        color: red;\r\n    }   \r\n</style>\r\n\r\n<div class=\"text-center\">\r\n    <h3 class=\"display-6\"><span class=\"titleSpan\"><u>Customer Orders</u></span></h3>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3272db0c3b83a7e98e5d92fd5e51886a382b6d333808", async() => {
                WriteLiteral("Create - [Customer Order]");
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


<!-- customer order v/s operations progress -->
<div class=""row"">
    <div class=""col-lg-12"">
        <div id=""chartdiv"" style=""width: 100%; height: 400px;"">
        </div>
    </div>
</div>




<!-- this will hold partial view (modal) -->
<div id=""PlaceHolderHere""></div>

<hr />
<p></p>
<table id=""customerOrdersTable""
       class=""table table-sm table-bordered table-striped""
       style=""width:100%"">
    <thead>
        <tr>
            <th>#</th>
            <th>Customer</th>
            <th>Product</th>
            <th>QTY</th>
            <th>Order Date</th>
            <th>Due Date</th>
            <th></th>
        </tr>
    </thead>
</table>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    

    <script type=""text/javascript"">

        $(document).ready(function () {
                    

            function loadBarChart() {
                google.charts.load('current', { 'packages': ['corechart'] });
                google.charts.setOnLoadCallback(DrawonLoad);
            }
            // loadBarChart();
            function DrawonLoad() {
                $(function () {
                    var data = table.row($(this).parents('tr')).data();
                    console.log(data);
                    var customerOrderId = data.customerOrderId;
                    console.log(customerOrderId);

                    var url = '");
#nullable restore
#line 73 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\Index.cshtml"
                          Write(Url.Action("GetOperationProgressForCustomerOrder", "CustomerOrder"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + '\\' + customerOrderId;


                    $.ajax({
                        type: 'GET',
                        // url: '/CustomerOrder/GetOperationProgressForCustomerOrder',
                        url: url,
                        success: function (chartsdata) {

                            var Data = chartsdata.chartData;
                            var data = new google.visualization.DataTable();

                            data.addColumn('string', 'Operation Number');
                            data.addColumn('number', 'Qty Done');
                            data.addColumn('number', 'Qty Required');

                            for (var i = 0; i < Data.length; i++) {
                                data.addRow([Data[i].operationNumber, Data[i].qtyDone, Data[i].qtyRequired]);
                            }

                            // var chart = new google.visualization.PieChart(document.getElementById('chartdiv'));
                            // var chart = new google.");
                WriteLiteral(@"visualization.BarChart(document.getElementById('chartdiv'));
                            var chart = new google.visualization.ColumnChart(document.getElementById('chartdiv'));

                            chart.draw(data,
                                {
                                    title: ""Customer Order v/s Operations Progress"",
                                    position: ""top"",
                                    fontsize: ""14px"",
                                    vAxis: {
                                        title: ""QTY (Done / Required)"",
                                        textStyle: {
                                            fontSize: 16,
                                            color: 'black',
                                            bold: true,
                                            italic: true
                                        }
                                    },
                                    hAxis: {
                               ");
                WriteLiteral(@"         title: ""Operation Number"",
                                        textStyle: {
                                            fontSize: 16,
                                            color: 'black',
                                            bold: true,
                                            italic: true
                                        } },
                                });
                        },
                        error: function () {
                            alert(""Error loading data! Please try again."");
                        }
                    });

                })
            }



            var errorCode = 0;

            $('#floater').hide();

            var table = $('#customerOrdersTable').DataTable({
                processing: true,
                ordering: true,
                paging: true,
                searching: true,
                ajax: ""CustomerOrder/GetAllCustomerOrders"",
                columns: [
             ");
                WriteLiteral(@"       { ""data"": ""customerOrderId"" },
                    { ""data"": ""customerName"" },
                    { ""data"": ""productName"" },
                    { ""data"": ""orderQuantity"" },
                    {
                        ""data"": ""orderDate"", render: function (data, type, row) {//data
                            return moment(row.orderDate).format('DD MMM, YYYY');
                        }
                    },
                    {
                        ""data"": ""orderDueDate"", render: function (data, type, row) {//data
                            return moment(row.orderDueDate).format('DD MMM, YYYY');
                        }
                    },
                    {
                        ""data"": null, ""defaultContent"": ""<button id='btnCOEdit' class='btn btn-primary'><i class='fa fa-edit fa-lg' aria-hidden='true'></i></button><span>&nbsp;</span><button id='btnCODelete' class='btn btn-danger'><i class='fa fa-trash fa-lg'></i></button><span>&nbsp;</span><button id='btnCOProgress' ");
                WriteLiteral(@"class='btn btn-success'><i class='fa fa-spinner fa-lg'></i> Order</button>""
                    },
                ],
            });

            // customer order progress
            // get
            /*
            $('#customerOrdersTable tbody').on('click', '[id*=btnCOProgress]', function () {
                var data = table.row($(this).parents('tr')).data();
                console.log(data);
                var customerOrderId = data.customerOrderId;
                console.log(customerOrderId);
            */
                /*
                var url = 'CustomerOrder\\GetCustomerOrderProgress\\' + customerOrderId;
                $.get(url).done(function (data) {
                    PlaceHolderElement.html(data);
                    PlaceHolderElement.find('.modal').modal('show');
                });
                */
            // });

            // edit
            // get
            var PlaceHolderElement = $('#PlaceHolderHere');
            $('#customerOrdersTable t");
                WriteLiteral(@"body').on('click', '[id*=btnCOEdit]', function () {
                var data = table.row($(this).parents('tr')).data();
                console.log(data);
                var customerOrderId = data.customerOrderId;
                console.log(customerOrderId);
                var url = 'CustomerOrder\\Edit\\' + customerOrderId;
                $.get(url).done(function (data) {
                    PlaceHolderElement.html(data);
                    PlaceHolderElement.find('.modal').modal('show');
                });
            });

            // delete
            // get
            $('#customerOrdersTable tbody').on('click', '[id*=btnCODelete]', function () {
                var data = table.row($(this).parents('tr')).data();
                console.log(data);
                var customerOrderId = data.customerOrderId;
                console.log(customerOrderId);
                var url = 'CustomerOrder\\GetCustomerOrderForDelete\\' + customerOrderId;
                $.get(url).done(func");
                WriteLiteral(@"tion (data) {
                    // console.log(data);
                    PlaceHolderElement.html(data);
                    PlaceHolderElement.find('.modal').modal('show');
                });
            });

            // edit - delete
            // post
            PlaceHolderElement.on('click', '[data-save=""modal""]', function (event) {
                var form = $(this).parents('.modal').find('form');
                var actionUrl = form.attr('action');
                var sendData = form.serialize();
                $.post(actionUrl, sendData).done(function (response) {
                    console.log(response);
                    console.log(response.result.statusCode);
                    console.log(response.result.message);
                    var mErrors = '';
                    if (response.result.statusCode == 0) {
                        errorCode = 0;
                        bkTimer(response.result);
                        resetUI();
                    }
         ");
                WriteLiteral(@"           else if (response.result.statusCode == -1) {
                        errorCode = -1;
                        bkTimer(response.result);
                        // resetUI();
                    }
                    else if (response.result.statusCode == 1) {
                        errorCode = 1;
                        // model error
                        mErrors += '<font color=""red"">';
                        mErrors += response.result.message;
                        mErrors += ""<ul>"";
                        $.each(response.result.modelErrors, function (key, value) {
                            mErrors += ""<li>"" + value + ""</li>"";
                        });
                        mErrors += ""</ul></font>"";
                    }
                    else {
                        bkTimer(response.result);
                        resetUI();
                    }
                    $('#opStatus').html(mErrors);
                });
            });

            // succes");
                WriteLiteral(@"s / dal error
            function bkTimer(result) {
                var div = $(""#floater"");
                var content = '';
                if (result.statusCode == 0) {
                    content += '<img src=""../Images/success.png"" style = ""width:50px;height:50px;"" /> ';
                    content += '<font color=""green"">' + result.message + '</font>';
                }
                else if (result.statusCode == -1) {
                    content += '<img src=""../Images/error.png"" style = ""width:50px;height:50px;"" /> ';
                    content += '<font color=""red"">' + result.message + '</font>';
                }
                else {
                    content += '<img src=""../Images/error.png"" style = ""width:50px;height:50px;"" /> ';
                    content += '<font color=""red"">' + result.Message + '</font>';
                }
                div.html(content);
                div.fadeIn(""slow"");

                if (errorCode == 0) {
                    div.queue(fu");
                WriteLiteral(@"nction () {
                        setTimeout(function () {
                            div.dequeue();

                            PlaceHolderElement.find('.modal').modal('hide');

                            table.ajax.reload();

                        }, 3000);
                    });
                    div.fadeOut(""fast"");
                }
            };
            function resetUI() {
                $('#CustomerName').val('');
                $('#ProductName').val('');
                $('#ProductDesc').val('');
                $('#OrderQuantity').val('');
                $('#OrderDate').val('');
                $('#OrderDueDate').val('');
            };



            // customer order v/s operations progress
                $('#customerOrdersTable tbody').on('click', '[id*=btnCOProgress]', function () {

                google.charts.load('current', { 'packages': ['corechart'] });
                google.charts.setOnLoadCallback();

                var data = table.row");
                WriteLiteral("($(this).parents(\'tr\')).data();\r\n                console.log(data);\r\n                var customerOrderId = data.customerOrderId;\r\n                console.log(customerOrderId);\r\n\r\n                var url = \'");
#nullable restore
#line 305 "C:\MVC-JQuery\MVCCore.Auth\Views\CustomerOrder\Index.cshtml"
                      Write(Url.Action("GetOperationProgressForCustomerOrder", "CustomerOrder"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' + '\\' + customerOrderId;

                $.ajax({
                    type: 'GET',
                    // url: '/CustomerOrder/GetOperationProgressForCustomerOrder',
                    url: url,
                    success: function (chartsdata) {

                        var Data = chartsdata.chartData;
                        var data = new google.visualization.DataTable();

                        data.addColumn('string', 'Operation Number');
                        data.addColumn('number', 'Qty Done');
                        data.addColumn('number', 'Qty Required');

                        for (var i = 0; i < Data.length; i++) {
                            data.addRow([Data[i].operationNumber, Data[i].qtyDone, Data[i].qtyRequired]);
                        }

                        // var chart = new google.visualization.PieChart(document.getElementById('chartdiv'));
                        // var chart = new google.visualization.BarChart(document.getElementById('chartdiv'));
");
                WriteLiteral(@"                        var chart = new google.visualization.ColumnChart(document.getElementById('chartdiv'));

                        chart.draw(data,
                            {
                                title: ""Customer Order v/s Operations Progress"",
                                position: ""top"",
                                fontsize: ""14px"",
                                vAxis: {
                                    title: ""QTY (Done / Required)"",
                                    textStyle: {
                                        fontSize: 16,
                                        color: 'black',
                                        bold: true,
                                        italic: true
                                    }
                                },
                                hAxis: {
                                    title: ""Operation Number"",
                                    textStyle: {
                                        fon");
                WriteLiteral(@"tSize: 16,
                                        color: 'black',
                                        bold: true,
                                        italic: true
                                    }
                                },
                            });
                    },
                    error: function () {
                        alert(""Error loading data! Please try again."");
                    }
                });
            });








        });
    </script>
");
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
