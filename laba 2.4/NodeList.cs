using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace laba_2._4
{
    internal class NodeList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public void AddInStart(int data)
        {
            if (Head == null)
            {
                Head = new Node<T>(data);
                Tail = new Node<T>(data);

            }
            else
            {
                Node<T> current = Head;
                current.Previous = new Node<T>(data);
                Head = current.Previous;
                Head.Next = current;
                Node<T> current1 = Tail;
                while (current1.Previous != null)
                {
                    current1 = current1.Previous;
                }
                current1.Previous = new Node<T>(data);
                Node<T> current2 = Tail;
                while (current2.Previous != null)
                {
                    current2 = current2.Previous;
                }
                current2.Next = current1;
            }
        }
        public void AddInEnd(int data)
        {
            if (Tail == null)
            {
                Head = new Node<T>(data);
                Tail = new Node<T>(data);
            }
            else
            {
                Node<T> current = Tail;
                current.Next = new Node<T>(data);
                Tail = current.Next;
                Tail.Previous = current;
                Node<T> current1 = Head;
                while (current1.Next != null)
                {
                    current1 = current1.Next;
                }
                current1.Next = new Node<T>(data);
                Node<T> current2 = Head;
                while (current2.Next != null)
                {
                    current2 = current2.Next;
                }
                current2.Previous = current1;
            }
        }
        public void WriteNodeListFromStart()
        {
            Console.WriteLine();
            Node<T> current = Head;
            if (current == null)
            {
                Console.WriteLine("В списке нету элементов");
            }
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine("\n");
        }
        public void WriteNodeListFromEnd()
        {
            Console.WriteLine();
            Node<T> current = Tail;
            if (current == null)
            {
                Console.WriteLine("В списке нету элементов");
            }
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Previous;
            }
            Console.WriteLine("\n");
        }
        public int FindAvg()
        {
            int avg = 0;
            int count = 0;
            Node<T> current = Head;
            while (current != null)
            {
                avg += current.Data;
                count++;
                current = current.Next;
            }
            avg /= count;
            return avg;
        }
        public void Sorting(int avg)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Data < avg)
                {
                    current.Data = avg;
                }
                current = current.Next;
            }
        }
        public void FinishSorting()
        {
            if (Head == null)
            {
                Console.WriteLine("Нельзя отсортировать список без элементов");
            }
            else
            {
                int avg = FindAvg();
                Sorting(avg);
                Console.WriteLine("Список осортирован \n");
            }
        }
    }
}
