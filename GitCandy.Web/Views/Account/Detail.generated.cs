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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Detail.cshtml")]
    public partial class _Views_Account_Detail_cshtml : System.Web.Mvc.WebViewPage<GitCandy.Models.UserModel>
    {
        public _Views_Account_Detail_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Account\Detail.cshtml"
  
    ViewBag.Title = String.Format(SR.Shared_TitleFormat, String.Format(SR.Account_DetailTitle, Model.Name));
    var token = GitCandy.Security.Token.Current;

            
            #line default
            #line hidden
WriteLiteral("\r\n<h3>");

            
            #line 7 "..\..\Views\Account\Detail.cshtml"
Write(String.Format(SR.Account_DetailTitle, Model.Name));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 9 "..\..\Views\Account\Detail.cshtml"
 if (Model != null)
{

            
            #line default
            #line hidden
WriteLiteral("    <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n\r\n        <dt>");

            
            #line 13 "..\..\Views\Account\Detail.cshtml"
       Write(Html.DisplayNameFor(s => s.Name));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 14 "..\..\Views\Account\Detail.cshtml"
       Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 16 "..\..\Views\Account\Detail.cshtml"
       Write(Html.DisplayNameFor(s => s.Nickname));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 17 "..\..\Views\Account\Detail.cshtml"
       Write(Model.Nickname);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 19 "..\..\Views\Account\Detail.cshtml"
       Write(Html.DisplayNameFor(s => s.Email));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 20 "..\..\Views\Account\Detail.cshtml"
       Write(Model.Email);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 22 "..\..\Views\Account\Detail.cshtml"
       Write(Html.DisplayNameFor(s => s.Respositories));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 23 "..\..\Views\Account\Detail.cshtml"
       Write(Html.DisplayFor(s => s.Respositories));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 25 "..\..\Views\Account\Detail.cshtml"
       Write(Html.DisplayNameFor(s => s.Teams));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 26 "..\..\Views\Account\Detail.cshtml"
       Write(Html.DisplayFor(s => s.Teams));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n        <dt>");

            
            #line 28 "..\..\Views\Account\Detail.cshtml"
       Write(Html.DisplayNameFor(s => s.Description));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n        <dd>");

            
            #line 29 "..\..\Views\Account\Detail.cshtml"
       Write(Model.Description);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n\r\n");

            
            #line 31 "..\..\Views\Account\Detail.cshtml"
        
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Account\Detail.cshtml"
         if (token != null && token.IsSystemAdministrator)
        {

            
            #line default
            #line hidden
WriteLiteral("            <dt>");

            
            #line 33 "..\..\Views\Account\Detail.cshtml"
           Write(Html.DisplayNameFor(s => s.IsSystemAdministrator));

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n");

WriteLiteral("            <dd>");

            
            #line 34 "..\..\Views\Account\Detail.cshtml"
           Write(Html.DisplayFor(s => s.IsSystemAdministrator));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");

            
            #line 35 "..\..\Views\Account\Detail.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 37 "..\..\Views\Account\Detail.cshtml"
        
            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Account\Detail.cshtml"
         if (token != null && (token.Username == Model.Name || token.IsSystemAdministrator))
        {

            
            #line default
            #line hidden
WriteLiteral("            <dt></dt>\r\n");

WriteLiteral("            <dd>\r\n");

WriteLiteral("                ");

            
            #line 41 "..\..\Views\Account\Detail.cshtml"
           Write(Html.ActionLink(SR.Shared_Edit, "Edit", new { Model.Name }, new { @class = "btn btn-primary" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 42 "..\..\Views\Account\Detail.cshtml"
           Write(Html.ActionLink(SR.Account_SSH, "Ssh", new { Model.Name }, new { @class = "btn btn-info" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 43 "..\..\Views\Account\Detail.cshtml"
           Write(Html.ActionLink(SR.Account_ChangePassword, "Change", new { Model.Name }, new { @class = "btn btn-info" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n");

            
            #line 45 "..\..\Views\Account\Detail.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </dl>\r\n");

            
            #line 47 "..\..\Views\Account\Detail.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
