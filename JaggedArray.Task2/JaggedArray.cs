using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray.Task2
{
    class JaggedArray
    {
        private int[][] array;
        private ISort Sorting;

        public JaggedArray(int[][] arr)
        {
            array = arr;
        }

        public void SetSorting(ISort sorting)
        {
            Sorting = sorting;
        }

        public void Sort()
        {
            Sorting.Sort(array);
        }



        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < array[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", array[i][j], j == (array[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
        }

       

    }
}
