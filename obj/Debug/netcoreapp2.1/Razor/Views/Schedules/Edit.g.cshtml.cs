#pragma checksum "C:\Users\Aziz\source\repos\midterm\midterm\Views\Schedules\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9bbaecd5e296d20b7d896565627a08b99700430"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedules_Edit), @"mvc.1.0.view", @"/Views/Schedules/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Schedules/Edit.cshtml", typeof(AspNetCore.Views_Schedules_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9bbaecd5e296d20b7d896565627a08b99700430", @"/Views/Schedules/Edit.cshtml")]
    public class Views_Schedules_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<midterm.Models.Schedule>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Schedules\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(74, 2038, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Schedule</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""ScheduleID"" />
            <div class=""form-group"">
                <label asp-for=""sch_day"" class=""control-label""></label>
                <input asp-for=""sch_day"" class=""form-control"" />
                <span asp-validation-for=""sch_day"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""RoomID"" class=""control-label""></label>
                <select asp-for=""RoomID"" class=""form-control"" asp-items=""ViewBag.RoomID""></select>
                <span asp-validation-for=""RoomID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TeacherID"" class=""control-label""></label>
                <select asp-for=""TeacherID"" class=""form-cont");
            WriteLiteral(@"rol"" asp-items=""ViewBag.TeacherID""></select>
                <span asp-validation-for=""TeacherID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""GroupID"" class=""control-label""></label>
                <select asp-for=""GroupID"" class=""form-control"" asp-items=""ViewBag.GroupID""></select>
                <span asp-validation-for=""GroupID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CourseID"" class=""control-label""></label>
                <select asp-for=""CourseID"" class=""form-control"" asp-items=""ViewBag.CourseID""></select>
                <span asp-validation-for=""CourseID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<midterm.Models.Schedule> Html { get; private set; }
    }
}
#pragma warning restore 1591
