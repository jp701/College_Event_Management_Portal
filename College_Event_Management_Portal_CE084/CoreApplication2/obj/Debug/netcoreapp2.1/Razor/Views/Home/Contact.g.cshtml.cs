#pragma checksum "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b0edcc610bb2fee61cc0faff05532bb0f453606"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b0edcc610bb2fee61cc0faff05532bb0f453606", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b3da4d8ecc442f87aa6f8201af686a0802108db", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jinal\source\repos\CoreApplication2\CoreApplication2\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact Us";

#line default
#line hidden
            BeginContext(46, 825, true);
            WriteLiteral(@"
<h2 class=""text-primary text-center"">Get in touch with Us</h2>
<hr />
<h5 class=""text-center"">Have a question or comment? Drop us a line</h5>
<br />

<div class=""row text-center w-75 mx-auto"">
    <div class=""col-sm"">
        <i class=""fa fa-user-circle-o"" style=""font-size:60px""></i><br />
        <p class=""font-weight-bold text-primary"">Owner</p>
        <p>Jinal Panchal</p>
    </div>
    <div class=""col-sm"">
        <i class=""fa fa-phone"" style=""font-size:60px""></i> <br />
        <p class=""font-weight-bold text-primary"">Call Us</p>
        <p>+91 8320321415</p>
    </div>
    <div class=""col-sm"">
        <i class=""fa fa-envelope-o"" style=""font-size:60px""></i><br />
        <p class=""font-weight-bold text-primary"">Email Us</p>
        <p>jinalpanchal041@gmail.com</p>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
