using System;

namespace SlotMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start a new project Slot Machine
            Console.WriteLine("Slot Machine");

            // Two-dimensional array with 3 columes and 3 rows
            int[,] array1 = new int[3,3] 
            { 
                {0, 1, 2}, /* Row by 0 */ 
                {3, 4, 5}, /* Row by 1 */
                {6, 7, 8}, /* Row by 2 */
            };
            int d, s;
            /* output each array element with value */
            for (d = 0; d < 3; d++)
            {

                for (s = 0; s < 3; s++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", d, s, array1[d, s]);
                }
            }
            

          


        }
    }
}    


