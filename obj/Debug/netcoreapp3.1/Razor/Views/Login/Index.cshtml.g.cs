#pragma checksum "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbbea1fdc898d75aa36a90e593af96941c6f33cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "Z:\Proyectos\Montagne\MTG\Views\_ViewImports.cshtml"
using MTG;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Z:\Proyectos\Montagne\MTG\Views\_ViewImports.cshtml"
using MTG.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbbea1fdc898d75aa36a90e593af96941c6f33cf", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b42f3980e9b806361ab641769096aa15e4b1dfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MTG.Models.Login>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml"
  
    ViewBag.Title = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml"
 using (Html.BeginForm("Logger", "Login", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\r\n        <legend>Login</legend>\r\n\r\n        ");
#nullable restore
#line 13 "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml"
         if (@ViewBag.Message != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"border: 1px solid red\">\r\n                ");
#nullable restore
#line 18 "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 20 "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table>\r\n            \r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 25 "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml"
               Write(Html.LabelFor(a => a.usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 27 "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml"
               Write(Html.TextBoxFor(a => a.usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml"
               Write(Html.ValidationMessageFor(a => a.usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml"
               Write(Html.LabelFor(a => a.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 35 "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml"
               Write(Html.PasswordFor(a => a.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml"
               Write(Html.ValidationMessageFor(a => a.password));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <input type=""submit"" value=""Login"" />
                </td>
                <td></td>
            </tr>
        </table>
    </fieldset>
");
#nullable restore
#line 47 "Z:\Proyectos\Montagne\MTG\Views\Login\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MTG.Models.Login> Html { get; private set; }
    }
}
#pragma warning restore 1591
