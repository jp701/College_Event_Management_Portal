#pragma checksum "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c583dba3eceb0a545acaed1613a495eb888d5b43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EventDetails), @"mvc.1.0.view", @"/Views/Admin/EventDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/EventDetails.cshtml", typeof(AspNetCore.Views_Admin_EventDetails))]
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
#line 1 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\_ViewImports.cshtml"
using CoreApplication2;

#line default
#line hidden
#line 2 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\_ViewImports.cshtml"
using CoreApplication2.Models;

#line default
#line hidden
#line 3 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\_ViewImports.cshtml"
using CoreApplication2.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\_ViewImports.cshtml"
using CoreApplication2.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c583dba3eceb0a545acaed1613a495eb888d5b43", @"/Views/Admin/EventDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b3da4d8ecc442f87aa6f8201af686a0802108db", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EventDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreApplication2.Models.ClgEvent>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewEvents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
  
    ViewData["Title"] = "Event Details";
    var photoPath = "~/images/" + (Model.PhotoPath ?? "event1.jpg");


#line default
#line hidden
            BeginContext(164, 36, true);
            WriteLiteral("\r\n<h2>Event Details</h2>\r\n<hr />\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
 if (ViewBag.Msg != null)
{

#line default
#line hidden
            BeginContext(230, 285, true);
            WriteLiteral(@"    <div class=""alert alert-success alert-dismissable fade show w-75 mx-auto"" role=""alert"">
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
        <h5 class=""alert-heading"">");
            EndContext();
            BeginContext(516, 11, false);
#line 18 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
                             Write(ViewBag.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(527, 19, true);
            WriteLiteral("</h5>\r\n    </div>\r\n");
            EndContext();
#line 20 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
}

#line default
#line hidden
            BeginContext(549, 173, true);
            WriteLiteral("<div class=\"row justify-content-center m-3\">\r\n    <div class=\"col-sm-8\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header text-center\">\r\n                <h3>");
            EndContext();
            BeginContext(723, 11, false);
#line 25 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(734, 92, true);
            WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"card-body text-center\">\r\n                ");
            EndContext();
            BeginContext(826, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f05998894a648fe8ffcd1fc5e7c1cda", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
                                         WriteLiteral(photoPath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 28 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(903, 32, true);
            WriteLiteral("\r\n                <h6>Event ID: ");
            EndContext();
            BeginContext(936, 8, false);
#line 29 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
                         Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(944, 37, true);
            WriteLiteral("</h6>\r\n                <h6>Category: ");
            EndContext();
            BeginContext(982, 14, false);
#line 30 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
                         Write(Model.Category);

#line default
#line hidden
            EndContext();
            BeginContext(996, 33, true);
            WriteLiteral("</h6>\r\n                <h6>Date: ");
            EndContext();
            BeginContext(1030, 33, false);
#line 31 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
                     Write(Model.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 34, true);
            WriteLiteral("</h6>\r\n                <h6>Venue: ");
            EndContext();
            BeginContext(1098, 11, false);
#line 32 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
                      Write(Model.Venue);

#line default
#line hidden
            EndContext();
            BeginContext(1109, 35, true);
            WriteLiteral("</h6>\r\n                <h6>Status: ");
            EndContext();
            BeginContext(1145, 12, false);
#line 33 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
                       Write(Model.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1157, 83, true);
            WriteLiteral("</h6>\r\n                <h6>Description:</h6>\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(1241, 17, false);
#line 35 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
                                Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1258, 93, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"card-footer text-center\">\r\n                ");
            EndContext();
            BeginContext(1351, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "556f4a63723a478893cd2111287af2d7", async() => {
                BeginContext(1399, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1407, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1425, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f23edb1572054110be32dd1167d23477", async() => {
                BeginContext(1502, 6, true);
                WriteLiteral("Update");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
                                              WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1512, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1530, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02c1c1fd51a345a4bf8ba2cb3a3a1c53", async() => {
                BeginContext(1606, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Admin\EventDetails.cshtml"
                                              WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1616, 58, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreApplication2.Models.ClgEvent> Html { get; private set; }
    }
}
#pragma warning restore 1591
