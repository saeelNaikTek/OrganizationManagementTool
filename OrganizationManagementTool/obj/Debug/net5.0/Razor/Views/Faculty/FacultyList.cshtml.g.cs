#pragma checksum "C:\Users\saeel.naik\Documents\GitHub\OrganizationManagementTool\OrganizationManagementTool\Views\Faculty\FacultyList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b27169c51e2b16657bf744a02ba8437ebce212b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faculty_FacultyList), @"mvc.1.0.view", @"/Views/Faculty/FacultyList.cshtml")]
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
#line 1 "C:\Users\saeel.naik\Documents\GitHub\OrganizationManagementTool\OrganizationManagementTool\Views\_ViewImports.cshtml"
using OrganizationManagementTool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saeel.naik\Documents\GitHub\OrganizationManagementTool\OrganizationManagementTool\Views\_ViewImports.cshtml"
using OrganizationManagementTool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b27169c51e2b16657bf744a02ba8437ebce212b", @"/Views/Faculty/FacultyList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"635057620363ce3f2ef683eca90e482beba3ad05", @"/Views/_ViewImports.cshtml")]
    public class Views_Faculty_FacultyList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrganizationManagementTool.Models.FacultyModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Faculty", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\saeel.naik\Documents\GitHub\OrganizationManagementTool\OrganizationManagementTool\Views\Faculty\FacultyList.cshtml"
  
    ViewData["Title"] = "FacultyList";

#line default
#line hidden
#nullable disable
            WriteLiteral("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n<h1>Faculty List</h1>\r\n<p class=\"float-right\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b27169c51e2b16657bf744a02ba8437ebce212b4364", async() => {
                WriteLiteral(@"
        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-person-plus-fill"" viewBox=""0 0 16 16"">
            <path d=""M1 14s-1 0-1-1 1-4 6-4 6 3 6 4-1 1-1 1H1zm5-6a3 3 0 1 0 0-6 3 3 0 0 0 0 6z"" />
            <path fill-rule=""evenodd"" d=""M13.5 5a.5.5 0 0 1 .5.5V7h1.5a.5.5 0 0 1 0 1H14v1.5a.5.5 0 0 1-1 0V8h-1.5a.5.5 0 0 1 0-1H13V5.5a.5.5 0 0 1 .5-.5z"" />
        </svg>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<!--partial view-->\r\n");
            WriteLiteral("<!--EOC partial view-->\r\n");
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-sm-4\">\r\n        <input type=\"search\" class=\"form-control\" placeholder=\"Enter ....\"");
            BeginWriteAttribute("value", " value=\"", 1048, "\"", 1083, 1);
#nullable restore
#line 25 "C:\Users\saeel.naik\Documents\GitHub\OrganizationManagementTool\OrganizationManagementTool\Views\Faculty\FacultyList.cshtml"
WriteAttributeValue("", 1056, ViewData["GetFacultyList"], 1056, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"strFilter\" />\r\n    </div>\r\n    <div class=\"col-sm-3\">\r\n        <input type=\"submit\" value=\"Filter\" class=\"btn btn-primary\" onclick=\"return GetFacultyList()\" />\r\n    </div>\r\n</div>\r\n");
            WriteLiteral(@"<table id=""FacultyTbl"" class=""table table-striped table-sm"" cellspacing=""0"" width=""100%"" style=""border-radius:4px;box-shadow: rgba(136, 165, 191, 0.48) 6px 2px 16px 0px, rgb(96 ,166 ,193 , 80%) 4px 4px 14px 0px;"">
    <thead class=""bg-info"">
        <tr>
            <th>
                ");
#nullable restore
#line 36 "C:\Users\saeel.naik\Documents\GitHub\OrganizationManagementTool\OrganizationManagementTool\Views\Faculty\FacultyList.cshtml"
           Write(Html.DisplayName("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\saeel.naik\Documents\GitHub\OrganizationManagementTool\OrganizationManagementTool\Views\Faculty\FacultyList.cshtml"
           Write(Html.DisplayName("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\saeel.naik\Documents\GitHub\OrganizationManagementTool\OrganizationManagementTool\Views\Faculty\FacultyList.cshtml"
           Write(Html.DisplayName("Mobile"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\saeel.naik\Documents\GitHub\OrganizationManagementTool\OrganizationManagementTool\Views\Faculty\FacultyList.cshtml"
           Write(Html.DisplayName("Age"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\saeel.naik\Documents\GitHub\OrganizationManagementTool\OrganizationManagementTool\Views\Faculty\FacultyList.cshtml"
           Write(Html.DisplayName("Gender"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\Users\saeel.naik\Documents\GitHub\OrganizationManagementTool\OrganizationManagementTool\Views\Faculty\FacultyList.cshtml"
           Write(Html.DisplayName("Department Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Action\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody class=\"tbody\">\r\n");
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n<link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css\">\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js""></script>
    <script>
        $('#FacultyTbl1').DataTable({});
    </script>
    <script>
        $(document).ready(function () {
            loadData();
        });

        function loadData() {
            $.ajax({
                url: ""/Faculty/GetAllFacultyList"",
                type: ""GET"",
                contentType: ""application/json;charset=utf-8"",
                dataType: ""json"",
                success: function (result) {
                    var html = '';
                    $.each(result, function (key, item) {
                        html += '<tr>';
                        html += '<td>' + item.name + '</td>';
                        html += '<td>' + item.email + '</td>';
                        html += '<td>' + item.mobile + '</td>';
                        html += '<td>' + item.age + '</td>';
                        html += '<td>' + item.gender + '</td>';
       ");
                WriteLiteral(@"                 html += '<td>' + item.department.deptName + '</td>';
                        html += '<td><a class=""btn btn-success"" href=""#"" onclick=""return EditFaculty(' + item.id + ')"">Edit</a> | <a class=""btn btn-danger"" href=""#"" onclick=""DeleteFacultyDtls(' + item.id + ')"">Delete</a></td>';
                        html += '</tr>';
                    });
                    $('.tbody').html(html);
                },
                error: function (errormessage) {
                    alert(errormessage.responseText);
                }
            });
        }

        function GetFacultyList() {
            var filter = $(""#strFilter"").val();
            $.ajax({
                url: ""/Faculty/GetFacultyList/"",
                type: ""GET"",
                data: { 'tmp': filter },
                contentType: ""application/json;charset=utf-8"",
                dataType: ""json"",
                success: function (result) {
                    var html = '';
                    $.each(");
                WriteLiteral(@"result, function (key, item) {
                        html += '<tr>';
                        html += '<td>' + item.name + '</td>';
                        html += '<td>' + item.email + '</td>';
                        html += '<td>' + item.mobile + '</td>';
                        html += '<td>' + item.age + '</td>';
                        html += '<td>' + item.gender + '</td>';
                        html += '<td>' + item.deptName + '</td>';
                        html += '<td><a class=""btn btn-success"" href=""#"" onclick=""return EditFaculty(' + item.id + ')"">Edit</a> | <a class=""btn btn-danger"" href=""#"" onclick=""DeleteFacultyDtls(' + item.id + ')"">Delete</a></td>';
                        html += '</tr>';
                    });
                    $('.tbody').html(html);
                },
                error: function (errormessage) {
                    alert(errormessage.responseText);
                }
            });
        }

        function EditFaculty(ID) {
            //");
                WriteLiteral(@"var ans = confirm(""Are you sure you want to delete this Record?"");
            //if (ans) {
                window.location.href = '/Faculty/Faculty/' + ID;

                //$.ajax({
                //    url: ""/Faculty/EditFaculty/"" + ID,
                //    type: ""POST"",
                //    contentType: ""application/json;charset=UTF-8"",
                //    dataType: ""json"",
                //    success: function (result) {
                //        window.location.href = '/Faculty/Faculty/' + result;
                //    },
                //    error: function (errormessage) {
                //        alert(errormessage.responseText);
                //    }
                //});
            //}
        }

        function DeleteFacultyDtls(ID) {
            var ans = confirm(""Are you sure you want to delete this Record?"");
            if (ans) {
                $.ajax({
                    url: ""/Faculty/DeleteFacultyDtls/"" + ID,
                    type: ""POST"",
      ");
                WriteLiteral(@"              contentType: ""application/json;charset=UTF-8"",
                    dataType: ""json"",
                    success: function (result) {
                        loadData();
                    },
                    error: function (errormessage) {
                        alert(errormessage.responseText);
                    }
                });
            }
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrganizationManagementTool.Models.FacultyModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
