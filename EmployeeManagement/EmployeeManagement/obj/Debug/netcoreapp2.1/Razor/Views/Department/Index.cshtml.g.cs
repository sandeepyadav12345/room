#pragma checksum "C:\Users\Dell\source\repos\EmployeeManagement\EmployeeManagement\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "273fc24c9736e2be20e5a8a44b5151f9e7445733"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Department/Index.cshtml", typeof(AspNetCore.Views_Department_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"273fc24c9736e2be20e5a8a44b5151f9e7445733", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/Department/_ViewImports.cshtml")]
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeManagement.Models.Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Dell\source\repos\EmployeeManagement\EmployeeManagement\Views\Department\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

    ViewBag.Title = "Admin";

    

#line default
#line hidden
            BeginContext(275, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\Dell\source\repos\EmployeeManagement\EmployeeManagement\Views\Department\Index.cshtml"
 foreach(var d in Model)
{

#line default
#line hidden
            BeginContext(306, 22, true);
            WriteLiteral("    <ul>\r\n        <li>");
            EndContext();
            BeginContext(329, 14, false);
#line 16 "C:\Users\Dell\source\repos\EmployeeManagement\EmployeeManagement\Views\Department\Index.cshtml"
       Write(d.DepartmentId);

#line default
#line hidden
            EndContext();
            BeginContext(343, 19, true);
            WriteLiteral("</li>\r\n        <li>");
            EndContext();
            BeginContext(363, 9, false);
#line 17 "C:\Users\Dell\source\repos\EmployeeManagement\EmployeeManagement\Views\Department\Index.cshtml"
       Write(d.DepName);

#line default
#line hidden
            EndContext();
            BeginContext(372, 19, true);
            WriteLiteral("</li>\r\n        <li>");
            EndContext();
            BeginContext(392, 13, false);
#line 18 "C:\Users\Dell\source\repos\EmployeeManagement\EmployeeManagement\Views\Department\Index.cshtml"
       Write(d.DepLocation);

#line default
#line hidden
            EndContext();
            BeginContext(405, 28, true);
            WriteLiteral("</li>\r\n        \r\n    </ul>\r\n");
            EndContext();
#line 21 "C:\Users\Dell\source\repos\EmployeeManagement\EmployeeManagement\Views\Department\Index.cshtml"
    

    
}

#line default
#line hidden
            BeginContext(450, 58, true);
            WriteLiteral("<p>\"employees\"</p>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeManagement.Models.Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591
