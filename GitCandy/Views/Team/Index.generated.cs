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
    using System.Web.Optimization;
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Team/Index.cshtml")]
    public partial class _Views_Team_Index_cshtml : System.Web.Mvc.WebViewPage<GitCandy.Models.TeamListModel>
    {
        public _Views_Team_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Team\Index.cshtml"
  
    ViewBag.Title = string.Format(SR.Shared_TitleFormat, SR.Team_ListTitle);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h3>");

            
            #line 7 "..\..\Views\Team\Index.cshtml"
Write(SR.Team_ListTitle);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 9 "..\..\Views\Team\Index.cshtml"
 using (Html.BeginForm("Index", "Team", FormMethod.Get))
{

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"form-group col-md-5\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" name=\"query\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n            <span");

WriteLiteral(" class=\"input-group-btn\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(">");

            
            #line 16 "..\..\Views\Team\Index.cshtml"
                                                         Write(SR.Shared_Search);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n            </span>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

            
            #line 21 "..\..\Views\Team\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n    <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">");

            
            #line 24 "..\..\Views\Team\Index.cshtml"
                      Write(string.Format(SR.Team_TeamsFound, Model.ItemCount));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    <div");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\Team\Index.cshtml"
                       Write(Html.ActionLink(SR.Shared_Create, "Create", null, new { @class = "btn btn-primary" }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n</div>\r\n<table");

WriteLiteral(" class=\"table table-hover table-striped\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n            <th>");

            
            #line 30 "..\..\Views\Team\Index.cshtml"
           Write(SR.Team_Name);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n            <th>");

            
            #line 31 "..\..\Views\Team\Index.cshtml"
           Write(SR.Team_Description);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 35 "..\..\Views\Team\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Team\Index.cshtml"
         foreach (var item in Model.Teams)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>");

            
            #line 38 "..\..\Views\Team\Index.cshtml"
               Write(Html.ActionLink(item.Name, "Detail", new { name = item.Name }));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 39 "..\..\Views\Team\Index.cshtml"
               Write(item.Description);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n            </tr>\r\n");

            
            #line 41 "..\..\Views\Team\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>\r\n");

            
            #line 44 "..\..\Views\Team\Index.cshtml"
Write(Html.Partial("_Pager"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
