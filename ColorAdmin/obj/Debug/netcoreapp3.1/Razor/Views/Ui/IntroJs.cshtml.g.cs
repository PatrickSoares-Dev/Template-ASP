#pragma checksum "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Ui\IntroJs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b966b947531e9dcd76a5aaf3e98b232704d83dc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ui_IntroJs), @"mvc.1.0.view", @"/Views/Ui/IntroJs.cshtml")]
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
#line 1 "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\_ViewImports.cshtml"
using studio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\_ViewImports.cshtml"
using studio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b966b947531e9dcd76a5aaf3e98b232704d83dc4", @"/Views/Ui/IntroJs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bd241ee090bd8b39c0cf55b12cb73c6c44cc0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Ui_IntroJs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/intro.js/minified/introjs.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/intro.js/minified/intro.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Ui\IntroJs.cshtml"
  
  ViewData["Title"] = "Intro JS";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b966b947531e9dcd76a5aaf3e98b232704d83dc44560", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b966b947531e9dcd76a5aaf3e98b232704d83dc45857", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"

<!-- begin breadcrumb -->
<ol class=""breadcrumb float-xl-right"">
	<li class=""breadcrumb-item""><a href=""javascript:;"">Home</a></li>
	<li class=""breadcrumb-item""><a href=""javascript:;"">UI Elements</a></li>
	<li class=""breadcrumb-item active"">Intro JS</li>
</ol>
<!-- end breadcrumb -->
<!-- begin page-header -->
<h1 class=""page-header"">Intro JS <small>header small text goes here...</small></h1>
<!-- end page-header -->
			
<!-- begin jumbotron -->
<div class=""jumbotron text-center bg-white"">
	<h1 class=""display-4"" data-step=""1"" 
		data-intro=""Hello world! I'm Intro.js"" 
		data-hint=""Hello world! I'm Intro.js"" 
		data-hintPosition=""top-middle"" 
		data-position=""bottom-right-aligned"">Intro.js</h1>
	<p class=""lead mb-4"" data-step=""2"" 
		data-intro=""This is a simple step-by-step guide made using Intro.js""
		data-hint=""This is a simple step-by-step guide made using Intro.js"" 
		data-hintPosition=""top-middle"" 
		data-position=""bottom-right-aligned"">Step-by-step guide and feature introduction<");
            WriteLiteral(@"/p>
	<div class=""mb-3"">
		<a class=""btn btn-lg btn-primary pl-5 pr-5"" href=""javascript:void(0);"" onclick=""javascript:introJs().start();"">Demo</a>
	</div>
	<a href=""http://introjs.com/"" target=""_blank"" class=""text-gray"" data-step=""5"" 
		data-intro=""Intro.js is free and open-source. View it.""
		data-hint=""Intro.js is free and open-source. View it."" 
		data-hintPosition=""top-middle"" 
		data-position=""bottom-right-aligned"">View Official Website</a>
</div>
<!-- end jumbotron -->
<!-- begin row -->
<div class=""row text-center"" data-step=""3"" 
	data-intro=""Another step. Intro.js main features!"" 
	data-hint=""Another step. Intro.js main features!"" 
	data-hintPosition=""top-middle"" 
	data-position=""bottom-right-aligned"">
	<!-- begin col-4 -->
	<div class=""col-lg-4"">
		<div class=""m-b-10""><i class=""fa fa-compress fa-5x text-indigo""></i></div>
		<h5 class=""m-b-5"">No dependencies, fast and small</h5> 
		<p>10KB JavaScript and 2.5KB CSS, that's all (minified, gzipped).</p>
	</div>
	<!-- end col-4 -->
");
            WriteLiteral(@"	<!-- begin col-4 -->
	<div class=""col-lg-4"">
		<div class=""m-b-10""><i class=""fa fa-child fa-5x text-blue""></i></div>
		<h5 class=""m-b-5"">User-friendly</h5> 
		<p>Navigate using keyboard or mouse. Easily change the themes for your website.</p>
	</div>
	<!-- end col-4 -->
	<!-- begin col-4 -->
	<div class=""col-lg-4"">
		<div class=""m-b-10""><i class=""fa fa-globe fa-5x text-success""></i></div>
		<h5 class=""m-b-5"">Browser compatibility</h5> 
		<p>Works on Google Chrome, Mozilla Firefox, Opera, Safari and even Internet Explorer.</p>
	</div>
	<!-- end col-4 -->
</div>
<!-- end row -->
			
<h4>Examples</h4>

<!-- begin row -->
<div class=""row"">
	<!-- end col-4 -->
	<div class=""col-lg-4"">
		<!-- begin panel -->
		<div class=""panel"">
			<div class=""panel-body"">
				<h4><i class=""fa fa-bars fa-fw""></i> Progress bar</h4>
				<p>
					Add progress-bar to your step-by-step introduction. It's as easy as adding <code>.setOption('showProgress', true)</code> option to your Intro.js instance.
				</");
            WriteLiteral(@"p>
				<a href=""javascript:;"" class=""btn btn-primary btn-sm"" onclick=""javascript:introJs().setOption('showProgress', true).start();"">Demo</a>
			</div>
		</div>
		<!-- end panel -->
	</div>
	<!-- begin col-4 -->
	<!-- end col-4 -->
	<div class=""col-lg-4"">
		<!-- begin panel -->
		<div class=""panel"" data-intro=""Intro.js has many examples. Browse this section to find out more."" data-step=""4"">
			<div class=""panel-body"">
				<h4><i class=""fa fa-comment-alt fa-fw""></i> Hint</h4>
				<p>
					Hints enables you to add additional descriptions to any part of a web page. You can define hints by adding <code>data-hint</code> attribute to the HTML elements.
				</p>
				<a href=""javascript:;"" class=""btn btn-primary btn-sm"" onclick=""javascript:introJs().addHints();"">Demo</a>
			</div>
		</div>
		<!-- end panel -->
	</div>
	<!-- begin col-4 -->
	<!-- end col-4 -->
	<div class=""col-lg-4"">
		<!-- begin panel -->
		<div class=""panel"">
			<div class=""panel-body"">
				<h4><i class=""fa fa-filter fa-fw");
            WriteLiteral(@"""></i> Enable/disable options</h4>
				<p>
					You can enable or disable options like buttons, progress-bar and bullets by calling the <code>setOption('showBullets', false)</code> function and pass option name.
				</p>
				<a href=""javascript:;"" class=""btn btn-primary btn-sm"" onclick=""javascript:introJs().setOption('showBullets', false).start();"">Demo</a>
			</div>
		</div>
		<!-- end panel -->
	</div>
	<!-- end col-4 -->
</div>
<!-- end row -->
");
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
