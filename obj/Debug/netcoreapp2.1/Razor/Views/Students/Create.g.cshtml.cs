#pragma checksum "C:\Users\Aziz\source\repos\midterm\midterm\Views\Students\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65f6f4a35120abb0356507d6cb511fa0ee59914c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Create), @"mvc.1.0.view", @"/Views/Students/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Create.cshtml", typeof(AspNetCore.Views_Students_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65f6f4a35120abb0356507d6cb511fa0ee59914c", @"/Views/Students/Create.cshtml")]
    public class Views_Students_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<midterm.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Students\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(75, 1534, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>Student</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""stud_name"" class=""control-label""></label>
                <input asp-for=""stud_name"" class=""form-control"" />
                <span asp-validation-for=""stud_name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""stud_phone"" class=""control-label""></label>
                <input asp-for=""stud_phone"" class=""form-control"" />
                <span asp-validation-for=""stud_phone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""stud_mail"" class=""control-label""></label>
                <input asp-for=""stud_mail"" class=""form-control"" />
                <span asp-validation-for=""stud_mail"" class=""text");
            WriteLiteral(@"-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""GroupID"" class=""control-label""></label>
                <select asp-for=""GroupID"" class =""form-control"" asp-items=""ViewBag.GroupID""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<midterm.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
