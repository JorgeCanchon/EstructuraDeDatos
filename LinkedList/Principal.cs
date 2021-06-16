using System;

namespace LinkedList
{
    /// <summary>
    /// clases autoreferenciadas
    /// Consiste en una secuencia de nodos, en los que se guardan campos de datos arbitrarios y una o dos referencias, enlaces o punteros al nodo anterior o posterior
    /// Son estructuras de datos que no son primitivas de un lenguaje son objetos
    /// Son estructuras mutables o dinamicas que crecen a demanda
    /// https://www.youtube.com/watch?v=MThabgtlmDM&ab_channel=VidaMRR-Dise%C3%B1oydesarrolloweb
    /// </summary>
    public class Principal //LinkedList
    {
        public Node Head;
        public int Total { get; set; }

        public Principal()
        {
            Head = null;
            Total = 0;
        }

        public void Add(object data)
        {
            Node newNode = new Node(data);
            newNode.Next = null;

            if (Head == null)
                Head = newNode;
            else
            {
                Node last = GetLastNode();
                last.Next = newNode;
            }
            Total++;
        }

        public Node GetLastNode()
        {
            if (Head == null)
                return Head;
            Node last = Head;
            Node control = Head;

            while (control != null)
            {
                last = control;
                control = last.Next;
            }

            return last;
        }

        public void Print()
        {
            Node node = Head;
            while (node != null)
            {
                Console.WriteLine($"*{node.Data}");
                node = node.Next;
            }
        }

        public Node getNodeAt(int pos)
        {
            if (Head == null || (Total - 1) < pos)
                return null;
            Node control = Head;
            int contador = 0;

            while(control != null)
            {
                if (contador == pos)
                    break;
                contador++;
                control = control.Next;
            }
            return control;
        }

        public void Append(Node node, int data)
        {
            if (Head == null || node == null)
                return;

            Node newNode = new Node(data);
            Node prev = node;
            Node next = node.Next;

            prev.Next = newNode;
            newNode.Next = next;
            Total++;
        }

        public void Delete(Node node)
        {
            if (Head == null || node == null)
                return;

            Node control = Head;

            if (node == Head)
            {
                Head = Head.Next;
            }
            else
            {
                while (control.Next != node)
                {
                    control = control.Next;
                }
                Node temp = control.Next;
                control.Next = temp.Next;
                temp = null;
            }

            Total--;
        }
    }
}
