#pragma checksum "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Email\Compose.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84021fd26c69301b04482b0b410b3bcfc593c4fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Email_Compose), @"mvc.1.0.view", @"/Views/Email/Compose.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84021fd26c69301b04482b0b410b3bcfc593c4fb", @"/Views/Email/Compose.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bd241ee090bd8b39c0cf55b12cb73c6c44cc0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Email_Compose : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jvectormap-next/jquery-jvectormap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/tag-it/css/jquery.tagit.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap3-wysihtml5-bower/dist/bootstrap3-wysihtml5.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-migrate/dist/jquery-migrate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/tag-it/js/tag-it.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap3-wysihtml5-bower/dist/bootstrap3-wysihtml5.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/demo/email-compose.demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("email_to_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Email\Compose.cshtml"
  
  ViewData["Title"] = "Email - Compose";
  ViewData["PageContainerClass"] = "page-content-full-height";
  ViewData["PageContentClass"] = "content-full-width";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "84021fd26c69301b04482b0b410b3bcfc593c4fb7912", async() => {
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
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "84021fd26c69301b04482b0b410b3bcfc593c4fb9088", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "84021fd26c69301b04482b0b410b3bcfc593c4fb10264", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84021fd26c69301b04482b0b410b3bcfc593c4fb11562", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84021fd26c69301b04482b0b410b3bcfc593c4fb12660", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84021fd26c69301b04482b0b410b3bcfc593c4fb13758", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84021fd26c69301b04482b0b410b3bcfc593c4fb14856", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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

<!-- begin vertical-box -->
<div class=""vertical-box with-grid inbox bg-light"">
	<!-- begin vertical-box-column -->
	<div class=""vertical-box-column width-200"">
		<!-- begin vertical-box -->
		<div class=""vertical-box"">
			<!-- begin wrapper -->
			<div class=""wrapper"">
				<div class=""d-flex align-items-center justify-content-center"">
					<a href=""#emailNav"" data-toggle=""collapse"" class=""btn btn-inverse btn-sm mr-auto d-block d-lg-none"">
						<i class=""fa fa-cog""></i>
					</a>
					<a href=""/Email/Compose"" class=""btn btn-inverse p-l-40 p-r-40 btn-sm"">
						Compose
					</a>
				</div>
			</div>
			<!-- end wrapper -->
			<!-- begin vertical-box-row -->
			<div class=""vertical-box-row collapse d-lg-table-row"" id=""emailNav"">
				<!-- begin vertical-box-cell -->
				<div class=""vertical-box-cell"">
					<!-- begin vertical-box-inner-cell -->
					<div class=""vertical-box-inner-cell"">
						<!-- begin scrollbar -->
						<div data-scrollbar=""true"" data-height=""100%"">
							<!-- ");
            WriteLiteral(@"begin wrapper -->
							<div class=""wrapper p-0"">
								<div class=""nav-title""><b>FOLDERS</b></div>
								<ul class=""nav nav-inbox"">
									<li class=""active""><a href=""/Email/Inbox""><i class=""fa fa-inbox fa-fw m-r-5""></i> Inbox <span class=""badge pull-right"">52</span></a></li>
									<li><a href=""/Email/Inbox""><i class=""fa fa-flag fa-fw m-r-5""></i> Important</a></li>
									<li><a href=""/Email/Inbox""><i class=""fa fa-envelope fa-fw m-r-5""></i> Sent</a></li>
									<li><a href=""/Email/Inbox""><i class=""fa fa-pencil-alt fa-fw m-r-5""></i> Drafts</a></li>
									<li><a href=""/Email/Inbox""><i class=""fa fa-trash fa-fw m-r-5""></i> Trash</a></li>
								</ul>
								<div class=""nav-title""><b>LABEL</b></div>
								<ul class=""nav nav-inbox"">
									<li><a href=""javascript:;""><i class=""fa fa-fw f-s-10 m-r-5 fa-circle text-inverse""></i> Admin</a></li>
									<li><a href=""javascript:;""><i class=""fa fa-fw f-s-10 m-r-5 fa-circle text-blue""></i> Designer & Employer</a></li>
									<li><a ");
            WriteLiteral(@"href=""javascript:;""><i class=""fa fa-fw f-s-10 m-r-5 fa-circle text-success""></i> Staff</a></li>
									<li><a href=""javascript:;""><i class=""fa fa-fw f-s-10 m-r-5 fa-circle text-warning""></i> Sponsorer</a></li>
									<li><a href=""javascript:;""><i class=""fa fa-fw f-s-10 m-r-5 fa-circle text-danger""></i> Client</a></li>
								</ul>
							</div>
							<!-- end wrapper -->
						</div>
						<!-- end scrollbar -->
					</div>
					<!-- end vertical-box-inner-cell -->
				</div>
				<!-- end vertical-box-cell -->
			</div>
			<!-- end vertical-box-row -->
		</div>
		<!-- end vertical-box -->
	</div>
	<!-- end vertical-box-column -->
	<!-- begin vertical-box-column -->
	<div class=""vertical-box-column"">
		<!-- begin vertical-box -->
		<div class=""vertical-box"">
			<!-- begin wrapper -->
			<div class=""wrapper"">
				<span class=""btn-group mr-2"">
					<a href=""javascript:;"" class=""btn btn-white btn-sm""><i class=""fa fa-fw fa-envelope""></i> <span class=""hidden-xs"">Send</span></a>
					");
            WriteLiteral(@"<a href=""javascript:;"" class=""btn btn-white btn-sm""><i class=""fa fa-fw fa-paperclip""></i> <span class=""hidden-xs"">Attach</span></a>
				</span>
				<span class=""dropdown"">
					<a href=""#"" class=""btn btn-white btn-sm"" data-toggle=""dropdown""><i class=""fa fa-fw fa-ellipsis-h""></i></a>
					<div class=""dropdown-menu dropdown-menu-left"">
						<a href=""javascript:;"" class=""dropdown-item"">Save draft</a>
						<a href=""javascript:;"" class=""dropdown-item"">Show From</a>
						<a href=""javascript:;"" class=""dropdown-item"">Check names</a>
						<a href=""javascript:;"" class=""dropdown-item"">Switch to plain text</a>
						<a href=""javascript:;"" class=""dropdown-item"">Check for accessibility issues</a>
					</div>
				</span>
				<span class=""pull-right"">
					<a href=""/Email/Inbox"" class=""btn btn-white btn-sm""><i class=""fa fa-fw fa-times""></i> <span class=""hidden-xs"">Discard</span></a>
				</span>
			</div>
			<!-- end wrapper -->
			<!-- begin vertical-box-row -->
			<div class=""vertical-box-row bg-white""");
            WriteLiteral(@">
				<!-- begin vertical-box-cell -->
				<div class=""vertical-box-cell"">
					<!-- begin vertical-box-inner-cell -->
					<div class=""vertical-box-inner-cell"">
						<!-- begin scrollbar -->
						<div data-scrollbar=""true"" data-height=""100%"" class=""p-15"">
							<!-- begin email form -->
							");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84021fd26c69301b04482b0b410b3bcfc593c4fb20708", async() => {
                WriteLiteral(@"
								<!-- begin email to -->
								<div class=""email-to"">
									<span class=""float-right-link"">
										<a href=""#"" data-click=""add-cc"" data-name=""Cc"" class=""m-r-5"">Cc</a>
										<a href=""#"" data-click=""add-cc"" data-name=""Bcc"">Bcc</a>
									</span>
									<label class=""control-label"">To:</label>
									<ul id=""email-to"" class=""primary line-mode"">
										<li>bootstrap@gmail.com</li>
										<li>google@gmail.com</li>
									</ul>
								</div>
								<!-- end email to -->

								<div data-id=""extra-cc""></div>

								<!-- begin email subject -->
								<div class=""email-subject"">
									<input type=""text"" class=""form-control form-control-lg"" placeholder=""Subject"" />
								</div>
								<!-- end email subject -->
								<!-- begin email content -->
								<div class=""email-content p-t-15"">
									<textarea class=""textarea form-control"" id=""wysihtml5"" placeholder=""Enter text ..."" rows=""20""></textarea>
								</div>
								<!-- end email conten");
                WriteLiteral("t -->\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
							<!-- end email form -->
						</div>
						<!-- end scrollbar -->
					</div>
					<!-- end vertical-box-inner-cell -->
				</div>
				<!-- end vertical-box-cell -->
			</div>
			<!-- end vertical-box-row -->
			<!-- begin wrapper -->
			<div class=""wrapper text-right"">
				<button type=""submit"" class=""btn btn-white p-l-40 p-r-40 m-r-5"">Discard</button>
				<button type=""submit"" class=""btn btn-primary p-l-40 p-r-40"">Send</button>
			</div>
			<!-- end wrapper -->
		</div>
		<!-- end vertical-box -->
	</div>
	<!-- end vertical-box-column -->
</div>
<!-- end vertical-box -->");
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