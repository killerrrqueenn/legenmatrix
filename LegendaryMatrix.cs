using System;

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input + or - ( any to quit): ");
                char action = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (action != '+' && action != '-')
                {
                    break;
                }

                Console.Write("Input the dimensions of the matrix: ");
                int dimensions = int.Parse(Console.ReadLine());
                double[,] matrixValues = new double[dimensions, dimensions];
                Console.WriteLine("Provide the matrix elements:");
                for (int row = 0; row < dimensions; row++)
                {
                    for (int col = 0; col < dimensions; col++)
                    {
                        matrixValues[row, col] = double.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Output:");
                for (int row = 0; row < dimensions; row++)
                {
                    for (int col = 0; col < dimensions; col++)
                    {
                        if (action == '+')
                        {
                            Console.Write(Math.Abs(matrixValues[row, col]) + " ");
                        }
                        else
                        {
                            Console.Write(-matrixValues[row, col] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
