#pragma checksum "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f213c7098917e9bdfeae7ff63550f0c1f2dc3956"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms_Edit), @"mvc.1.0.view", @"/Views/Rooms/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rooms/Edit.cshtml", typeof(AspNetCore.Views_Rooms_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f213c7098917e9bdfeae7ff63550f0c1f2dc3956", @"/Views/Rooms/Edit.cshtml")]
    public class Views_Rooms_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<midterm.Models.Room>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(70, 1077, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Room</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""RoomID"" />
            <div class=""form-group"">
                <label asp-for=""room_number"" class=""control-label""></label>
                <input asp-for=""room_number"" class=""form-control"" />
                <span asp-validation-for=""room_number"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""room_seat_num"" class=""control-label""></label>
                <input asp-for=""room_seat_num"" class=""form-control"" />
                <span asp-validation-for=""room_seat_num"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
 ");
            WriteLiteral("   <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<midterm.Models.Room> Html { get; private set; }
    }
}
#pragma warning restore 1591
