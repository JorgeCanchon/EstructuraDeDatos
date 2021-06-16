using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    /// <summary>
    /// Una tabla hash o mapa hash es una estructura de datos que asocia llaves o claves con valores. 
    /// La operación principal que soporta de manera eficiente es la búsqueda: permite el acceso 
    /// a los elementos (teléfono y dirección, por ejemplo) almacenados a partir
    /// de una clave generada usando el nombre, número de cuenta o id.
    /// </summary>
    public static class HashTableClass
    {
        public static IEnumerable SetHashTable()
        {
            Hashtable miDiccio = new Hashtable();
            miDiccio.Add("byte", "8 bits");
            miDiccio.Add("pc", "personal computer");
            miDiccio.Add("kilobyte", "1024 bytes");

            // Mostramos algún dato
            Console.WriteLine("Cantidad de palabras en el diccionario: {0}",
                miDiccio.Count);
            try
            {
                Console.WriteLine("El significado de PC es: {0}",
                miDiccio["pc"]);
            }
            catch (Exception)
            {
                Console.WriteLine("No existe esa palabra!");
            }
            return miDiccio;
        }
    }
}
