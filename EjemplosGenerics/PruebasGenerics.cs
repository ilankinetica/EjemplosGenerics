using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosGenerics
{
    public static class PruebasGenerics
    {
        public static int ContarPersonas(List<Persona> lista)
        {
            int cantObjetos;
            cantObjetos = lista.Count();
            return cantObjetos;
        }
        public static string CrearOracion (List<string> palabras)
        {
            //le paso una lista de palabras y arma una oracion
            string oracion;
            oracion = "";
            foreach (var palabra in palabras)
            {
                oracion = oracion + palabra + " ";
            }
            oracion = oracion.Trim() + ".";
            return oracion;
        }
        public static string CrearOracionIComparable (List<IComparable> enumerables)
        {
            string oracion;
            oracion = "";
            foreach (var palabra in enumerables)
            {
                oracion = oracion + palabra + " ";
            }
            oracion = oracion.Trim() + ".";
            return oracion;
        }
    }
}
