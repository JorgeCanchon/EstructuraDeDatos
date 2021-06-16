using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    /// <summary>
    /// FIFO first in first out fila para pagar
    /// Una cola es una estructura de datos, caracterizada por ser una secuencia de elementos 
    /// en la que la operación de inserción push se realiza por un extremo y 
    /// la operación de extracción pop por el otro. También se le llama estructura FIFO
    /// </summary>
    public static class QueueClass
    {
        public static IEnumerable SetQueue()
        {
            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");
            return myQ;
        }
    }
}
