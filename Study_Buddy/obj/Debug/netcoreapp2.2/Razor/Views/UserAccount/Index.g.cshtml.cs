#pragma checksum "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6faec756acf23206ff7739b38d7d8099ef3ecde7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserAccount_Index), @"mvc.1.0.view", @"/Views/UserAccount/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserAccount/Index.cshtml", typeof(AspNetCore.Views_UserAccount_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6faec756acf23206ff7739b38d7d8099ef3ecde7", @"/Views/UserAccount/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"563b61fc0e4554a0b6c71230790c021970413200", @"/Views/_ViewImports.cshtml")]
    public class Views_UserAccount_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebUI.ViewModels.UserAccountViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn dot shadow-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Questions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Quizs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateFlashCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateQuiz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
  
    ViewData["Title"] = "UserIndex";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(142, 437, true);
            WriteLiteral(@"<style>
    #headText {
        pointer-events: none;
    }
</style>
<div class=""row"">
    <div class=""col-sm-4""></div>
    <div class=""col-sm-4 text-center"">
        <h1 id=""headText"" class=""nav-text text-center"">Study Material</h1>
        <h4 class=""text-center text-secondary"">The questions you have created and the quizzes you have taken</h4>
    </div>
    <div class=""col-sm-4""></div>
</div>
<p class=""pt-sm-4""></p>
");
            EndContext();
            BeginContext(579, 5791, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6faec756acf23206ff7739b38d7d8099ef3ecde77668", async() => {
                BeginContext(585, 59, true);
                WriteLiteral("\r\n    <div class=\"d-flex justify-content-around\">\r\n        ");
                EndContext();
                BeginContext(644, 125, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6faec756acf23206ff7739b38d7d8099ef3ecde78112", async() => {
                    BeginContext(720, 45, true);
                    WriteLiteral("<b class=\"dot-text\">Create a new question</b>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(769, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(779, 130, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6faec756acf23206ff7739b38d7d8099ef3ecde79922", async() => {
                    BeginContext(860, 45, true);
                    WriteLiteral("<b class=\"dot-text\">Start with flashcards</b>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(909, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(919, 120, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6faec756acf23206ff7739b38d7d8099ef3ecde711732", async() => {
                    BeginContext(995, 40, true);
                    WriteLiteral("<b class=\"dot-text\">Begin a new quiz</b>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1039, 1420, true);
                WriteLiteral(@"
    </div>
    <div class=""row pt-3""></div>
    <div class=""d-flex justify-content-lg-center"">
        <button class=""btn"" data-toggle=""modal"" data-target=""#quizmodal"">
            <h1 style=""border-bottom:none"" class=""nav-text"">Your Quizzes</h1>
        </button>
        <div class=""col-sm-2""></div>
        <button class=""btn"" data-toggle=""modal"" data-target=""#questionmodal"">
            <h1 style=""border-bottom:none"" class=""nav-text"">Your Questions</h1>
        </button>
    </div>
    <div class=""modal fade"" id=""quizmodal"">
        <div class=""modal-dialog modal-dialog-centered modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-body"">
                    <table class=""table table-responsive text-white"">
                        <thead>
                            <tr>
                                <th>
                                    Quiz
                                </th>
                                <th>
                                ");
                WriteLiteral(@"    Topic
                                </th>
                                <th>
                                    Score
                                </th>
                                <th>
                                    Topic Avg
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
                EndContext();
#line 60 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                             if (Model.Quizzes != null)
                            {
                                

#line default
#line hidden
#line 62 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                 foreach (var item in Model.Quizzes)
                                {

#line default
#line hidden
                BeginContext(2652, 132, true);
                WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(2785, 41, false);
#line 66 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.QuizID));

#line default
#line hidden
                EndContext();
                BeginContext(2826, 139, true);
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(2966, 52, false);
#line 69 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Topic.Description));

#line default
#line hidden
                EndContext();
                BeginContext(3018, 139, true);
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(3158, 40, false);
#line 72 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Score));

#line default
#line hidden
                EndContext();
                BeginContext(3198, 140, true);
                WriteLiteral("%\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(3339, 59, false);
#line 75 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                       Write(Html.DisplayFor(Model => Model.TopicAverages[item.TopicID]));

#line default
#line hidden
                EndContext();
                BeginContext(3398, 144, true);
                WriteLiteral("%\r\n                                        </td>\r\n\r\n\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(3542, 120, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6faec756acf23206ff7739b38d7d8099ef3ecde718032", async() => {
                    BeginContext(3651, 7, true);
                    WriteLiteral("Details");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 80 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                                                                                                               WriteLiteral(item.QuizID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3662, 92, true);
                WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
                EndContext();
#line 83 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                }

#line default
#line hidden
#line 83 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                 
                            }

#line default
#line hidden
                BeginContext(3820, 982, true);
                WriteLiteral(@"
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""questionmodal"">
        <div class=""modal-dialog modal-dialog-centered modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-body"">
                    <table class=""table table-responsive text-white"">
                        <thead>
                            <tr>
                                <th>
                                    Body
                                </th>
                                <th>
                                    Answer
                                </th>
                                <th>
                                    Topic
                                </th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
");
                EndContext();
#line 113 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                             if (Model.Questions != null)
                            {
                                

#line default
#line hidden
#line 115 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                 foreach (var item in Model.Questions)
                                {

#line default
#line hidden
                BeginContext(4999, 132, true);
                WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(5132, 39, false);
#line 119 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Body));

#line default
#line hidden
                EndContext();
                BeginContext(5171, 139, true);
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(5311, 41, false);
#line 122 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Answer));

#line default
#line hidden
                EndContext();
                BeginContext(5352, 139, true);
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(5492, 52, false);
#line 125 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Topic.Description));

#line default
#line hidden
                EndContext();
                BeginContext(5544, 139, true);
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                EndContext();
                BeginContext(5683, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6faec756acf23206ff7739b38d7d8099ef3ecde724876", async() => {
                    BeginContext(5763, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 128 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                                                                              WriteLiteral(item.QuestionID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5771, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(5817, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6faec756acf23206ff7739b38d7d8099ef3ecde727653", async() => {
                    BeginContext(5900, 7, true);
                    WriteLiteral("Details");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 129 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                                                                                 WriteLiteral(item.QuestionID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5911, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(5957, 112, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6faec756acf23206ff7739b38d7d8099ef3ecde730437", async() => {
                    BeginContext(6059, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 130 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                                                                                                    WriteLiteral(item.QuestionID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6069, 92, true);
                WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
                EndContext();
#line 133 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                }

#line default
#line hidden
#line 133 "C:\Users\hamel\Source\Repos\jthams\QuizLash\Study_Buddy\Views\UserAccount\Index.cshtml"
                                 
                            }

#line default
#line hidden
                BeginContext(6227, 136, true);
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6370, 2, true);
            WriteLiteral("\r\n");
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
