﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class ServersPage : WebTemplateBase
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");


WriteLiteral("              \r\n");


            
            #line 4 "..\..\ServersPage.cshtml"
  
    Layout = new LayoutPage()
        {
            Context = Context,
            Title = "Servers"
        };


            
            #line default
            #line hidden
WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Iid</th>\r\n   " +
"         <th>Queue</th>\r\n            <th>Concurrency</th>\r\n        </tr>\r\n    </" +
"thead>\r\n    <tbody>\r\n");


            
            #line 21 "..\..\ServersPage.cshtml"
         foreach (var server in Storage.Servers())
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>");


            
            #line 24 "..\..\ServersPage.cshtml"
               Write(server.Iid);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");


            
            #line 25 "..\..\ServersPage.cshtml"
               Write(server.Queue);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");


            
            #line 26 "..\..\ServersPage.cshtml"
               Write(server.Concurrency);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n            </tr>\r\n");


            
            #line 28 "..\..\ServersPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");


        }
    }
}
#pragma warning restore 1591
