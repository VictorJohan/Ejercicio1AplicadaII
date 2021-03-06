#pragma checksum "c:\Aplicada II\Ejercicio1AplicadaII\Pages\REstudiante.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "673550b8609cf8a0fbc6184607281236d9651b43"
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
#line 1 "c:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Ejercicio1AplicadaII;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Ejercicio1AplicadaII.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Ejercicio1AplicadaII.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Aplicada II\Ejercicio1AplicadaII\_Imports.razor"
using Ejercicio1AplicadaII.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Estudiantes")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Estudiantes/{EstudianteId:int}")]
    public partial class REstudiante : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "c:\Aplicada II\Ejercicio1AplicadaII\Pages\REstudiante.razor"
      
    
    [Parameter]
    public int EstudianteId { get; set; }

    private Estudiantes Estudiante = new Estudiantes();
    private List<Nacionalidades> nacionalidades;
    protected override void OnInitialized(){
        Nuevo();
        nacionalidades = NacionalidadesBLL.GetNacionalidades();
    }

    public void Nuevo(){
        Estudiante = new Estudiantes();
    }

    public void Buscar(){
        var encontrado = EstudiantesBLL.Buscar(Estudiante.EstudianteId);

        if(encontrado != null)
            this.Estudiante = encontrado;
        else
            toast.ShowInfo("No encontrado.");
    }

    public void Guardar(){
        if(EstudiantesBLL.Guardar(Estudiante))
         {
            Nuevo();
            toast.ShowSuccess("Se guardó correctamente.");
        }
        else
        {
            toast.ShowError("No se logró guardar.");
        }
    }

    public void Eliminar(){
        if(EstudiantesBLL.Eliminar(Estudiante.EstudianteId))
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
