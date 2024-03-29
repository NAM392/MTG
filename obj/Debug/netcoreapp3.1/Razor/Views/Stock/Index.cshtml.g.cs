#pragma checksum "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb567b742decb9d8b2ffbb2c8f7ebaceabca4f30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stock_Index), @"mvc.1.0.view", @"/Views/Stock/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb567b742decb9d8b2ffbb2c8f7ebaceabca4f30", @"/Views/Stock/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b42f3980e9b806361ab641769096aa15e4b1dfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Stock_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MTG.DTO.StockDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"
  
    ViewData["Title"] = "Stock";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Vista de Stock</h2>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb567b742decb9d8b2ffbb2c8f7ebaceabca4f303559", async() => {
                WriteLiteral("Agregar Stock");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>

        <tr>

            <th>
                <p>Deposito</p>
            </th>
            <th>
                <p>Producto</p>
            </th>
            <th>
                <p>Cantidad</p>
            </th>
            <th>
                <p>Fecha</p>
            </th>


            <th></th>
        </tr>

    </thead>
    <tbody>
");
#nullable restore
#line 37 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"
         foreach (var depo in Model._Depositos)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"
             foreach (var prod in Model._Productos)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"
                 foreach (var st in Model._Stock)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 46 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"
             if (prod.ProductosId == st.ProductosId)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"
                 if (depo.DepositoId == st.DepositoId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 51 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => depo.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => prod.detalle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 57 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => st.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 61 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => st.fecha_hora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 63 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"


                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"
                 


            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tr>\r\n");
#nullable restore
#line 71 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "Z:\Proyectos\Montagne\MTG\Views\Stock\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MTG.DTO.StockDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
