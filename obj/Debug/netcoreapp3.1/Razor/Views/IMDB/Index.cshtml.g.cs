#pragma checksum "C:\Users\user-pc\Desktop\GamesGlobalGit\Views\IMDB\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "404d2366305ea931200d8bee289cc89fe0fbfc14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IMDB_Index), @"mvc.1.0.view", @"/Views/IMDB/Index.cshtml")]
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
using React.AspNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user-pc\Desktop\GamesGlobalGit\Views\_ViewImports.cshtml"
using GamesGlobalAssessment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user-pc\Desktop\GamesGlobalGit\Views\_ViewImports.cshtml"
using GamesGlobalAssessment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"404d2366305ea931200d8bee289cc89fe0fbfc14", @"/Views/IMDB/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312d8bacca5e4d367179164d80dbad26a7d42678", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_IMDB_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\user-pc\Desktop\GamesGlobalGit\Views\IMDB\Index.cshtml"
  
    ViewData["Title"] = "IMDB TV Show List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "404d2366305ea931200d8bee289cc89fe0fbfc143598", async() => {
                WriteLiteral(@"
    <div class=""row md-Padding-Top-50"">
    </div>
    <div class=""row md-Padding-Top-50"">
        <div class=""col-md-12"">
            <h1 class=""control-label md-Padding-Top-5 align-center"">IMDB TV Show List</h1>
        </div>
    </div>
    <div class=""well white md-Padding-Top-50"">
        <div class=""row md-Padding-Bottom-15 md-Padding-left-15"">
            <div class=""col-md-2 md-Padding-left-15"">
                ");
#nullable restore
#line 16 "C:\Users\user-pc\Desktop\GamesGlobalGit\Views\IMDB\Index.cshtml"
           Write(Html.TextBox("search", null, new { @class = "form-control", @placeholder = "Search by Title" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
            <div class=""col-md-1"">
                <input type=""submit"" value=""Search"" class=""btn btn-block btn-info"" />
            </div>
        </div>
        <div class=""row md-Padding-Top-100"">
            <ul style=""list-style:none; display:inline-block; overflow-y:scroll;"" id=""lstTVShows""></ul>
            
        </div>
    </div>
    <div class=""row md-Padding-Top-170"">
        <div class=""col-md-12"">
        </div>
    </div>
    <div class=""row md-Padding-Top-100"">
        <div class=""col-md-12"">
        </div>
    </div>
    <div class=""row md-Padding-Top-170"">
        <div class=""col-md-12"">
            <h1 class=""control-label md-Padding-Top-5 align-center"">This is a free API, so there wasn't much I could do with it</h1>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 68, "background:", 68, 11, true);
            AddHtmlAttributeValue(" ", 79, "url(\'", 80, 6, true);
#nullable restore
#line 5 "C:\Users\user-pc\Desktop\GamesGlobalGit\Views\IMDB\Index.cshtml"
AddHtmlAttributeValue("", 85, Url.Content("~/css/images/tv.jpg"), 85, 35, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 120, "\');", 120, 3, true);
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
    const options = {
        method: 'GET',
        headers: {
            'X-RapidAPI-Key': '1e8b993acdmsh534d473626853b5p1196b1jsn69a4f4ae5e89',
            'X-RapidAPI-Host': 'mdblist.p.rapidapi.com'
        }
    };

    var json = fetch('https://mdblist.p.rapidapi.com/?s=game&m=show', options)
        .then(response => response.json())
        .then(data => {
            const list = data.search;
            list.map((item) => {
                const name = item.title;
                document.getElementById(""lstTVShows"").innerHTML += name + ' , ';
            })
        })
        .catch(err => console.error(err));

        console.log(json);
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
