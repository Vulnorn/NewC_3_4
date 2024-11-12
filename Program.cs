using System;

namespace NewC_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "exit";
            const string CommandSum = "summ";

            int lengthArray = 1;
            int sumNumbers = 0;
            int number;
            string inputUser;
            bool isWork = true;

            string[] numbers = new string[lengthArray];
            string[] bufferArray;

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

                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case CommandExit:
                        isWork = true;
                        break;

                    case CommandSum:
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (int.TryParse(numbers[i], out number) == true)
                                sumNumbers += number;
                        }

                        Console.WriteLine($"Сумма всех чисел в массиве - {sumNumbers}");
                        Console.ReadKey();
                        break;

                    default:
                        bufferArray = new string[numbers.Length + 1];

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            bufferArray[i] = numbers[i];
                        }

                        bufferArray[bufferArray.Length - 1] = inputUser;
                        numbers = bufferArray;
                        break;
                }
            }
        }
    }
}