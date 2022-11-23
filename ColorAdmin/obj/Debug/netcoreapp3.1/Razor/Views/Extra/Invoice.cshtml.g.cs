#pragma checksum "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Extra\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f97046d4d3dd8e09209f30311180fb08620f479"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Extra_Invoice), @"mvc.1.0.view", @"/Views/Extra/Invoice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f97046d4d3dd8e09209f30311180fb08620f479", @"/Views/Extra/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bd241ee090bd8b39c0cf55b12cb73c6c44cc0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Extra_Invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/default/invoice-print.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\jose.lima\Downloads\color_admin_v4.7\admin\template\template_asp\ColorAdmin\Views\Extra\Invoice.cshtml"
  
  ViewData["Title"] = "Invoice";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f97046d4d3dd8e09209f30311180fb08620f4794199", async() => {
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
            WriteLiteral(@"
<!-- begin breadcrumb -->
<ol class=""breadcrumb hidden-print float-xl-right"">
	<li class=""breadcrumb-item""><a href=""javascript:;"">Home</a></li>
	<li class=""breadcrumb-item active"">Invoice</li>
</ol>
<!-- end breadcrumb -->
<!-- begin page-header -->
<h1 class=""page-header hidden-print"">Invoice <small>header small text goes here...</small></h1>
<!-- end page-header -->
<!-- begin invoice -->
<div class=""invoice"">
	<!-- begin invoice-company -->
	<div class=""invoice-company"">
		<span class=""pull-right hidden-print"">
			<a href=""javascript:;"" class=""btn btn-sm btn-white m-b-10""><i class=""fa fa-file-pdf t-plus-1 text-danger fa-fw fa-lg""></i> Export as PDF</a>
			<a href=""javascript:;"" onclick=""window.print()"" class=""btn btn-sm btn-white m-b-10""><i class=""fa fa-print t-plus-1 fa-fw fa-lg""></i> Print</a>
		</span>
		Company Name, Inc
	</div>
	<!-- end invoice-company -->
	<!-- begin invoice-header -->
	<div class=""invoice-header"">
		<div class=""invoice-from"">
			<small>from</small>
			<add");
            WriteLiteral(@"ress class=""m-t-5 m-b-5"">
				<strong class=""text-inverse"">Twitter, Inc.</strong><br />
				Street Address<br />
				City, Zip Code<br />
				Phone: (123) 456-7890<br />
				Fax: (123) 456-7890
			</address>
		</div>
		<div class=""invoice-to"">
			<small>to</small>
			<address class=""m-t-5 m-b-5"">
				<strong class=""text-inverse"">Company Name</strong><br />
				Street Address<br />
				City, Zip Code<br />
				Phone: (123) 456-7890<br />
				Fax: (123) 456-7890
			</address>
		</div>
		<div class=""invoice-date"">
			<small>Invoice / July period</small>
			<div class=""date text-inverse m-t-5"">August 3,2012</div>
			<div class=""invoice-detail"">
				#0000123DSS<br />
				Services Product
			</div>
		</div>
	</div>
	<!-- end invoice-header -->
	<!-- begin invoice-content -->
	<div class=""invoice-content"">
		<!-- begin table-responsive -->
		<div class=""table-responsive"">
			<table class=""table table-invoice"">
				<thead>
					<tr>
						<th>TASK DESCRIPTION</th>
						<th class=""");
            WriteLiteral(@"text-center"" width=""10%"">RATE</th>
						<th class=""text-center"" width=""10%"">HOURS</th>
						<th class=""text-right"" width=""20%"">LINE TOTAL</th>
					</tr>
				</thead>
				<tbody>
					<tr>
						<td>
							<span class=""text-inverse"">Website design &amp; development</span><br />
							<small>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed id sagittis arcu.</small>
						</td>
						<td class=""text-center"">$50.00</td>
						<td class=""text-center"">50</td>
						<td class=""text-right"">$2,500.00</td>
					</tr>
					<tr>
						<td>
							<span class=""text-inverse"">Branding</span><br />
							<small>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed id sagittis arcu.</small>
						</td>
						<td class=""text-center"">$50.00</td>
						<td class=""text-center"">40</td>
						<td class=""text-right"">$2,000.00</td>
					</tr>
					<tr>
						<td>
							<span class=""text-inverse"">Redesign Service</span><br />
							<small>Lorem ipsum dolor sit amet, consectetur adi");
            WriteLiteral(@"piscing elit. Sed id sagittis arcu.</small>
						</td>
						<td class=""text-center"">$50.00</td>
						<td class=""text-center"">50</td>
						<td class=""text-right"">$2,500.00</td>
					</tr>
				</tbody>
			</table>
		</div>
		<!-- end table-responsive -->
		<!-- begin invoice-price -->
		<div class=""invoice-price"">
			<div class=""invoice-price-left"">
				<div class=""invoice-price-row"">
					<div class=""sub-price"">
						<small>SUBTOTAL</small>
						<span class=""text-inverse"">$4,500.00</span>
					</div>
					<div class=""sub-price"">
						<i class=""fa fa-plus text-muted""></i>
					</div>
					<div class=""sub-price"">
						<small>PAYPAL FEE (5.4%)</small>
						<span class=""text-inverse"">$108.00</span>
					</div>
				</div>
			</div>
			<div class=""invoice-price-right"">
				<small>TOTAL</small> <span class=""f-w-600"">$4508.00</span>
			</div>
		</div>
		<!-- end invoice-price -->
	</div>
	<!-- end invoice-content -->
	<!-- begin invoice-note -->
	<div class=""invoice-note"">
");
            WriteLiteral(@"		* Make all cheques payable to [Your Company Name]<br />
		* Payment is due within 30 days<br />
		* If you have any questions concerning this invoice, contact  [Name, Phone Number, Email]
	</div>
	<!-- end invoice-note -->
	<!-- begin invoice-footer -->
	<div class=""invoice-footer"">
		<p class=""text-center m-b-5 f-w-600"">
			THANK YOU FOR YOUR BUSINESS
		</p>
		<p class=""text-center"">
			<span class=""m-r-10""><i class=""fa fa-fw fa-lg fa-globe""></i> matiasgallipoli.com</span>
			<span class=""m-r-10""><i class=""fa fa-fw fa-lg fa-phone-volume""></i> T:016-18192302</span>
			<span class=""m-r-10""><i class=""fa fa-fw fa-lg fa-envelope""></i> rtiemps@gmail.com</span>
		</p>
	</div>
	<!-- end invoice-footer -->
</div>
<!-- end invoice -->

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