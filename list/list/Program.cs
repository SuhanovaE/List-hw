using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#17");
            //List<int> elements = new List<int>(5);                       
            //int imin = 0;
            //int imax = 0;
            //int sum = 0;
            //Random random = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    elements.Add(random.Next(5, 15));
            //}
            //foreach (int el in elements)
            //    {
            //        Console.Write($"{el} ");
            //    }
            //int min = elements.IndexOf(elements.Min());
            //int max = elements.IndexOf(elements.Max());            
            //if (imin < imax)
            //{
            //    for (int i = elements[min]; i < elements[max]; i++)
            //        sum += elements[i];

            //}
            //Console.WriteLine(sum);

            Console.WriteLine("#19");
            List<int> elements1 = new List<int>(5);
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                elements1.Add(random.Next(10, 50));
            }
            foreach (int el in elements1)
            {
                Console.Write($"{el} ");
            }
            Console.Write("Введите число:");
            int k = int.Parse(Console.ReadLine());
            elements1 = elements1.Where(x => x % k == 0).ToList();
            Console.Write($"Числа, кратные {k}:");
            foreach (int el in elements1)
            {
                Console.Write($" {el}");
            }
            Console.WriteLine();
            Console.WriteLine("#22");
            List<int> elements2 = new List<int>(5);
            Random random1 = new Random();
            for (int i = 0; i < 5; i++)
            {
                elements2.Add(random1.Next(10, 15));
            }
            foreach (int el in elements2)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
            Console.Write($"Кол-во различных элементов списка: {elements2.Distinct().Count()}");
            Console.ReadKey();


        }
    }
}
