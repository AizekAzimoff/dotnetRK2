#pragma checksum "C:\Users\Aziz\source\repos\midterm\midterm\Views\Groups\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ad2a9bdd4499395afeda73e3ec92987d855899f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Groups_Details), @"mvc.1.0.view", @"/Views/Groups/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Groups/Details.cshtml", typeof(AspNetCore.Views_Groups_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ad2a9bdd4499395afeda73e3ec92987d855899f", @"/Views/Groups/Details.cshtml")]
    public class Views_Groups_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<midterm.Models.Group>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Groups\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(74, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Group</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(194, 46, false);
#line 14 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Groups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.group_name));

#line default
#line hidden
            EndContext();
            BeginContext(240, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(284, 42, false);
#line 17 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Groups\Details.cshtml"
       Write(Html.DisplayFor(model => model.group_name));

#line default
#line hidden
            EndContext();
            BeginContext(326, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(370, 47, false);
#line 20 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Groups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.group_level));

#line default
#line hidden
            EndContext();
            BeginContext(417, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(461, 43, false);
#line 23 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Groups\Details.cshtml"
       Write(Html.DisplayFor(model => model.group_level));

#line default
#line hidden
            EndContext();
            BeginContext(504, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(548, 50, false);
#line 26 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Groups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.group_stud_num));

#line default
#line hidden
            EndContext();
            BeginContext(598, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(642, 46, false);
#line 29 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Groups\Details.cshtml"
       Write(Html.DisplayFor(model => model.group_stud_num));

#line default
#line hidden
            EndContext();
            BeginContext(688, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 755, "\"", 784, 1);
#line 34 "C:\Users\Aziz\source\repos\midterm\midterm\Views\Groups\Details.cshtml"
WriteAttributeValue("", 770, Model.GroupID, 770, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(785, 65, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<midterm.Models.Group> Html { get; private set; }
    }
}
#pragma warning restore 1591