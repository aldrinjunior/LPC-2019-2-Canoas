#pragma checksum "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/LPC-2019-2-Canoas/Aula08CrudPeopleEF/Views/People/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a3dcc2d71727c9abb29235a54d34fbe3fdbe0bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Index), @"mvc.1.0.view", @"/Views/People/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/People/Index.cshtml", typeof(AspNetCore.Views_People_Index))]
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
#line 1 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/LPC-2019-2-Canoas/Aula08CrudPeopleEF/Views/_ViewImports.cshtml"
using Aula08CrudPeopleEF;

#line default
#line hidden
#line 2 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/LPC-2019-2-Canoas/Aula08CrudPeopleEF/Views/_ViewImports.cshtml"
using Aula08CrudPeopleEF.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a3dcc2d71727c9abb29235a54d34fbe3fdbe0bc", @"/Views/People/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"099ed7f4de7e2fe5065b67be4f5245506c4e2182", @"/Views/_ViewImports.cshtml")]
    public class Views_People_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Aula08CrudPeopleEF.Models.Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 434, true);
            WriteLiteral(@"    
</br></br>
<a href=""People/Create"" class=""btn btn-primary"">Nova Pessoa</a>
</br></br>

<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Endereço</th>
                <th>Fone</th>
                <th>Idade</th>
                <th></th>
                <th></th>
            </tr>
            </tr>
        </thead>

");
            EndContext();
#line 22 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/LPC-2019-2-Canoas/Aula08CrudPeopleEF/Views/People/Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(533, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(571, 7, false);
#line 25 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/LPC-2019-2-Canoas/Aula08CrudPeopleEF/Views/People/Index.cshtml"
               Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(578, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(605, 9, false);
#line 26 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/LPC-2019-2-Canoas/Aula08CrudPeopleEF/Views/People/Index.cshtml"
               Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(614, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(641, 12, false);
#line 27 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/LPC-2019-2-Canoas/Aula08CrudPeopleEF/Views/People/Index.cshtml"
               Write(item.address);

#line default
#line hidden
            EndContext();
            BeginContext(653, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(680, 10, false);
#line 28 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/LPC-2019-2-Canoas/Aula08CrudPeopleEF/Views/People/Index.cshtml"
               Write(item.phone);

#line default
#line hidden
            EndContext();
            BeginContext(690, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(717, 8, false);
#line 29 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/LPC-2019-2-Canoas/Aula08CrudPeopleEF/Views/People/Index.cshtml"
               Write(item.age);

#line default
#line hidden
            EndContext();
            BeginContext(725, 51, true);
            WriteLiteral("</td>\n                <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", "\n                    href=\"", 776, "\"", 825, 2);
            WriteAttributeValue("", 803, "People/Delete/", 803, 14, true);
#line 31 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/LPC-2019-2-Canoas/Aula08CrudPeopleEF/Views/People/Index.cshtml"
WriteAttributeValue("", 817, item.id, 817, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(826, 64, true);
            WriteLiteral(">Delete</a> </td>\n                <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " \n                    href=\"", 890, "\"", 938, 2);
            WriteAttributeValue("", 918, "People/Edit/", 918, 12, true);
#line 33 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/LPC-2019-2-Canoas/Aula08CrudPeopleEF/Views/People/Index.cshtml"
WriteAttributeValue("", 930, item.id, 930, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(939, 36, true);
            WriteLiteral(">Editar</a> </td>\n            </tr>\n");
            EndContext();
#line 35 "/home/cassio/1-Wintrab/Ulbra-Projetos-class/LPC/LPC-2019-2-Canoas/Aula08CrudPeopleEF/Views/People/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(985, 19, true);
            WriteLiteral("    </table>\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Aula08CrudPeopleEF.Models.Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
