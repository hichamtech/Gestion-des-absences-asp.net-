#pragma checksum "/home/hicham/ProjetAspCore/Pages/Admin/Dashboard/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c66814de0e88ec2d01f38b209552720bb0a94353"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjetAspCore.Pages.Admin.Dashboard.Pages_Admin_Dashboard_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Dashboard/Index.cshtml")]
namespace ProjetAspCore.Pages.Admin.Dashboard
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
#line 1 "/home/hicham/ProjetAspCore/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/hicham/ProjetAspCore/Pages/_ViewImports.cshtml"
using ProjetAspCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/hicham/ProjetAspCore/Pages/_ViewImports.cshtml"
using ProjetAspCore.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c66814de0e88ec2d01f38b209552720bb0a94353", @"/Pages/Admin/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f76fd8c565fc87f46ec9f6d7b91bc57dca8c2a7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"	<!-- OVERVIEW -->
					<div class=""panel panel-headline"">
						<div class=""panel-heading"">
							<h3 class=""panel-title"">Vue Globale</h3>
							<p class=""panel-subtitle""></p>
						</div>
						<div class=""panel-body"">
							<div class=""row"">
								<div class=""col-md-3"">
									<div class=""metric"">
										<span class=""icon""><i class=""fas fa-book-reader""></i></span>
										<p>
                                         
											<span class=""number"">");
#nullable restore
#line 18 "/home/hicham/ProjetAspCore/Pages/Admin/Dashboard/Index.cshtml"
                                                            Write(Model.Nbretudiants);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
											<span class=""title"">Etudiants</span>
										</p>
									</div>
								</div>
								<div class=""col-md-3"">
									<div class=""metric"">
										<span class=""icon""><i class=""fas fa-chalkboard-teacher""></i></span>
										<p>
											<span class=""number"">");
#nullable restore
#line 27 "/home/hicham/ProjetAspCore/Pages/Admin/Dashboard/Index.cshtml"
                                                            Write(Model.Nbrprofesseurs);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
											<span class=""title"">Professeurs</span>
										</p>
									</div>
								</div>
								<div class=""col-md-3"">
									<div class=""metric"">
										<span class=""icon""><i class=""fa fa-eye""></i></span>
										<p>
											<span class=""number"">");
#nullable restore
#line 36 "/home/hicham/ProjetAspCore/Pages/Admin/Dashboard/Index.cshtml"
                                                            Write(Model.NbrFilieres);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
											<span class=""title"">Filiéres</span>
										</p>
									</div>
								</div>
								<div class=""col-md-3"">
									<div class=""metric"">
										<span class=""icon""><i class=""fa fa-bar-chart""></i></span>
										<p>
											<span class=""number"">");
#nullable restore
#line 45 "/home/hicham/ProjetAspCore/Pages/Admin/Dashboard/Index.cshtml"
                                                            Write(Model.Nbrsalles);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"title\">Salles</span>\r\n\t\t\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\r\n\t \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetAspCore.Pages.dashboardModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjetAspCore.Pages.dashboardModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjetAspCore.Pages.dashboardModel>)PageContext?.ViewData;
        public ProjetAspCore.Pages.dashboardModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591