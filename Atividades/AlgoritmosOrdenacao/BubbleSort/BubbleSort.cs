using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class BubbleSort
    {
        public static T[] Sort<T>(T[] array) where T : IComparable
        {
            for(int i = 0; i < array.Length - 1; i++) //Length = tamanho, por exemplo, tamanho do vetor = lenght - 4 e de último índice - 3
            {
                bool isAnyChange = false;
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j].CompareTo(array [j + 1]) > 0) //Compara pra mim, se for maior, menor ou igual
                    {
                        isAnyChange = true;
                        Swap(array, j, j +1); 
                    }
                }
                if(!isAnyChange)
                break;
            }
            return array;
        }
        public static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        public static void Print<T>(T[] array)
        {
            Console.WriteLine('[');
            foreach(T i in array)
            {
                Console.Write($"{i} ");
            }
                Console.WriteLine(']');
        }
    }
}