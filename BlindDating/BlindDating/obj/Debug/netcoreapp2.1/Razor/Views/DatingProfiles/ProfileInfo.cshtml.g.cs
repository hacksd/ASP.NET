#pragma checksum "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c12eced8626825f8660ddd08656fec6955f003f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DatingProfiles_ProfileInfo), @"mvc.1.0.view", @"/Views/DatingProfiles/ProfileInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DatingProfiles/ProfileInfo.cshtml", typeof(AspNetCore.Views_DatingProfiles_ProfileInfo))]
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
#line 1 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\_ViewImports.cshtml"
using BlindDating;

#line default
#line hidden
#line 2 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\_ViewImports.cshtml"
using BlindDating.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c12eced8626825f8660ddd08656fec6955f003f7", @"/Views/DatingProfiles/ProfileInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d75efb289100ece7bcf7105f9f98b019543e6be", @"/Views/_ViewImports.cshtml")]
    public class Views_DatingProfiles_ProfileInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlindDating.Models.DatingProfile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 127, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>DatingProfile</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(214, 45, false);
#line 14 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(259, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(303, 41, false);
#line 17 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(344, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(388, 44, false);
#line 20 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(432, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(476, 40, false);
#line 23 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(516, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(560, 39, false);
#line 26 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(599, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(643, 35, false);
#line 29 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(678, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(722, 42, false);
#line 32 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(764, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(808, 38, false);
#line 35 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(846, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(890, 39, false);
#line 38 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.Bio));

#line default
#line hidden
            EndContext();
            BeginContext(929, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(973, 35, false);
#line 41 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.Bio));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1052, 49, false);
#line 44 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml"
       Write(Html.DisplayNameFor(model => model.UserAccountId));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1145, 45, false);
#line 47 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml"
       Write(Html.DisplayFor(model => model.UserAccountId));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1237, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "483eeec7504640b792e932c12a89d6cc", async() => {
                BeginContext(1283, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\ACT-Student\source\repos\hacksd\ASP.NET\BlindDating\BlindDating\Views\DatingProfiles\ProfileInfo.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(1291, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1299, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f559579b726b4f159e8ee3d2637de617", async() => {
                BeginContext(1321, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1337, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlindDating.Models.DatingProfile> Html { get; private set; }
    }
}
#pragma warning restore 1591
