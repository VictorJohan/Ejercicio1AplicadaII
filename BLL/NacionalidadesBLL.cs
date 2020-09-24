using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Ejercicio1AplicadaII.Models;
namespace Ejercicio1AplicadaII.BLL
{
    public class NacionalidadesBLL
    {
        public static bool Guardar(Nacionalidades nacionalidad)
        {
            if(!Existe(nacionalidad.NacionalidadId))
            {
                return Insertar(nacionalidad);
            }else
            {
                return Modificar(nacionalidad);
            }
        }

        public static bool Existe(string id)
        {
            Contexto contexto = new Contexto();
            bool ok = false;

            try
            {
               ok = contexto.Nacionalidad.Any(n => n.NacionalidadId == id);
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

        private static bool Insertar(Nacionalidades nacionalidad)
        {
            Contexto contexto = new Contexto();
            bool ok = false;

            try
            {
                contexto.Nacionalidad.Add(nacionalidad);
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

        private static bool Modificar(Nacionalidades nacionalidad)
        {
            Contexto contexto = new Contexto();
            bool ok = false;

            try
            {
                contexto.Entry(nacionalidad).State = EntityState.Modified;
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

        public static Nacionalidades Buscar(string id)
        {
            Contexto contexto = new Contexto();
            Nacionalidades nacionalidad;

            try
            {
                nacionalidad = contexto.Nacionalidad.Find(id);
            }catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return nacionalidad;
        }

        public static bool Eliminar(string id)
        {
            Contexto contexto = new Contexto();
            bool ok = false;

            try
            {
                var nacionalidad = contexto.Nacionalidad.Find(id);
                if(nacionalidad != null){
                    contexto.Nacionalidad.Remove(nacionalidad);
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

        public static List<Nacionalidades> GetNacionalidades(){
            Contexto contexto = new Contexto();
            List<Nacionalidades> lista = new List<Nacionalidades>();

            try
            {
                lista = contexto.Nacionalidad.ToList();
                lista.Sort((x, y) => x.Nacionalidad.CompareTo(y.Nacionalidad));//Ordena la lista.
            }
            catch (Exception)
            {
                
                throw;
            }finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}