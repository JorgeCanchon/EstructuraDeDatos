using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    /// <summary>
    /// Apuntador -> direccion de un objeto
    /// </summary>
    public class Node
    {
        public object Data { get; set; }
        public Node Next; // -> APUNTADOR
        public Node(object data)
        {
            Data = data;
            Next = null;
        }
    }
}
