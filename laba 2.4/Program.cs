using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NodeList<int> node = new NodeList<int>();
            do
            {
                Console.WriteLine("Если хотите добавить елемент в список нажмите - 1");
                Console.WriteLine("Если хотите вывести элементы из списка нажмите - 2");
                Console.WriteLine("Если хотите отсортировать список чтобы все элементы ниже среднего заменили на среднее значение нажмите - 3");
                Console.WriteLine("Если хотите выйти нажмите - любую другую кнопку");
                string key = Console.ReadLine();
                if (key == "1")
                {
                    Console.WriteLine("Если хотите добавить елемент в начало списока нажмите - 1");
                    Console.WriteLine("Если хотите добавить елемент в конец списока нажмите - любую другую кнопку");
                    string StartOrEnd = Console.ReadLine();
                    if (StartOrEnd == "1")
                    {
                        Console.Write("Введите элемент : ");
                        int element = Convert.ToInt32(Console.ReadLine());
                        node.AddInStart(element);
                    }
                    else
                    {
                        Console.Write("Введите элемент : ");
                        int element = Convert.ToInt32(Console.ReadLine());
                        node.AddInEnd(element);
                    }
                }
                else if (key == "2")
                {
                    Console.WriteLine("Если хотите вывести элементы с начала нажмите - 1");
                    Console.WriteLine("Если хотите вывести элементы с конца нажмите - любую другую кнопку");
                    string StartOrEnd = Console.ReadLine();
                    if (StartOrEnd == "1")
                    {
                        node.WriteNodeListFromStart();
                    }
                    else
                    {
                        node.WriteNodeListFromEnd();
                    }
                }
                else if (key == "3")
                {
                    node.FinishChange();
                }
                else
                {
                    break;
                }
            } while (true);
        }
    }
}
