#pragma checksum "C:\administration-project\UserAdmin\UserAdmin\Views\App\UsersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "531da19b4e0a02f24ab11f010d18b40c99f70442"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_UsersList), @"mvc.1.0.view", @"/Views/App/UsersList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/App/UsersList.cshtml", typeof(AspNetCore.Views_App_UsersList))]
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
#line 1 "C:\administration-project\UserAdmin\UserAdmin\Views\_ViewImports.cshtml"
using UserAdmin.Controllers;

#line default
#line hidden
#line 2 "C:\administration-project\UserAdmin\UserAdmin\Views\_ViewImports.cshtml"
using UserAdmin.ViewModels;

#line default
#line hidden
#line 3 "C:\administration-project\UserAdmin\UserAdmin\Views\_ViewImports.cshtml"
using UserAdmin.Data.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"531da19b4e0a02f24ab11f010d18b40c99f70442", @"/Views/App/UsersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b49eaefea26dd6d84871252b95c98b452fb55f03", @"/Views/_ViewImports.cshtml")]
    public class Views_App_UsersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 31, true);
            WriteLiteral("<h3>Users View</h3>\r\n<p>Count: ");
            EndContext();
            BeginContext(58, 13, false);
#line 3 "C:\administration-project\UserAdmin\UserAdmin\Views\App\UsersList.cshtml"
     Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(71, 25, true);
            WriteLiteral("</p>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 5 "C:\administration-project\UserAdmin\UserAdmin\Views\App\UsersList.cshtml"
     foreach (var u in Model)
    {

#line default
#line hidden
            BeginContext(134, 48, true);
            WriteLiteral("        <div class=\"col-md-3\">\r\n            <h3>");
            EndContext();
            BeginContext(183, 7, false);
#line 8 "C:\administration-project\UserAdmin\UserAdmin\Views\App\UsersList.cshtml"
           Write(u.Users);

#line default
#line hidden
            EndContext();
            BeginContext(190, 52, true);
            WriteLiteral("</h3>\r\n            <ul>\r\n                <li>Email: ");
            EndContext();
            BeginContext(243, 6, false);
#line 10 "C:\administration-project\UserAdmin\UserAdmin\Views\App\UsersList.cshtml"
                      Write(u.Mail);

#line default
#line hidden
            EndContext();
            BeginContext(249, 32, true);
            WriteLiteral("</li>\r\n                <li>Sex: ");
            EndContext();
            BeginContext(282, 5, false);
#line 11 "C:\administration-project\UserAdmin\UserAdmin\Views\App\UsersList.cshtml"
                    Write(u.Sex);

#line default
#line hidden
            EndContext();
            BeginContext(287, 35, true);
            WriteLiteral("</li>\r\n                <li>Status: ");
            EndContext();
            BeginContext(323, 8, false);
#line 12 "C:\administration-project\UserAdmin\UserAdmin\Views\App\UsersList.cshtml"
                       Write(u.Status);

#line default
#line hidden
            EndContext();
            BeginContext(331, 42, true);
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n");
            EndContext();
#line 15 "C:\administration-project\UserAdmin\UserAdmin\Views\App\UsersList.cshtml"
    }

#line default
#line hidden
            BeginContext(380, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
