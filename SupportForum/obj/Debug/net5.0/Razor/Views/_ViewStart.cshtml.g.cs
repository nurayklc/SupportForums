#pragma checksum "E:\projeler\SupportForums\SupportForum\Views\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7091c65830b0329e613be026ede8a57552863778"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__ViewStart), @"mvc.1.0.view", @"/Views/_ViewStart.cshtml")]
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
#nullable restore
#line 1 "E:\projeler\SupportForums\SupportForum\Views\_ViewImports.cshtml"
using SupportForum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projeler\SupportForums\SupportForum\Views\_ViewImports.cshtml"
using SupportForum.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\projeler\SupportForums\SupportForum\Views\_ViewImports.cshtml"
using SupportForum.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\projeler\SupportForums\SupportForum\Views\_ViewImports.cshtml"
using SupportForum.Models.Forum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\projeler\SupportForums\SupportForum\Views\_ViewImports.cshtml"
using SupportForum.Models.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\projeler\SupportForums\SupportForum\Views\_ViewImports.cshtml"
using SupportForum.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\projeler\SupportForums\SupportForum\Views\_ViewImports.cshtml"
using SupportForum.Models.Search;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\projeler\SupportForums\SupportForum\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7091c65830b0329e613be026ede8a57552863778", @"/Views/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe95ddb6d166ce3f89d5b5bc23d1ab96589e64c9", @"/Views/_ViewImports.cshtml")]
    public class Views__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\projeler\SupportForums\SupportForum\Views\_ViewStart.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
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
