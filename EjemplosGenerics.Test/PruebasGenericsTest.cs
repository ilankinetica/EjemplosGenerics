using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace EjemplosGenerics.Test
{
    [TestClass]
    public class PruebasGenericsTest
    {
        [TestMethod]
        public void ProbarOracionCorrecto()
        {
            List<string> palabras = new List<string>();
            palabras.Add("me");
            palabras.Add("gusta");
            palabras.Add("codear");
            string actual = PruebasGenerics.CrearOracion(palabras);

            string expected = "me gusta codear.";

            Assert.AreEqual(actual, expected, "oracion incorrecta");
        }
        [TestMethod]
        public void ProparOracionIComparable()
        {
            List<IComparable> palabras = new List<IComparable>();
            palabras.Add("ingreso");
            palabras.Add("un");
            palabras.Add("numero");
            palabras.Add(5);
            string actual = PruebasGenerics.CrearOracionIComparable(palabras);

            string expected = "ingreso un numero 5.";

            Assert.AreEqual(actual, expected, "oracion incorrecta");
        }
        [TestMethod]
        public void ContarPersonas()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona("pepe"));
            personas.Add(new Persona("juan"));
            personas.Add(new Persona("jose"));
            personas.Add(new Persona("raul"));
            int actual = PruebasGenerics.ContarPersonas(personas);

            int expected = 4;

            Assert.AreEqual(expected, actual);
        }
    }
}
