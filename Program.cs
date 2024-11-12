using System;

namespace NewC_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "exit";
            const string CommandSum = "summ";

            bool isWork = true;

            int[] numbers = new int[0];

            while (isWork)
            {
                Console.WriteLine($"Текущий массив:");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write( $"{numbers[i]} " );
                }

                Console.WriteLine($"\nВведите действие" +
                    $"\nВвод - Добавить число в массив" +
                    $"\n{CommandSum} - посчитать сумму всех чисел" +
                    $"\n{CommandExit} - Выход.");

               string inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case CommandExit:
                        isWork = true;
                        break;

                    case CommandSum:
                        int sumNumbers = 0;

                        for (int i = 0; i < numbers.Length; i++)
                        {        
                                sumNumbers += numbers[i];
                        }

                        Console.WriteLine($"Сумма всех чисел в массиве - {sumNumbers}");
                        Console.ReadKey();
                        break;

                    default:
                        int[] bufferArray = new int[numbers.Length + 1];

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            bufferArray[i] = numbers[i];
                        }

                        bufferArray[bufferArray.Length - 1] = Convert.ToInt32(inputUser);
                        numbers = bufferArray;
                        break;
                }
            }
        }
    }
}