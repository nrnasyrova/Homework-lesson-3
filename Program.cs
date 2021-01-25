using System;

namespace HomeworkLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // assignment1();
            // assignment2();
            // assignment3();
            // assignment4();
            // assignment5();
            assignment6();
            Console.ReadKey();
        }

        static void assignment1()
        {
            Console.Write("Введите значение A: ");
            int.TryParse(Console.ReadLine(), out int A1);
            Console.Write("Введите значение B: ");
            int.TryParse(Console.ReadLine(), out int B1);
            
            int sum = 0;

            for (int i = A1 + 1; i < B1; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Сумма чисел: {sum}");

            Console.Write("Введите значение A: ");
            int.TryParse(Console.ReadLine(), out int A2);
            Console.Write("Введите значение B: ");
            int.TryParse(Console.ReadLine(), out int B2);

            for (int i = A2 + 1; i < B2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void assignment2()
        {
            //rectangle
            for (int i = 0; i < 6; i++)
            {
                if (i == 0 || i == 5)
                {
                    for (int j = 0; j < 18; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("*");
                    for (int k = 0; k < 16; k++)
                    {
                        Console.Write(" ");
                    }
                        Console.Write("*\n");
                }
            }

            //right triangle
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("*");
                }
                if (i > 0 && i < 5)
                {
                    Console.Write("*");
                    for (int h = 0; h < i; h++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*\n");
                }
                else if (i == 5)
                {
                    for (int l = 0; l < 7; l++)
                    {
                        Console.Write("*");
                    }
                }
            }
            //equal-sided triangle
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                if (i == 1)
                {
                    for (int m = 1; m <= 10; m++)
                    {
                        if (m == 6)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                        Console.Write(" ");
                        }
                    }
                    Console.Write("\n");
                }
                else if (i == 5)
                {
                    for (int k = 1; k <= 11; k++)
                    {
                    Console.Write("*");

                    }
                Console.Write("\n");
                }
                else
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        if (j == 6 - i || j == 6 + i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("\n");
                }

            }

            //romb
            for (int i = 0; i < 5; i++)
            {
                if (i ==0)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (j == 5)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    int left = 5 - i;
                    int right = 5 + i;
                    for (int j = 0; j < 10; j++)
                    {
                        if (j == left)
                        {
                            Console.Write("*");
                        }
                        else if (j == right)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            
            for (int i = 0; i < 5; i++)
            {
                if (i == 4)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (j == 5)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    int left = 1 + i;
                    int right = 9 - i;
                    for (int j = 0; j < 10; j++)
                    {
                        if (j == left)
                        {
                            Console.Write("*");
                        }
                        else if (j == right)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
        static void assignment3()
        {
            Console.Write("Write percent: ");
            double.TryParse(Console.ReadLine(),out double p);
            double sum = 1000;
            int k = 0;

            while (sum <= 1100)
            {
                sum = sum + (sum * p / 100);
                k++;
            }

            Console.WriteLine($"Your sum is {sum}, in {k} months ");
        }
        static void assignment4()
        {
            Console.Write("Size of an array: ");
            int.TryParse(Console.ReadLine(), out int s);
            Console.WriteLine("Enter elements of the array");
            int[] numbers = new int[s];

            for (int i = 0; i < s; i++)
            {
                int.TryParse(Console.ReadLine(), out numbers[i]);
            }

            int maxNumber = numbers[0];
            int minNumber = numbers[0];
            int sum = 0;
            int average = 0;
            int[]odd = new int[s];
            int k = 0;

            foreach (int i in numbers)
            {
                maxNumber = Math.Max(maxNumber, i);
                minNumber = Math.Min(minNumber, i);
                sum = sum + i;
                if (i % 2 == 1)
                {
                    odd[k] = i;
                    k++;
                }
            }
            average = sum / s;
            Console.WriteLine($"Max = {maxNumber}, Min = {minNumber}, Average = {average}, Sum = {sum}");
            Console.WriteLine("Odd numbers");
            for (int n = 0; n < k; n++)
            {
                Console.Write($"{odd[n]} ");
            }
        }
        static void assignment5()
        {
            Console.Write("Size of an array: ");
            int.TryParse(Console.ReadLine(), out int s);
            Console.WriteLine("Enter elements of the array");
            int[] numbers = new int[s];

            for (int i = 0; i < s; i++)
            {
                int.TryParse(Console.ReadLine(), out numbers[i]);
            }
            //this was my first try
            // for (int j = 0; j < s; j++)
            // {
            //     Console.Write($"{numbers[s - 1 - j]} ");
            // }
            //then someone suggested that I can use cycles vice versa and I figured out this method
            for (int j = s - 1; j >= 0; j--)
            {
                Console.Write($"{numbers[j]} ");
            }
            Console.WriteLine();
        }
        static void assignment6()
        {
            Console.Write("Size of an argument array = ");
            int.TryParse(Console.ReadLine(), out int N);
            int[] numbers = new int[N+1];
            Console.WriteLine("Enter elements of the array: ");

            for (int i = 0; i < N; i++)
            {
                int.TryParse(Console.ReadLine(), out numbers[i]);
            }

            Console.Write("Count = ");
            int.TryParse(Console.ReadLine(), out int count);
            Console.Write("Index = ");
            int.TryParse(Console.ReadLine(), out int index);

            int[] newArr = new int[count];
            if (index > N){
                for(int i = 0; i < count; i++){
                    newArr[i] = 1;
                }
            }
            else if (index + count < N)
            {
                int tempi = 0;
                for (int j = index; j <= index + count; j++)
                {
                    newArr[tempi] = numbers[j];
                    tempi++; 
                }
            }
            else if (index + count >= N)
            {
                int tempi = 0;
                for (int j = index; j < N; j++)
                {
                    newArr[tempi] = numbers[j];
                    tempi++;
                }
                for (int j = tempi; j < count; j++)
                {
                    newArr[j] = 1;
                }
            }
            foreach(int i in newArr)
            {
                Console.Write($"{i} ");
            }
        }
    }

}
