#pragma checksum "C:\Users\Chad\Documents\dotNetCore\mywebapp\Pages\about.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7cbd3e5b80a8d38f327048ad4fca9095cd3d9fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_about), @"mvc.1.0.razor-page", @"/Pages/about.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/about.cshtml", typeof(AspNetCore.Pages_about), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7cbd3e5b80a8d38f327048ad4fca9095cd3d9fd", @"/Pages/about.cshtml")]
    public class Pages_about : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 65, true);
            WriteLiteral("\r\n<h2>This is the about page</h2>\r\n\r\n<strong>The current time is ");
            EndContext();
            BeginContext(73, 12, false);
#line 5 "C:\Users\Chad\Documents\dotNetCore\mywebapp\Pages\about.cshtml"
                       Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(85, 10, true);
            WriteLiteral(" </strong>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_about> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_about> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_about>)PageContext?.ViewData;
        public Pages_about Model => ViewData.Model;
    }
}
#pragma warning restore 1591
