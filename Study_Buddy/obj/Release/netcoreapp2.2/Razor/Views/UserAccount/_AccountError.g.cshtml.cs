#pragma checksum "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\_AccountError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41bc838b31dcfbcb5e8ec05e02da2ae6e7e6186e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserAccount__AccountError), @"mvc.1.0.view", @"/Views/UserAccount/_AccountError.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserAccount/_AccountError.cshtml", typeof(AspNetCore.Views_UserAccount__AccountError))]
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
#line 1 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#line 2 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\_ViewImports.cshtml"
using Domain.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41bc838b31dcfbcb5e8ec05e02da2ae6e7e6186e", @"/Views/UserAccount/_AccountError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"563b61fc0e4554a0b6c71230790c021970413200", @"/Views/_ViewImports.cshtml")]
    public class Views_UserAccount__AccountError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebUI.ViewModels.UserAccountViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\_AccountError.cshtml"
  
    ViewData["Title"] = "_AccountError";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 152, true);
            WriteLiteral("\r\n<h1 class=\"alert-danger text-center font-weight-bold\">Error</h1>\r\n\r\n<p class=\"text-danger font-weight-bold\">\r\n    Something Went Wrong\r\n</p>\r\n\r\n<ol>\r\n");
            EndContext();
#line 15 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\_AccountError.cshtml"
     foreach(var item in Model.Errors){

#line default
#line hidden
            BeginContext(337, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(346, 39, false);
#line 16 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\_AccountError.cshtml"
   Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
            EndContext();
            BeginContext(385, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(388, 46, false);
#line 16 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\_AccountError.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(434, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 17 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\_AccountError.cshtml"
    }

#line default
#line hidden
            BeginContext(448, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\_AccountError.cshtml"
     if(Model.ErrorMessage != null)
    {

#line default
#line hidden
            BeginContext(494, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(503, 36, false);
#line 21 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\_AccountError.cshtml"
   Write(Html.DisplayFor(m => m.ErrorMessage));

#line default
#line hidden
            EndContext();
            BeginContext(539, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 22 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\_AccountError.cshtml"
    }

#line default
#line hidden
            BeginContext(553, 13, true);
            WriteLiteral("\r\n\r\n</ol>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebUI.ViewModels.UserAccountViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
