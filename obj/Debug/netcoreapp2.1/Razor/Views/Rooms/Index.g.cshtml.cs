#pragma checksum "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0455a75f1f4f53d3b42104da018de0de5fe9a3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms_Index), @"mvc.1.0.view", @"/Views/Rooms/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rooms/Index.cshtml", typeof(AspNetCore.Views_Rooms_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0455a75f1f4f53d3b42104da018de0de5fe9a3e", @"/Views/Rooms/Index.cshtml")]
    public class Views_Rooms_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<midterm.Models.Room>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 158, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(243, 47, false);
#line 16 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.room_number));

#line default
#line hidden
            EndContext();
            BeginContext(290, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(346, 49, false);
#line 19 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.room_seat_num));

#line default
#line hidden
            EndContext();
            BeginContext(395, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(513, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(562, 46, false);
#line 28 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.room_number));

#line default
#line hidden
            EndContext();
            BeginContext(608, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(664, 48, false);
#line 31 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.room_seat_num));

#line default
#line hidden
            EndContext();
            BeginContext(712, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 787, "\"", 814, 1);
#line 34 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Index.cshtml"
WriteAttributeValue("", 802, item.RoomID, 802, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(815, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 867, "\"", 894, 1);
#line 35 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Index.cshtml"
WriteAttributeValue("", 882, item.RoomID, 882, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(895, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 949, "\"", 976, 1);
#line 36 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Index.cshtml"
WriteAttributeValue("", 964, item.RoomID, 964, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(977, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 39 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Rooms\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1027, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<midterm.Models.Room>> Html { get; private set; }
    }
}
#pragma warning restore 1591
