#pragma checksum "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d04f1dbeba9087dd713cae5d3e1f91dbb7e230fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movimiento_Create), @"mvc.1.0.view", @"/Views/Movimiento/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d04f1dbeba9087dd713cae5d3e1f91dbb7e230fe", @"/Views/Movimiento/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b42f3980e9b806361ab641769096aa15e4b1dfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Movimiento_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MTG.DTO.MoveDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n");
#nullable restore
#line 11 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
 using (Html.BeginForm("JustCreate", "Movimiento", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"">
    <thead>

        <tr>

            <th>
                <p>Producto</p>
            </th>
            <th>
                <p>Desde</p>
            </th>
            <th>
                <p>Hasta</p>
            </th>
            <th>
                <p>Fecha</p>
            </th>


            <th></th>
        </tr>

    </thead>

    <tbody>
        <tr>
            <th>
                ");
#nullable restore
#line 40 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
           Write(Html.DropDownListFor(model => model._Depositos.,
                 new SelectList(Model.Professors, "professorId", "LastName", Model.Course_Complete.professorId),
                 "Select professor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </th>\r\n            <th>\r\n                <div class=\"input-group\">\r\n                    ");
#nullable restore
#line 48 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Course_Complete.maximum_quantity_students,
     new
     {
         @class = "form-control",
         @placeholder = "Enter Name",
         @requried = "required"
     }

));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <span class=\"input-group-addon\"><span class=\"glyphicon glyphicon-asterisk\">  </span></span>\r\n                </div>\r\n\r\n\r\n\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
           Write(Html.DropDownListFor(model => model.Course_Complete.professorId,
                 new SelectList(Model.Professors, "professorId", "LastName", Model.Course_Complete.professorId),
                 "Select professor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </th>\r\n            <th>\r\n                <div class=\"input-group\">\r\n                    ");
#nullable restore
#line 72 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Course_Complete.Credits,
     new
     {
         @class = "form-control",
         @placeholder = "Enter Name",
         @requried = "required"
     }

));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <span class=""input-group-addon""><span class=""glyphicon glyphicon-asterisk"">  </span></span>
                </div>
            </th>
            <th></th>
        </tr>
    </tbody>

    <tr>
        <td></td>
        <td>
            <input type=""submit"" value=""Create"" />
        </td>
        <td></td>
    </tr>

</table>
");
#nullable restore
#line 97 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MTG.DTO.MoveDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591