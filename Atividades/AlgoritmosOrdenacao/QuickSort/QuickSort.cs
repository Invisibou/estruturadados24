using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
//Nessa aula tu aprendeu algo interessante, lembre-se: Só se usa ";" para pular linha, se não tiver, quer dizer que está na mesma, é isso que o programa entende.
namespace QuickSort
{
    public class QuickSort
    {
        public static T[]  Sort<T>(T[] array, int lower, int upper) where T : IComparable//T é um tipo genérico, não especifica o que é (Se é inteiro, string...)
        {
            if(lower < upper)
            {
                int p = Partition(array, lower, upper);
                Sort(array, lower, p);
                Sort(array, p + 1, upper);
            }
            return array;
        }
        public static int Partition<T>(T[]array, int lower, int upper) where T : IComparable
        {
            int i = lower;
            int j = upper;
            T pivot = array[lower];
            do //Em um laço, são usado 3 variáveis, contador, acumulador e flag.
            {
                while( array[i].CompareTo(pivot) < 0) { i++; }
                while( array[j].CompareTo(pivot) > 0) {j--; }
                if(i >= j ) { break; }
                Swap(array, i, j);
            }
            while(i <= j);

            return j;
        }
        public static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}