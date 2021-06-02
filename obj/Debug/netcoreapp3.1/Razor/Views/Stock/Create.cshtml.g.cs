#pragma checksum "Z:\Proyectos\Montagne\MTG\Views\Stock\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53f111c92f480e7a02fc28f7baa5b90ca80358ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stock_Create), @"mvc.1.0.view", @"/Views/Stock/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53f111c92f480e7a02fc28f7baa5b90ca80358ff", @"/Views/Stock/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b42f3980e9b806361ab641769096aa15e4b1dfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Stock_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MTG.DTO.NewStockDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "Z:\Proyectos\Montagne\MTG\Views\Stock\Create.cshtml"
  
    ViewData["Title"] = "Agrego Productos a Deposito";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Agregar</h2>\r\n\r\n");
#nullable restore
#line 10 "Z:\Proyectos\Montagne\MTG\Views\Stock\Create.cshtml"
 using (Html.BeginForm("JustCreate", "Stock", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 16 "Z:\Proyectos\Montagne\MTG\Views\Stock\Create.cshtml"
               Write(Html.DisplayNameFor(model => model.UnStock.DepositoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 19 "Z:\Proyectos\Montagne\MTG\Views\Stock\Create.cshtml"
               Write(Html.DisplayNameFor(model => model.UnStock.ProductosId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "Z:\Proyectos\Montagne\MTG\Views\Stock\Create.cshtml"
               Write(Html.DisplayNameFor(model => model.UnStock.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n  \r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "Z:\Proyectos\Montagne\MTG\Views\Stock\Create.cshtml"
               Write(Html.DropDownListFor(model => model.UnStock.DepositoId,
                     new SelectList(Model._Depositos, "DepositoId", "Nombre", Model.UnStock.DepositoId),
                     "Elige Deposito de Destino"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "Z:\Proyectos\Montagne\MTG\Views\Stock\Create.cshtml"
               Write(Html.DropDownListFor(model => model.UnStock.ProductosId,
                    new SelectList(Model._Productos, "ProductosId", "detalle", Model.UnStock.ProductosId),
                    "Elige Producto"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n\r\n                <th>\r\n                    <div class=\"input-group\">\r\n                        ");
#nullable restore
#line 45 "Z:\Proyectos\Montagne\MTG\Views\Stock\Create.cshtml"
                   Write(Html.TextBoxFor(model => model.UnStock.Cantidad,
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
                <input type=""submit"" value=""Agregar"" />
            </td>
            <td></td>
        </tr>

    </table>
");
#nullable restore
#line 69 "Z:\Proyectos\Montagne\MTG\Views\Stock\Create.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MTG.DTO.NewStockDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
