#pragma checksum "H:\Interview DotNet\Tasks\Microtech\Developers Practical Exam\Microtech_WebApiTask_3\Microtech_WebApiTask_3\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c0c2a91cd3ac0c32a6608e85357e535cdb3029c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microtech_WebApiTask_3.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Microtech_WebApiTask_3.Pages
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
#line 1 "H:\Interview DotNet\Tasks\Microtech\Developers Practical Exam\Microtech_WebApiTask_3\Microtech_WebApiTask_3\Pages\_ViewImports.cshtml"
using Microtech_WebApiTask_3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c0c2a91cd3ac0c32a6608e85357e535cdb3029c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe252de8820a01e0428efb1c77f2be751f47c777", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "H:\Interview DotNet\Tasks\Microtech\Developers Practical Exam\Microtech_WebApiTask_3\Microtech_WebApiTask_3\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome</h1>\n    <p>This exam is developed By Ahmed M. Saad</p>\n");
#nullable restore
#line 10 "H:\Interview DotNet\Tasks\Microtech\Developers Practical Exam\Microtech_WebApiTask_3\Microtech_WebApiTask_3\Pages\Index.cshtml"
     if (Model.Accounts != null && Model.Accounts.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-striped\">\n        <thead>\n            <tr>\n                <th>Top Level Account</th>\n                <th>Total Balance</th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 20 "H:\Interview DotNet\Tasks\Microtech\Developers Practical Exam\Microtech_WebApiTask_3\Microtech_WebApiTask_3\Pages\Index.cshtml"
             foreach (var item in Model.Accounts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("ondblclick", " ondblclick=\"", 535, "\"", 575, 3);
            WriteAttributeValue("", 548, "callToGetDetail(\'", 548, 17, true);
#nullable restore
#line 22 "H:\Interview DotNet\Tasks\Microtech\Developers Practical Exam\Microtech_WebApiTask_3\Microtech_WebApiTask_3\Pages\Index.cshtml"
WriteAttributeValue("", 565, item.Id, 565, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 573, "\')", 573, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\n                    <td>");
#nullable restore
#line 23 "H:\Interview DotNet\Tasks\Microtech\Developers Practical Exam\Microtech_WebApiTask_3\Microtech_WebApiTask_3\Pages\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 24 "H:\Interview DotNet\Tasks\Microtech\Developers Practical Exam\Microtech_WebApiTask_3\Microtech_WebApiTask_3\Pages\Index.cshtml"
                   Write(Math.Round(item.Total, 0));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 26 "H:\Interview DotNet\Tasks\Microtech\Developers Practical Exam\Microtech_WebApiTask_3\Microtech_WebApiTask_3\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
#nullable restore
#line 29 "H:\Interview DotNet\Tasks\Microtech\Developers Practical Exam\Microtech_WebApiTask_3\Microtech_WebApiTask_3\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<script>
    function callToGetDetail(id) {
        $.ajax({
            url: ""api/account"",
            contentType: 'json',
            type: ""get"", //send it through get method
            data: { id: id},
            success: function(response) {
                alert(response);
            },
            error: function(xhr) {
                alert(xhr);
            }
        });
    }
</script>


");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
