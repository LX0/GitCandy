﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
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
    using GitCandy;
    using GitCandy.App_GlobalResources;
    using GitCandy.Base;
    using GitCandy.Configuration;
    using GitCandy.Extensions;
    using GitCandy.Models;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Serialization;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Repository/Index.cshtml")]
    public partial class _Views_Repository_Index_cshtml : System.Web.Mvc.WebViewPage<GitCandy.Models.RepositoryListModel>
    {
        public _Views_Repository_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Repository\Index.cshtml"
  
    ViewBag.Title = string.Format(SR.Shared_TitleFormat, SR.Repository_ListTitle);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h4>");

            
            #line 7 "..\..\Views\Repository\Index.cshtml"
Write(SR.Repository_ListTitle);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Repository\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Repository\Index.cshtml"
     if (Model.CanCreateRepository)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Repository\Index.cshtml"
                           Write(Html.ActionLink(SR.Shared_Create, "Create", null, new { @class = "btn btn-primary" }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 13 "..\..\Views\Repository\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"table border-area\"");

WriteLiteral(">\r\n            <thead>");

            
            #line 18 "..\..\Views\Repository\Index.cshtml"
              Write(SR.Repository_Collaborations);

            
            #line default
            #line hidden
WriteLiteral("</thead>\r\n");

            
            #line 19 "..\..\Views\Repository\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Repository\Index.cshtml"
             foreach (var repo in Model.Collaborations)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>\r\n                        <div>");

            
            #line 23 "..\..\Views\Repository\Index.cshtml"
                        Write(Html.ActionLink(repo.Name, "Tree", Html.OverRoute(new { repo.Name })));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div>");

            
            #line 24 "..\..\Views\Repository\Index.cshtml"
                        Write(repo.Description);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div>");

            
            #line 25 "..\..\Views\Repository\Index.cshtml"
                        Write(repo.Commits);

            
            #line default
            #line hidden
WriteLiteral(" 提交，");

            
            #line 25 "..\..\Views\Repository\Index.cshtml"
                                         Write(repo.Branches);

            
            #line default
            #line hidden
WriteLiteral(" 分支，");

            
            #line 25 "..\..\Views\Repository\Index.cshtml"
                                                           Write(repo.Contributors);

            
            #line default
            #line hidden
WriteLiteral(" 参与，");

            
            #line 25 "..\..\Views\Repository\Index.cshtml"
                                                                                 Write(repo.Views);

            
            #line default
            #line hidden
WriteLiteral(" 浏览，");

            
            #line 25 "..\..\Views\Repository\Index.cshtml"
                                                                                                Write(repo.LastCommit.ToFullString());

            
            #line default
            #line hidden
WriteLiteral(" 最后提交</div>\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 28 "..\..\Views\Repository\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"table border-area\"");

WriteLiteral(">\r\n            <thead>");

            
            #line 34 "..\..\Views\Repository\Index.cshtml"
              Write(SR.Repository_PopularRepositories);

            
            #line default
            #line hidden
WriteLiteral("</thead>\r\n");

            
            #line 35 "..\..\Views\Repository\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Repository\Index.cshtml"
             foreach (var repo in Model.Repositories)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>\r\n                        <div>");

            
            #line 39 "..\..\Views\Repository\Index.cshtml"
                        Write(Html.ActionLink(repo.Name, "Tree", Html.OverRoute(new { repo.Name })));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div>");

            
            #line 40 "..\..\Views\Repository\Index.cshtml"
                        Write(repo.Description);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div>");

            
            #line 41 "..\..\Views\Repository\Index.cshtml"
                        Write(repo.Commits);

            
            #line default
            #line hidden
WriteLiteral(" 提交，");

            
            #line 41 "..\..\Views\Repository\Index.cshtml"
                                         Write(repo.Branches);

            
            #line default
            #line hidden
WriteLiteral(" 分支，");

            
            #line 41 "..\..\Views\Repository\Index.cshtml"
                                                           Write(repo.Contributors);

            
            #line default
            #line hidden
WriteLiteral(" 参与，");

            
            #line 41 "..\..\Views\Repository\Index.cshtml"
                                                                                 Write(repo.Views);

            
            #line default
            #line hidden
WriteLiteral(" 浏览，");

            
            #line 41 "..\..\Views\Repository\Index.cshtml"
                                                                                                Write(repo.LastCommit.ToFullString());

            
            #line default
            #line hidden
WriteLiteral(" 最后提交</div>\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 44 "..\..\Views\Repository\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
