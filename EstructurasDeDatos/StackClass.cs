using System;
using System.Collections;

namespace EstructurasDeDatos
{
    /// <summary>
    /// LIFO pila de platos last in first out
    /// /// Una pila es una lista ordenada o estructura de datos que permite almacenar y recuperar datos,
    /// siendo el modo de acceso a sus elementos de tipo LIFO. 
    /// ejemplo stack memory es una sección de memoria que contiene métodos, variables locales y variables de referencia
    /// </summary>
    public static class StackClass
    {
        public static IEnumerable SetStack()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");
            return myStack;
        }
    }
}
