﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ilaro.Admin.Views.IlaroAdmin.EditorTemplates
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
    using Ilaro.Admin.Commons.Paging;
    using Ilaro.Admin.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IlaroAdmin/EditorTemplates/CheckboxPartial.cshtml")]
    public partial class _CheckboxPartial : System.Web.Mvc.WebViewPage<Ilaro.Admin.ViewModels.PropertyViewModel>
    {
        public _CheckboxPartial()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"controls\"");

WriteLiteral(">\r\n    <label");

WriteAttribute("for", Tuple.Create(" for=\"", 96), Tuple.Create("\"", 122)
            
            #line 4 "..\..\Views\IlaroAdmin\EditorTemplates\CheckboxPartial.cshtml"
, Tuple.Create(Tuple.Create("", 102), Tuple.Create<System.Object, System.Int32>(Html.Id(Model.Name)
            
            #line default
            #line hidden
, 102), false)
);

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 5 "..\..\Views\IlaroAdmin\EditorTemplates\CheckboxPartial.cshtml"
   Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral(" \r\n");

WriteLiteral("        ");

            
            #line 6 "..\..\Views\IlaroAdmin\EditorTemplates\CheckboxPartial.cshtml"
   Write(Html.Condition(Model.IsRequired, () => "<span class=\"text-error\">*</span>"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 7 "..\..\Views\IlaroAdmin\EditorTemplates\CheckboxPartial.cshtml"
   Write(Html.CheckBox(Model.Name, Model.BoolValue.GetValueOrDefault()));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </label>\r\n");

WriteLiteral("    ");

            
            #line 9 "..\..\Views\IlaroAdmin\EditorTemplates\CheckboxPartial.cshtml"
Write(Html.Condition(!string.IsNullOrEmpty(Model.Description), () => "<span class=\"description\">" + Model.Description + "</span>"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591