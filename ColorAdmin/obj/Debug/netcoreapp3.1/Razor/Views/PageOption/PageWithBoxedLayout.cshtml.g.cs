#pragma checksum "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\PageOption\PageWithBoxedLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66d3c9cbed8ab0ba99a9724c5836614170c3b83f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PageOption_PageWithBoxedLayout), @"mvc.1.0.view", @"/Views/PageOption/PageWithBoxedLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d3c9cbed8ab0ba99a9724c5836614170c3b83f", @"/Views/PageOption/PageWithBoxedLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bd241ee090bd8b39c0cf55b12cb73c6c44cc0b", @"/Views/_ViewImports.cshtml")]
    public class Views_PageOption_PageWithBoxedLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\PageOption\PageWithBoxedLayout.cshtml"
  
  ViewData["Title"] = "Page with Boxed Layout";
  ViewData["BodyClass"] = "boxed-layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- begin breadcrumb -->
<ol class=""breadcrumb"">
	<li class=""breadcrumb-item""><a href=""javascript:;"">Home</a></li>
	<li class=""breadcrumb-item""><a href=""javascript:;"">Page Options</a></li>
	<li class=""breadcrumb-item active"">Page with Boxed Layout</li>
</ol>
<!-- end breadcrumb -->
<!-- begin page-header -->
<h1 class=""page-header"">Page with Boxed Layout <small>header small text goes here...</small></h1>
<!-- end page-header -->

<!-- begin panel -->
<div class=""panel panel-inverse"">
	<div class=""panel-heading"">
		<h4 class=""panel-title"">Panel Title here</h4>
		<div class=""panel-heading-btn"">
			<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
			<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
			<a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i><");
            WriteLiteral("/a>\r\n\t\t\t<a href=\"javascript:;\" class=\"btn btn-xs btn-icon btn-circle btn-danger\" data-click=\"panel-remove\"><i class=\"fa fa-times\"></i></a>\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"panel-body\">\r\n\t\tPanel Content Here\r\n\t</div>\r\n</div>\r\n<!-- end panel -->");
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
