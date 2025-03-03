using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = InputIntNum("Array Size : ");
            int[] array = new int[arraySize];
            InputIntMasiv(array);
            //SortIntMas(array);
            Array.Sort(array);
            OutIntMas(array);
            Console.ReadLine();

        }
        static void SortIntMas(int[] omas)
        {
            int transfer;
            for (int i = 0; i < omas.Length - 1; i++)
            {
                for (int t = i + 1; t < omas.Length; t++)
                {
                    if (omas[i] < omas[t])
                    {

                        transfer = omas[i];
                        omas[i] = omas[t];
                        omas[t] = transfer;
                    }
                }
            }
        }
        static int InputIntNum(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void InputIntMasiv(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = InputIntNum($"omas{i} : ");
            }
        }
        static void OutIntMas(int[] omas)
        {
            Console.WriteLine("вывод :");
            for (int i = omas.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Omas[{i}] = {omas[i]}");
            }
        }
    }
}