using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Ejercicio1AplicadaII.Models;

namespace Ejercicio1AplicadaII.BLL
{
    public class EstudiantesBLL{
  public static bool Guardar(Estudiantes estudiante)
  {

    if(!Existe(estudiante.EstudianteId)){
      return Insertar(estudiante);
    }else{
      return Modificar(estudiante);
    }
  }

  public static bool Existe(int id)
  {
    Contexto contexto = new Contexto();
    bool ok = false;

    try
    {
      ok = contexto.Estudiante.Any(e => e.EstudianteId == id);
    }
    catch(Exception)
    {
      throw;
    }
    finally
    {
      contexto.Dispose();
    }

    return ok;
  }

  private static bool Insertar(Estudiantes estudiante)
  {
    Contexto contexto = new Contexto();
    bool ok = false;

    try
    {
      contexto.Estudiante.Add(estudiante);
      ok = contexto.SaveChanges() > 0;
    }catch(Exception)
    {
      throw;
    }
    finally
    {
      contexto.Dispose();
    }

    return ok;
  }

  private static bool Modificar(Estudiantes estudiante)
  {
    Contexto contexto = new Contexto();
    bool ok = false;

    try
    {
      contexto.Entry(estudiante).State = EntityState.Modified;
      ok = contexto.SaveChanges() > 0;
    }
    catch(Exception)
    {
      throw;
    }
    finally
    {
      contexto.Dispose();
    }

    return ok;
  }

  public static Estudiantes Buscar(int id)
  {
    Contexto contexto = new Contexto();
    Estudiantes estudiante;

    try
    {
      estudiante = contexto.Estudiante.Find(id);
    }
    catch(Exception)
    {
      throw;
    }
    finally
    {
      contexto.Dispose();
    }

    return estudiante;
  }

  public static bool Eliminar(int id)
  {
    Contexto contexto = new Contexto();
    bool ok = false;

    try
    {
      var estudiante = contexto.Estudiante.Find(id);
      if(estudiante != null){
        contexto.Estudiante.Remove(estudiante);
        ok = contexto.SaveChanges() > 0;
      }
    }
    catch(Exception)
    {
      throw;
    }
    finally
    {
      contexto.Dispose();
    }

    return ok;
  }
}
}