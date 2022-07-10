void Task27() 
{
    // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    //452 -> 11
    //82 -> 10
    //9012 -> 12
    Console.WriteLine("Введите целое число.");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма цифр числа {n} равна {SumNum(n)}.");

    int SumNum(int number)
    {
        int sum = 0;
        while (number / 10 != 0)
        {
            sum = sum + number % 10;;
            number = number / 10;
        }
        sum = sum + number % 10;
        return sum;
    }
}

Task27();

void Task29()
{
    // Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный от min до max по модулю массив.
    // -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
    // 6, 1, -33 -> [1, 6, -33]
    // для сравнения выводит сначала созданный массив из случайных чисел, и потом отсортированный массив

    int size = 8;
    int[] array1 = new int [size];
    FillArrayRandom(array1);
    PrintArray(array1);
    SortArray(array1);
    PrintArray(array1);

    void FillArrayRandom(int[] FillArray)
    {
        Random random = new Random();
        for (int i = 0; i < FillArray.Length; i++)
        {
            FillArray[i] = random.Next(-99, 100);
        }
    }

    void SortArray(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minPos = i;
            for (int k = i + 1; k < array.Length; k++)
            {
                if (Math.Abs(array[k]) < Math.Abs(array[minPos]))
                    minPos = k;
            }
            int bufer = array[i];
            array[i] = array[minPos];
            array[minPos] = bufer;
        }
    }

    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}

Task29();