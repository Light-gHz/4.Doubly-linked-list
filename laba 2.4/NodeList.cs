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
                Tail = Head;
            }
            else
            {
                Node<T> current = Head;
                current.Previous = new Node<T>(data);
                Head = current.Previous;
                Head.Next = current;
            }
        }

        public void AddInEnd(int data)
        {
            if (Tail == null)
            {
                Head = new Node<T>(data);
                Tail = Head;
            }
            else
            {
                Node<T> current = Tail;
                current.Next = new Node<T>(data);
                Tail = current.Next;
                Tail.Previous = current;
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
                avg += Convert.ToInt32(current.Data);
                count++;
                current = current.Next;
            }
            avg /= count;
            return avg;
        }

        public void Change(int avg)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (Convert.ToInt32(current.Data) < avg)
                {
                    current.Data = avg;
                }
                current = current.Next;
            }
        }

        public void FinishChange()
        {
            if (Head == null)
            {
                Console.WriteLine("Нельзя отсортировать список без элементов");
            }
            else
            {
                int avg = FindAvg();
                Change(avg);
                Console.WriteLine("Список осортирован \n");
            }
        }
    }
}
