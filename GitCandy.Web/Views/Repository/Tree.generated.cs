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
    using GitCandy.Web.App_GlobalResources;
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Repository/Tree.cshtml")]
    public partial class _Views_Repository_Tree_cshtml : System.Web.Mvc.WebViewPage<GitCandy.Models.TreeModel>
    {
        public _Views_Repository_Tree_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Repository\Tree.cshtml"
  
    ViewBag.Title = String.Format(SR.Shared_TitleFormat, String.Format(SR.Repository_TreeTitle, Model.RepositoryName, Model.ReferenceName ?? Model.Commit.Sha.ToShortSha(), Model.Path));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h3>");

            
            #line 7 "..\..\Views\Repository\Tree.cshtml"
Write(Html.ActionLink(Model.RepositoryName, "Tree", Html.OverRoute(new { path = "" })));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 9 "..\..\Views\Repository\Tree.cshtml"
 if (Model.Entries == null)
{

            
            #line default
            #line hidden
WriteLiteral("    <div>\r\n");

WriteLiteral("        ");

            
            #line 12 "..\..\Views\Repository\Tree.cshtml"
   Write(Html.ActionLink(SR.Shared_Detail, "Detail", Html.OverRoute(), new { @class = "btn btn-default pull-right" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 13 "..\..\Views\Repository\Tree.cshtml"
   Write(Html.Partial("_GitUrlButton", Model.GitUrls));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" class=\"alert alert-info\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\Repository\Tree.cshtml"
                             Write(SR.Repository_EmptyWords);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 16 "..\..\Views\Repository\Tree.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <div>\r\n");

            
            #line 20 "..\..\Views\Repository\Tree.cshtml"
        
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Repository\Tree.cshtml"
         if (Model.IsRoot)
        {

            
            #line default
            #line hidden
WriteLiteral("            <h5>");

            
            #line 22 "..\..\Views\Repository\Tree.cshtml"
           Write(Model.Description);

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"border-area\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" class=\"nav nav-justified\"");

WriteLiteral(">\r\n                    <li>");

            
            #line 25 "..\..\Views\Repository\Tree.cshtml"
                   Write(Html.ActionLink(Model.Scope.Commits + " " + SR.Repository_Commits, "Commits", Html.OverRoute()));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li>");

            
            #line 26 "..\..\Views\Repository\Tree.cshtml"
                   Write(Html.ActionLink(Model.Scope.Branches + " " + SR.Repository_Branches, "Branches", Html.OverRoute(new { path = "" })));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li>");

            
            #line 27 "..\..\Views\Repository\Tree.cshtml"
                   Write(Html.ActionLink(Model.Scope.Tags + " " + SR.Repository_Tags, "Tags", Html.OverRoute(new { path = "" })));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li>");

            
            #line 28 "..\..\Views\Repository\Tree.cshtml"
                   Write(Html.ActionLink(Model.Scope.Contributors + " " + SR.Repository_Contributors, "Contributors", Html.OverRoute()));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n");

            
            #line 31 "..\..\Views\Repository\Tree.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div>\r\n");

            
            #line 34 "..\..\Views\Repository\Tree.cshtml"
            
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Repository\Tree.cshtml"
             if (Model.IsRoot)
            {
                
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Repository\Tree.cshtml"
           Write(Html.ActionLink(SR.Shared_Detail, "Detail", Html.OverRoute(), new { @class = "btn btn-default pull-right" }));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Repository\Tree.cshtml"
                                                                                                                             
                
            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Repository\Tree.cshtml"
           Write(Html.Partial("_BranchSelector", Model.BranchSelector));

            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Repository\Tree.cshtml"
                                                                      
                
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Repository\Tree.cshtml"
           Write(Html.Partial("_ZipButton", Model.ReferenceName ?? Model.Commit.Sha));

            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Repository\Tree.cshtml"
                                                                                    

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1784), Tuple.Create("\"", 1848)
            
            #line 39 "..\..\Views\Repository\Tree.cshtml"
, Tuple.Create(Tuple.Create("", 1791), Tuple.Create<System.Object, System.Int32>(Url.Action("Compare", Html.OverRoute(new { path = "" }))
            
            #line default
            #line hidden
, 1791), false)
);

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-retweet\"");

WriteLiteral("></span>");

            
            #line 39 "..\..\Views\Repository\Tree.cshtml"
                                                                                                                                                        Write(SR.Repository_Compare);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 40 "..\..\Views\Repository\Tree.cshtml"
                
            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\Repository\Tree.cshtml"
           Write(Html.Partial("_GitUrlButton", Model.GitUrls));

            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\Repository\Tree.cshtml"
                                                             
            }
            else
            {
                
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Repository\Tree.cshtml"
           Write(Html.Partial("_BranchSelector", Model.BranchSelector));

            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Repository\Tree.cshtml"
                                                                      

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 46 "..\..\Views\Repository\Tree.cshtml"
               Write(Html.ActionLink(SR.Repository_History, "Commits", Html.OverRoute(new { path = (Model.ReferenceName ?? Model.Commit.Sha) + "/" + Model.Path }), new { @class = "btn btn-default" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 48 "..\..\Views\Repository\Tree.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

WriteLiteral("        ");

            
            #line 50 "..\..\Views\Repository\Tree.cshtml"
   Write(Html.Partial("_PathBar", Model.PathBar));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"border-area table-responsive\"");

WriteLiteral(">\r\n            <table");

WriteLiteral(" class=\"table table-hover table-striped\"");

WriteLiteral(">\r\n                <caption>\r\n                    <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n                        <div");

WriteAttribute("title", Tuple.Create(" title=\"", 2693), Tuple.Create("\"", 2733)
            
            #line 55 "..\..\Views\Repository\Tree.cshtml"
, Tuple.Create(Tuple.Create("", 2701), Tuple.Create<System.Object, System.Int32>(Model.Commit.CommitMessageShort
            
            #line default
            #line hidden
, 2701), false)
);

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">");

            
            #line 55 "..\..\Views\Repository\Tree.cshtml"
                                                                                   Write(Html.ActionLink(Model.Commit.CommitMessageShort.ShortString(80), "Commit", Html.OverRoute(new { path = Model.Commit.Sha })));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n                        <strong");

WriteAttribute("title", Tuple.Create(" title=\"", 2988), Tuple.Create("\"", 3016)
            
            #line 58 "..\..\Views\Repository\Tree.cshtml"
, Tuple.Create(Tuple.Create("", 2996), Tuple.Create<System.Object, System.Int32>(Model.Commit.Author
            
            #line default
            #line hidden
, 2996), false)
);

WriteLiteral(">");

            
            #line 58 "..\..\Views\Repository\Tree.cshtml"
                                                        Write(Html.Link(Model.Commit.Author));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n                        <span>");

            
            #line 59 "..\..\Views\Repository\Tree.cshtml"
                         Write(SR.Repository_AuthoredAt);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        <span");

WriteAttribute("title", Tuple.Create(" title=\"", 3153), Tuple.Create("\"", 3186)
            
            #line 60 "..\..\Views\Repository\Tree.cshtml"
, Tuple.Create(Tuple.Create("", 3161), Tuple.Create<System.Object, System.Int32>(Model.Commit.Author.When
            
            #line default
            #line hidden
, 3161), false)
);

WriteLiteral(">");

            
            #line 60 "..\..\Views\Repository\Tree.cshtml"
                                                           Write(Model.Commit.Author.When.LocalDateTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 61 "..\..\Views\Repository\Tree.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Repository\Tree.cshtml"
                         if (Model.Commit.Author != Model.Commit.Committer)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <strong");

WriteAttribute("title", Tuple.Create(" title=\"", 3390), Tuple.Create("\"", 3421)
            
            #line 63 "..\..\Views\Repository\Tree.cshtml"
, Tuple.Create(Tuple.Create("", 3398), Tuple.Create<System.Object, System.Int32>(Model.Commit.Committer
            
            #line default
            #line hidden
, 3398), false)
);

WriteLiteral(">");

            
            #line 63 "..\..\Views\Repository\Tree.cshtml"
                                                               Write(Model.Commit.Committer.Name);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n");

WriteLiteral("                            <span>");

            
            #line 64 "..\..\Views\Repository\Tree.cshtml"
                             Write(SR.Repository_CommittedAt);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("                            <span");

WriteAttribute("title", Tuple.Create(" title=\"", 3564), Tuple.Create("\"", 3600)
            
            #line 65 "..\..\Views\Repository\Tree.cshtml"
, Tuple.Create(Tuple.Create("", 3572), Tuple.Create<System.Object, System.Int32>(Model.Commit.Committer.When
            
            #line default
            #line hidden
, 3572), false)
);

WriteLiteral(">");

            
            #line 65 "..\..\Views\Repository\Tree.cshtml"
                                                                  Write(Model.Commit.Committer.When.LocalDateTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 66 "..\..\Views\Repository\Tree.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(">");

            
            #line 67 "..\..\Views\Repository\Tree.cshtml"
                                           Write(Model.Commit.Sha.ToShortSha());

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </div>\r\n                </caption>\r\n                <" +
"tbody>\r\n");

            
            #line 71 "..\..\Views\Repository\Tree.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 71 "..\..\Views\Repository\Tree.cshtml"
                     foreach (var entry in Model.Entries)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr>\r\n                            <td>\r\n                 " +
"               <span");

WriteAttribute("title", Tuple.Create(" title=\"", 4045), Tuple.Create("\"", 4064)
            
            #line 75 "..\..\Views\Repository\Tree.cshtml"
, Tuple.Create(Tuple.Create("", 4053), Tuple.Create<System.Object, System.Int32>(entry.Name
            
            #line default
            #line hidden
, 4053), false)
);

WriteLiteral(">\r\n");

            
            #line 76 "..\..\Views\Repository\Tree.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Repository\Tree.cshtml"
                                     if (entry.EntryType == LibGit2Sharp.TreeEntryTargetType.Tree)
                                    {
            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" class=\"glyphicon glyphicon-folder-close\"");

WriteLiteral("></span> ");

            
            #line 77 "..\..\Views\Repository\Tree.cshtml"
                                                                                             }
                                    else if (entry.EntryType == LibGit2Sharp.TreeEntryTargetType.Blob)
                                    {
            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" class=\"glyphicon glyphicon-file\"");

WriteLiteral("></span> ");

            
            #line 79 "..\..\Views\Repository\Tree.cshtml"
                                                                                     }
                                    else if (entry.EntryType == LibGit2Sharp.TreeEntryTargetType.GitLink)
                                    {
            
            #line default
            #line hidden
WriteLiteral(" <i");

WriteLiteral(" class=\"glyphicon glyphicon-bookmark\"");

WriteLiteral("></i> ");

            
            #line 81 "..\..\Views\Repository\Tree.cshtml"
                                                                                   }
                                    else
                                    {
            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" class=\"glyphicon glyphicon-leaf\"");

WriteLiteral("></span> ");

            
            #line 83 "..\..\Views\Repository\Tree.cshtml"
                                                                                     }

            
            #line default
            #line hidden
WriteLiteral("                                    ");

            
            #line 84 "..\..\Views\Repository\Tree.cshtml"
                                     if (entry.EntryType == LibGit2Sharp.TreeEntryTargetType.GitLink)
                                    { 
            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\Repository\Tree.cshtml"
                                 Write(entry.Name.ShortString(25));

            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\Repository\Tree.cshtml"
                                                                  }
                                    else
                                    { 
            
            #line default
            #line hidden
            
            #line 87 "..\..\Views\Repository\Tree.cshtml"
                                 Write(Html.ActionLink(entry.Name.ShortString(25), entry.EntryType.ToString(), Html.OverRoute(new { path = (Model.ReferenceName ?? Model.Commit.Sha) + "/" + entry.Path })));

            
            #line default
            #line hidden
            
            #line 87 "..\..\Views\Repository\Tree.cshtml"
                                                                                                                                                                                                            }

            
            #line default
            #line hidden
WriteLiteral("                                </span>\r\n                            </td>\r\n     " +
"                       <td><span");

WriteAttribute("title", Tuple.Create(" title=\"", 5313), Tuple.Create("\"", 5353)
            
            #line 90 "..\..\Views\Repository\Tree.cshtml"
, Tuple.Create(Tuple.Create("", 5321), Tuple.Create<System.Object, System.Int32>(entry.Commit.CommitMessageShort
            
            #line default
            #line hidden
, 5321), false)
);

WriteLiteral(">");

            
            #line 90 "..\..\Views\Repository\Tree.cshtml"
                                                                           Write(entry.Commit.Sha == null ? Html.Raw(entry.Commit.CommitMessageShort) : Html.ActionLink(entry.Commit.CommitMessageShort.ShortString(70), "Commit", Html.OverRoute(new { path = entry.Commit.Sha })));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n                            <td");

WriteAttribute("title", Tuple.Create(" title=\"", 5597), Tuple.Create("\"", 5625)
            
            #line 91 "..\..\Views\Repository\Tree.cshtml"
, Tuple.Create(Tuple.Create("", 5605), Tuple.Create<System.Object, System.Int32>(entry.Commit.Author
            
            #line default
            #line hidden
, 5605), false)
);

WriteLiteral(">");

            
            #line 91 "..\..\Views\Repository\Tree.cshtml"
                                                        Write(entry.Commit.Author.Name.ShortString(20));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td");

WriteAttribute("title", Tuple.Create(" title=\"", 5706), Tuple.Create("\"", 5739)
            
            #line 92 "..\..\Views\Repository\Tree.cshtml"
, Tuple.Create(Tuple.Create("", 5714), Tuple.Create<System.Object, System.Int32>(entry.Commit.Author.When
            
            #line default
            #line hidden
, 5714), false)
);

WriteLiteral(">");

            
            #line 92 "..\..\Views\Repository\Tree.cshtml"
                                                             Write(entry.Commit.Author.When.LocalDateTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        </tr>\r\n");

            
            #line 94 "..\..\Views\Repository\Tree.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");

            
            #line 98 "..\..\Views\Repository\Tree.cshtml"
        
            
            #line default
            #line hidden
            
            #line 98 "..\..\Views\Repository\Tree.cshtml"
         if (Model.Readme != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"border-area\"");

WriteLiteral(">\r\n                <table");

WriteLiteral(" class=\"table\"");

WriteLiteral(">\r\n                    <caption>\r\n                        <div");

WriteLiteral(" class=\"pull-left keep-space\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-list-alt\"");

WriteLiteral("></i> ");

            
            #line 103 "..\..\Views\Repository\Tree.cshtml"
                                                                                                  Write(Model.Readme.Name);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </caption>\r\n                    <tbody>\r\n            " +
"            <tr>\r\n                            <td>\r\n");

WriteLiteral("                                ");

            
            #line 108 "..\..\Views\Repository\Tree.cshtml"
                           Write(Html.Partial("_BlobPreview", Model.Readme));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n             " +
"       </tbody>\r\n                </table>\r\n            </div>\r\n");

            
            #line 114 "..\..\Views\Repository\Tree.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

            
            #line 116 "..\..\Views\Repository\Tree.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
