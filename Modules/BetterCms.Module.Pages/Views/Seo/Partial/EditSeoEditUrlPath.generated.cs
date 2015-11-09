﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Seo/Partial/EditSeoEditUrlPath.cshtml")]
    public partial class _Views_Seo_Partial_EditSeoEditUrlPath_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Seo.EditSeoViewModel>
    {
        public _Views_Seo_Partial_EditSeoEditUrlPath_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\n");

WriteLiteral("    ");

            
            #line 6 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
Write(Html.Tooltip(PagesGlobalization.EditSeo_UrlPath_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\n    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 7 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                Write(PagesGlobalization.EditSeo_UrlPath);

            
            #line default
            #line hidden
WriteLiteral("<a");

WriteLiteral(" id=\"bcms-editseo-editurlpath\"");

WriteLiteral(">");

            
            #line 7 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                                                                                    Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</a></div>\n    <div");

WriteLiteral(" class=\"bcms-editseo-urlpath\"");

WriteLiteral(">");

            
            #line 8 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                 Write(Html.Raw(string.IsNullOrWhiteSpace(Model.PageUrlPath) ? "&nbsp;" : Html.Encode(Model.PageUrlPath)));

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

WriteLiteral("    ");

            
            #line 9 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
Write(Html.HiddenFor(f => f.PageUrlPath));

            
            #line default
            #line hidden
WriteLiteral("\n</div>\n<div");

WriteLiteral(" class=\"bcms-edit-urlpath-box\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\n    <div");

WriteLiteral(" class=\"bcms-custom-input-box\"");

WriteLiteral(" style=\"width: 503px;\"");

WriteLiteral(">\n");

WriteLiteral("        ");

            
            #line 13 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
   Write(Html.TextBoxFor(f => f.ChangedUrlPath, new { @class = "bcms-editor-field-box bcms-js-url-path" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("        ");

            
            #line 14 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
   Write(Html.BcmsValidationMessageFor(f => f.ChangedUrlPath));

            
            #line default
            #line hidden
WriteLiteral("\n    </div>\n    <div");

WriteLiteral(" id=\"bcms-editseo-editurlpath-save\"");

WriteLiteral(" class=\"bcms-btn-small\"");

WriteLiteral(">");

            
            #line 16 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                                              Write(RootGlobalization.Button_Ok);

            
            #line default
            #line hidden
WriteLiteral("</div>\n    <div");

WriteLiteral(" id=\"bcms-editseo-editurlpath-cancel\"");

WriteLiteral(" class=\"bcms-btn-links-small\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                                                      Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\n    <div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\n");

WriteLiteral("        ");

            
            #line 19 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
   Write(Html.CheckBoxFor(f => f.CreatePermanentRedirect));

            
            #line default
            #line hidden
WriteLiteral("\n        <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 20 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                Write(PagesGlobalization.EditSeo_EditUrlPath_PermanentRedirect);

            
            #line default
            #line hidden
WriteLiteral("</div>\n    </div>\n    <div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\n");

WriteLiteral("        ");

            
            #line 23 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
   Write(Html.CheckBoxFor(f => f.UseCanonicalUrl));

            
            #line default
            #line hidden
WriteLiteral("\n        <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 24 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                Write(PagesGlobalization.EditSeo_EditUrlPath_UseCanonicalUrl);

            
            #line default
            #line hidden
WriteLiteral("</div>\n    </div>\n");

            
            #line 26 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
    
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
     if (Model.IsInSitemap)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\n");

WriteLiteral("            ");

            
            #line 29 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
       Write(Html.CheckBoxFor(f => f.UpdateSitemap));

            
            #line default
            #line hidden
WriteLiteral("\n            <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 30 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
                                    Write(PagesGlobalization.EditSeo_EditUrlPath_UpdateSitemap);

            
            #line default
            #line hidden
WriteLiteral("</div>\n        </div>\n");

            
            #line 32 "..\..\Views\Seo\Partial\EditSeoEditUrlPath.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

        }
    }
}
#pragma warning restore 1591
