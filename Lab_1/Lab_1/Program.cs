using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Program
    {
        static float[,] generateMatrix(int size)
        {
            var matrix = new float[Math.Abs(size), Math.Abs(size)];

            var rnd = new Random();
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = rnd.Next() % size;

            return matrix;
        }

        static void printMatrix(float[,] matrix)
        {
            Console.WriteLine("Matrix:");
            var size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write("{0,5:0}", matrix[i, j]);
                Console.WriteLine();
            }
        }

        static void printArray(int[] array)
        {
            Console.WriteLine("Workers places:");
            var size = array.Length;
            for (int i = 0; i < size; i++)
                Console.Write("{0,5:0}", array[i]);
            Console.WriteLine();
        }

        static void Main()
        {
            string _s;
            float[,] matrix;
                       
            Console.Write("type N (matrix size N*N) \n N = ");
            _s = Console.ReadLine();

            if(int.TryParse(_s, out int size))
            {
                size = int.Parse(_s);
            }
            else
            {
                try
                {
                    size = int.Parse(_s);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            matrix = new float[Math.Abs(size), Math.Abs(size)];
            

            Console.WriteLine("Generate matrix randomly? [y/n]");
            _s = Console.ReadLine();

            if(_s.ToLower().Equals("y"))
            {
                matrix = generateMatrix(size);
            }
            else
            {
                for (int i = 0; i < size; i++)
                {                            
                    for(int j = 0; j < size; j++)
                    {
                        Console.Write("[" + i + "][" + j + "] = ");
                        _s = Console.ReadLine();
                        if (float.TryParse(_s, out matrix[i, j]))
                        {
                            matrix[i,j] = int.Parse(_s);
                        }
                        else
                        {
                            try
                            {
                                matrix[i, j] = int.Parse(_s);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                return;
                            }
                        }
                    }
                }
            }
            

            printMatrix(matrix);

            var algorithm = new HungarianAlgorithm(matrix);

            var result = algorithm.Run();

            printArray(result);

        }
    }
}