#pragma checksum "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d7cc436bf4a50746573744ba314c47272ba9e80"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d7cc436bf4a50746573744ba314c47272ba9e80", @"/Views/Movimiento/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b42f3980e9b806361ab641769096aa15e4b1dfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Movimiento_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MTG.DTO.NewMoveDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
  
    ViewData["Title"] = "Nuevo Movimiento";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Nuevo Movimiento</h2>\r\n\r\n");
#nullable restore
#line 11 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
 using (Html.BeginForm("JustCreate", "Movimiento", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
           Write(Html.DisplayNameFor(model => model.UnMovimiento.ProductosId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
           Write(Html.DisplayNameFor(model => model.UnMovimiento.Desde_depo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
           Write(Html.DisplayNameFor(model => model.UnMovimiento.Hasta_depo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
           Write(Html.DisplayNameFor(model => model.UnMovimiento.Id_realizo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
           Write(Html.DisplayNameFor(model => model.UnMovimiento.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
           Write(Html.DropDownListFor(model => model.UnMovimiento.ProductosId,
                new SelectList(Model._Productos, "ProductosId", "detalle", Model.UnMovimiento.ProductosId),
                "Elige Producto"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
           Write(Html.DropDownListFor(model => model.UnMovimiento.Desde_depo,
                 new SelectList(Model._Depositos, "DepositoId", "Nombre", Model.UnMovimiento.Desde_depo),
                 "Elige Deposito Origen"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
           Write(Html.DropDownListFor(model => model.UnMovimiento.Hasta_depo,
                 new SelectList(Model._Depositos, "DepositoId", "Nombre", Model.UnMovimiento.Hasta_depo),
                 "Elige Deposito Destino"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
           Write(Html.DropDownListFor(model => model.UnMovimiento.Id_realizo,
                 new SelectList(Model._Usuarios, "LoginId", "usuario", Model.UnMovimiento.Id_realizo),
                 "Elige Usuario que Realizo el cambio"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n\r\n            <th>\r\n                <div class=\"input-group\">\r\n                    ");
#nullable restore
#line 61 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"
               Write(Html.TextBoxFor(model => model.UnMovimiento.Cantidad,
            new
            {
            @class = "form-control",
            @placeholder = "Ingrese Cantidad",
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
#line 85 "Z:\Proyectos\Montagne\MTG\Views\Movimiento\Create.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MTG.DTO.NewMoveDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
