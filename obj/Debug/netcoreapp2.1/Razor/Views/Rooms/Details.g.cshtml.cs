#pragma checksum "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b5b7513a4ef37a7338e60a6f04bdf0cc5af6a33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms_Details), @"mvc.1.0.view", @"/Views/Rooms/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rooms/Details.cshtml", typeof(AspNetCore.Views_Rooms_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b5b7513a4ef37a7338e60a6f04bdf0cc5af6a33", @"/Views/Rooms/Details.cshtml")]
    public class Views_Rooms_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<midterm.Models.Room>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(73, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Room</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(192, 47, false);
#line 14 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.room_number));

#line default
#line hidden
            EndContext();
            BeginContext(239, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(283, 43, false);
#line 17 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.room_number));

#line default
#line hidden
            EndContext();
            BeginContext(326, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(370, 49, false);
#line 20 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.room_seat_num));

#line default
#line hidden
            EndContext();
            BeginContext(419, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(463, 45, false);
#line 23 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Details.cshtml"
       Write(Html.DisplayFor(model => model.room_seat_num));

#line default
#line hidden
            EndContext();
            BeginContext(508, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 575, "\"", 603, 1);
#line 28 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Details.cshtml"
WriteAttributeValue("", 590, Model.RoomID, 590, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(604, 65, true);
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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