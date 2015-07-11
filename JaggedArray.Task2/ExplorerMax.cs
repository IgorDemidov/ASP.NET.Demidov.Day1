using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray.Task2
{
    class ExplorerMax: IRowExplorer
    {   
        public int Explore(int[] row)
        {
            int targetMax = row[1];
            for (int i = 1; i < row.Length; i++)
            {
                if (row[i-1]<row[i])
                {
                    targetMax=row[i];
                }    
            }
            return targetMax;    
        }
    }
}
