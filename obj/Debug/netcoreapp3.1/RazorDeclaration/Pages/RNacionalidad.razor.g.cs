#pragma checksum "C:\Aplicada II\Ejercicio1AplicadaII\Pages\RNacionalidad.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "796669298daac00f37282730f75dceac9b3c1784"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Ejercicio1AplicadaII.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Ejercicio1AplicadaII;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Ejercicio1AplicadaII.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Ejercicio1AplicadaII.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Ejercicio1AplicadaII.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Nacionalidad")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Nacionalidades/{NacionalidadId:int}")]
    public partial class RNacionalidad : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Aplicada II\Ejercicio1AplicadaII\Pages\RNacionalidad.razor"
       

    [Parameter]
    public int NacionalidadId { get; set; }
    private Nacionalidades Nacionalidad = new Nacionalidades();

    protected override void OnInitialized()
    {
        Nuevo();
    }

    public void Buscar()
    {
        var encontrado = NacionalidadesBLL.Buscar(Nacionalidad.NacionalidadId);
        if(encontrado != null)
            this.Nacionalidad = encontrado;
        else
            toast.ShowInfo("No se encontro");
    }

    public void Nuevo()
    {
        Nacionalidad = new Nacionalidades();
    }
    public void Guardar()
    {
        if(NacionalidadesBLL.Guardar(Nacionalidad))
        {
            Nuevo();
            toast.ShowSuccess("Se guardó correctamente.");
        }
        else
        {
            toast.ShowError("No se logró guardar.");
        }
            
    }

    public void Eliminar()
    {
        if(NacionalidadesBLL.Eliminar(Nacionalidad.NacionalidadId))
        {
            Nuevo();
            toast.ShowSuccess("Se ha eliminado el registro.");
        }
        else
        {
            toast.ShowError("No se logró eliminar.");
        }
            
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
