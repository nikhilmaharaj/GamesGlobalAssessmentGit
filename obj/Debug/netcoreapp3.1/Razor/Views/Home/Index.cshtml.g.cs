#pragma checksum "C:\Users\user-pc\Desktop\GamesGlobalGit\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cfd9292c4251ce890916dc8cc78f57ffeaeb0c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\user-pc\Desktop\GamesGlobalGit\Views\_ViewImports.cshtml"
using GamesGlobalAssessment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user-pc\Desktop\GamesGlobalGit\Views\_ViewImports.cshtml"
using GamesGlobalAssessment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cfd9292c4251ce890916dc8cc78f57ffeaeb0c3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b654c759d1b9414e553539eb347a3797ad49ca7c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user-pc\Desktop\GamesGlobalGit\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "TV Show Tracker System";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cfd9292c4251ce890916dc8cc78f57ffeaeb0c33436", async() => {
                WriteLiteral(@"
    <div class=""row md-Padding-Top-50"">
    </div>
    <div class=""row md-Padding-Top-50"">
        <div class=""col-md-12"">
            <h1 class=""control-label md-Padding-Top-5 align-center"">Welcome</h1>
        </div>
    </div>
    <div class=""row md-Padding-Top-100"">
        <div id=""divTVShow"" title=""Go to TV Show List"" onclick=""Navigate(id)"" class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
            <div class=""info-box bg-blue hover-expand-effect mousePointer"">
                <div class=""icon"">
                    <i class=""material-icons"">tv</i>
                </div>
                <div class=""content"">
                    <div class=""text"">TV Show List</div>
                    <div class=""number count-to"" data-from=""0"" data-speed=""1000"" data-fresh-interval=""20""></div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row md-Padding-Top-100"">
        <div id=""divIMDB"" title=""Go to IMDB List"" onclick=""Navigate(id)"" class=""col-lg-12 col-md-12");
                WriteLiteral(@" col-sm-12 col-xs-12"">
            <div class=""info-box bg-orange hover-expand-effect mousePointer"">
                <div class=""icon"">
                    <i class=""material-icons"">dvr</i>
                </div>
                <div class=""content"">
                    <div class=""text"">IMDB List</div>
                    <div class=""number count-to"" data-from=""0"" data-speed=""1000"" data-fresh-interval=""20""></div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row md-Padding-Top-100"">
        <div id=""divAboutUs"" title=""Go to About Us"" onclick=""Navigate(id)"" class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
            <div class=""info-box bg-brown hover-expand-effect mousePointer"">
                <div class=""icon"">
                    <i class=""material-icons"">info</i>
                </div>
                <div class=""content"">
                    <div class=""text"">About Us</div>
                </div>
            </div>
        </div>
    </div>
");
                WriteLiteral("    <div class=\"row md-Padding-Top-50\">\r\n    </div>\r\n    <div class=\"row md-Padding-Top-10\">\r\n    </div>\r\n    <div class=\"row md-Padding-Top-10\">\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 73, "background:", 73, 11, true);
            AddHtmlAttributeValue(" ", 84, "url(\'", 85, 6, true);
#nullable restore
#line 5 "C:\Users\user-pc\Desktop\GamesGlobalGit\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 90, Url.Content("~/css/images/tv2.jpg"), 90, 36, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 126, "\');", 126, 3, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    function Navigate(Id) {
        switch (Id) {
            case 'divTVShow':
                window.location.href = '/TVShowList/Index';
                break;
            case 'divIMDB':
                window.location.href = '/IMDB/Index';
                break;
            case 'divAboutUs':
                window.location.href = '/Home/AboutUs';
                break;
            default:
                window.location.href = 'Index';
                break;
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
