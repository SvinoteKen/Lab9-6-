using Lab9__6_.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9__6_
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> firstList = new DoublyLinkedList<int>();
            SecondLinkedList<int> secondList = new SecondLinkedList<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    firstList.AddFirst(random.Next(0, 20));
                    secondList.AddFirst(random.Next(0, 20));
                    
                }
                else
                {
                    firstList.Add(random.Next(0, 20));
                    secondList.Add(random.Next(0, 20));
                }
            }

            Console.WriteLine("Значения первого списка");

            foreach (int items in firstList)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nЗначения второго списка");
            foreach (int item in secondList)
            {
                Console.Write(item+ " ");
            }
            int[] numbers = new int[10];
            int y = 0;
            foreach (int second in secondList)
            {
                if (firstList.Contains(second))
                {
                    numbers[y] = second;
                    y++;
                }
                
            }
            Console.WriteLine();
            firstList.Clear();
            for (int i = 0; i < y; i++)
            {
                if (firstList.Contains(numbers[i])) { continue; }
                if (i == 0)
                {
                    firstList.AddFirst(numbers[i]);
                }
                else
                {
                    firstList.Add(numbers[i]);
                }
            }
            Console.WriteLine("\nРезультат");
            foreach (int items in firstList)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine("\n");
        }
                
    }
}
