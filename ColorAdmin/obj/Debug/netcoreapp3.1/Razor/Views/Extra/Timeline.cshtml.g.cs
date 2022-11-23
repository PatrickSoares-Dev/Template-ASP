#pragma checksum "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Extra\Timeline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a4d18efe195df055f1d5bff9aa46ddacf5060b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Extra_Timeline), @"mvc.1.0.view", @"/Views/Extra/Timeline.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a4d18efe195df055f1d5bff9aa46ddacf5060b9", @"/Views/Extra/Timeline.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bd241ee090bd8b39c0cf55b12cb73c6c44cc0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Extra_Timeline : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/demo/timeline.demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Extra\Timeline.cshtml"
  
  ViewData["Title"] = "Timeline";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t<script src=\"https://maps.googleapis.com/maps/api/js?v=3.exp&amp;sensor=false\"></script>\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a4d18efe195df055f1d5bff9aa46ddacf5060b94568", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
	<li class=""breadcrumb-item""><a href=""javascript:;"">Extra</a></li>
	<li class=""breadcrumb-item active"">Timeline</li>
</ol>
<!-- end breadcrumb -->
<!-- begin page-header -->
<h1 class=""page-header"">Timeline <small>header small text goes here...</small></h1>
<!-- end page-header -->
<!-- begin timeline -->
<ul class=""timeline"">
	<li>
		<!-- begin timeline-time -->
		<div class=""timeline-time"">
			<span class=""date"">today</span>
			<span class=""time"">04:20</span>
		</div>
		<!-- end timeline-time -->
		<!-- begin timeline-icon -->
		<div class=""timeline-icon"">
			<a href=""javascript:;"">&nbsp;</a>
		</div>
		<!-- end timeline-icon -->
		<!-- begin timeline-body -->
		<div class=""timeline-body"">
			<div class=""timeline-header"">
				<span class=""userimage""><img src=""/img/user/user-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1162, "\"", 1168, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></span>
				<span class=""username""><a href=""javascript:;"">John Smith</a> <small></small></span>
				<span class=""views"">18 Views</span>
			</div>
			<div class=""timeline-content"">
				<p>
					Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc faucibus turpis quis tincidunt luctus.
					Nam sagittis dui in nunc consequat, in imperdiet nunc sagittis.
				</p>
			</div>
			<div class=""timeline-likes"">
				<div class=""stats"">
					<span class=""fa-stack fa-fw stats-icon"">
					<i class=""fa fa-circle fa-stack-2x text-danger""></i>
					<i class=""fa fa-heart fa-stack-1x fa-inverse t-plus-1""></i>
					</span>
					<span class=""fa-stack fa-fw stats-icon"">
					<i class=""fa fa-circle fa-stack-2x text-primary""></i>
					<i class=""fa fa-thumbs-up fa-stack-1x fa-inverse""></i>
					</span>
					<span class=""stats-total"">4.3k</span>
				</div>
				<div class=""stats-right"">
					<span class=""stats-text"">259 Shares</span>
					<span class=""stats-text"">21 Comments</span>
				</div>
			</");
            WriteLiteral(@"div>
			<div class=""timeline-footer"">
				<a href=""javascript:;"" class=""m-r-15 text-inverse-lighter""><i class=""fa fa-thumbs-up fa-fw fa-lg m-r-3""></i> Like</a>
				<a href=""javascript:;"" class=""m-r-15 text-inverse-lighter""><i class=""fa fa-comments fa-fw fa-lg m-r-3""></i> Comment</a> 
				<a href=""javascript:;"" class=""m-r-15 text-inverse-lighter""><i class=""fa fa-share fa-fw fa-lg m-r-3""></i> Share</a>
			</div>
			<div class=""timeline-comment-box"">
				<div class=""user""><img src=""/img/user/user-13.jpg"" /></div>
				<div class=""input"">
					");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a4d18efe195df055f1d5bff9aa46ddacf5060b98518", async() => {
                WriteLiteral(@"
						<div class=""input-group"">
							<input type=""text"" class=""form-control rounded-corner"" placeholder=""Write a comment..."" />
							<span class=""input-group-btn p-l-10"">
							<button class=""btn btn-primary f-s-12 rounded-corner"" type=""button"">Comment</button>
							</span>
						</div>
					");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
				</div>
			</div>
		</div>
		<!-- end timeline-body -->
	</li>
	<li>
		<!-- begin timeline-time -->
		<div class=""timeline-time"">
			<span class=""date"">yesterday</span>
			<span class=""time"">20:17</span>
		</div>
		<!-- end timeline-time -->
		<!-- begin timeline-icon -->
		<div class=""timeline-icon"">
			<a href=""javascript:;"">&nbsp;</a>
		</div>
		<!-- end timeline-icon -->
		<!-- begin timeline-body -->
		<div class=""timeline-body"">
			<div class=""timeline-header"">
				<span class=""userimage""><img src=""/img/user/user-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3634, "\"", 3640, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></span>
				<span class=""username"">Darren Parrase</span>
				<span class=""views"">82 Views</span>
			</div>
			<div class=""timeline-content"">
				<p>Location: United States</p>
				<div id=""google-map"" class=""height-sm m-b-10""></div>
			</div>
			<div class=""timeline-footer"">
				<a href=""javascript:;"" class=""m-r-15 text-inverse-lighter""><i class=""fa fa-thumbs-up fa-fw fa-lg m-r-3""></i> Like</a>
				<a href=""javascript:;"" class=""m-r-15 text-inverse-lighter""><i class=""fa fa-comments fa-fw fa-lg m-r-3""></i> Comment</a> 
				<a href=""javascript:;"" class=""m-r-15 text-inverse-lighter""><i class=""fa fa-share fa-fw fa-lg m-r-3""></i> Share</a>
			</div>
		</div>
		<!-- end timeline-body -->
	</li>
	<li>
		<!-- begin timeline-time -->
		<div class=""timeline-time"">
			<span class=""date"">24 February 2014</span>
			<span class=""time"">08:17</span>
		</div>
		<!-- end timeline-time -->
		<!-- begin timeline-icon -->
		<div class=""timeline-icon"">
			<a href=""javascript:;"">&nbsp;</a>
		</div>
		<!");
            WriteLiteral("-- end timeline-icon -->\r\n\t\t<!-- begin timeline-body -->\r\n\t\t<div class=\"timeline-body\">\r\n\t\t\t<div class=\"timeline-header\">\r\n\t\t\t\t<span class=\"userimage\"><img src=\"/img/user/user-6.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4847, "\"", 4853, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></span>
				<span class=""username"">Richard Leong</span>
				<span class=""views"">1,282 Views</span>
			</div>
			<div class=""timeline-content"">
				<p class=""lead"">
					<i class=""fa fa-quote-left fa-fw pull-left""></i>
					Quisque sed varius nisl. Nulla facilisi. Phasellus consequat sapien sit amet nibh molestie placerat. Donec nulla quam, ullamcorper ut velit vitae, lobortis condimentum magna. Suspendisse mollis in sem vel mollis.
					<i class=""fa fa-quote-right fa-fw pull-right""></i>
				</p>
			</div>
			<div class=""timeline-footer"">
				<a href=""javascript:;"" class=""m-r-15 text-inverse-lighter""><i class=""fa fa-thumbs-up fa-fw fa-lg m-r-3""></i> Like</a>
				<a href=""javascript:;"" class=""m-r-15 text-inverse-lighter""><i class=""fa fa-comments fa-fw fa-lg m-r-3""></i> Comment</a> 
				<a href=""javascript:;"" class=""m-r-15 text-inverse-lighter""><i class=""fa fa-share fa-fw fa-lg m-r-3""></i> Share</a>
			</div>
		</div>
		<!-- end timeline-body -->
	</li>
	<li>
		<!-- begin timeline-time -->");
            WriteLiteral(@"
		<div class=""timeline-time"">
			<span class=""date"">10 January 2014</span>
			<span class=""time"">20:43</span>
		</div>
		<!-- end timeline-time -->
		<!-- begin timeline-icon -->
		<div class=""timeline-icon"">
			<a href=""javascript:;"">&nbsp;</a>
		</div>
		<!-- end timeline-icon -->
		<!-- begin timeline-body -->
		<div class=""timeline-body"">
			<div class=""timeline-header"">
				<span class=""userimage""><img src=""/img/user/user-7.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6330, "\"", 6336, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></span>
				<span class=""username"">Lelouch Wong</span>
				<span class=""views"">1,021,282 Views</span>
			</div>
			<div class=""timeline-content"">
				<h4 class=""template-title"">
					<i class=""fa fa-map-marker-alt text-danger fa-fw""></i>
					795 Folsom Ave, Suite 600 San Francisco, CA 94107
				</h4>
				<p>In hac habitasse platea dictumst. Pellentesque bibendum id sem nec faucibus. Maecenas molestie, augue vel accumsan rutrum, massa mi rutrum odio, id luctus mauris nibh ut leo.</p>
				<p class=""m-t-20"">
					<img src=""/img/gallery/gallery-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6905, "\"", 6911, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
				</p>
			</div>
			<div class=""timeline-footer"">
				<a href=""javascript:;"" class=""m-r-15 text-inverse-lighter""><i class=""fa fa-thumbs-up fa-fw fa-lg m-r-3""></i> Like</a>
				<a href=""javascript:;"" class=""m-r-15 text-inverse-lighter""><i class=""fa fa-comments fa-fw fa-lg m-r-3""></i> Comment</a> 
				<a href=""javascript:;"" class=""m-r-15 text-inverse-lighter""><i class=""fa fa-share fa-fw fa-lg m-r-3""></i> Share</a>
			</div>
		</div>
		<!-- end timeline-body -->
	</li>
	<li>
		<!-- begin timeline-icon -->
		<div class=""timeline-icon"">
			<a href=""javascript:;"">&nbsp;</a>
		</div>
		<!-- end timeline-icon -->
		<!-- begin timeline-body -->
		<div class=""timeline-body"">
			Loading...
		</div>
		<!-- begin timeline-body -->
	</li>
</ul>
<!-- end timeline -->
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