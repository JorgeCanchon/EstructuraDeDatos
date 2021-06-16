using Grafos;
using LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EstructurasDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExecuteLinkedList();
            //ExecuteQueue();
            //ExecuteStack();
            //ExecuteHashTable();
            //ExecuteGrafos();
        }

        public static void ExecuteStack()
        {
            PrintValues(StackClass.SetStack());
        }

        public static void ExecuteQueue()
        {
            PrintValues(QueueClass.SetQueue());
        }

        public static void ExecuteGrafos()
        {
            new Grafos.Principal();
        }

        public static void ExecuteHashTable()
        {
            HashTableClass.SetHashTable();
        }

        public static void ExecuteLinkedList()
        {
            LinkedList.Principal list = new LinkedList.Principal();
            list.Add("hola");
            list.Add('g');
            list.Add(2);

            list.Append(list.getNodeAt(1), 500);
            list.Print();
            Console.WriteLine("----------Eliminar--------------");
            list.Delete(list.getNodeAt(0));
            list.Print();
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.WriteLine("{0}", obj);
            Console.WriteLine();
        }

        public void ListNormal()
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(4);
            list.Add(0);
            list.Remove(0);
            list.Remove(0);
            PrintValues(list);
        }
    }
}
