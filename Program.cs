// Двумерные массивы:
// определение
// int[,] arr = new int[2,3] // [количество строк, количество столбцов]
// {
//     {1, 2, 3}, // [количество одномерных массивов, длина каждого одномерного массива]
//     {2, 3, 4}
// };
// // или
// int[,] arr = 
// {
//     {1, 2, 3},
//     {2, 3, 4}
// };
// // или
// int[,] arr = new int[2,3];

// Получение длин массива:
// количество элементов (всего)
// int[,] arr = new int[2,3] // [количество строк, количество столбцов]
// {
//     {1, 2, 3},
//     {2, 3, 4}
// };

// // Length -- длина массива (количество его элементов)
// int arrayLength = arr.Length;
// Console.WriteLine("arr.Length: " + arrayLength); // 6

// // количество строк
// int linesCount = arr.GetLength(0);
// Console.WriteLine("arr.GetLength(0): " + linesCount); // 2

// // количество столбцов
// int columnsCount = arr.GetLength(1);
// Console.WriteLine("arr.GetLength(1) " + columnsCount); // 3

// Заполнение двумерного массива:
// int[,] arr = new int[2, 3];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(0, 10);
//     }
// }

// // // Вывод двумерного массива
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();
// Console.WriteLine(arr[0, 0]);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] array = new double[5];
// for (int i = 0; i < array.Length; i++)
// {
//     double number = new Random().Next(0, 10) + new Random().NextDouble(); // 8 + 0.22 = 8.22
//     array[i] =  Math.Round(number, 2); // округление числа: Math.Round(число для округления, количество знаков)
// }
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }

// // При таком варианте мы никогда не ошибёмся с диапазоном массива, потому что первое число массива
// // есть в массиве, а остальные либо меньше, либо больше, либо равны ему
// double min = array[0];
// double max = array[0];

// Задача 3: Задайте массив из 8 случайных чисел. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[] FillArray(int[] array, int startRandom, int endRandom)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(startRandom, endRandom + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// Поиск с помощью функции
// bool IsNumberInArray(int number, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int[] array = new int[8];
// array = FillArray(array, 0, 9);
// PrintArray(array);
// Console.WriteLine("\n Введите число: ");
// int number = 5;//int.Parse(Console.ReadLine());
// // bool isInArray = IsNumberInArray(number, array);

// // // Поиск в виде цикла
// bool isInArray = false;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == number)
//     {
//         isInArray = true;
//         break;
//     }
// }
// // Все операции сравнения и равенства - bool
// // 5 > 8 -- тоже bool

// // или
// // if (IsNumberInArray(number, array))
// if (isInArray)
// {
//     Console.WriteLine($"Число {number} есть в массиве");
// }
// else
// {
//     Console.WriteLine($"Числа {number} нет в массиве");
// }


// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет 
// на первом месте, а первый - на последнем и т.д.). 
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

// double[] array = new double[5];
// for (int i = 0; i < array.Length; i++)
// {
//     double number = new Random().Next(-10, 11) + new Random().NextDouble();
//     array[i] = Math.Round(number, 2);
// }
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// double f = 0; //память
// for (int i = 0; i < array.Length/2; i++)
// {
//     f = array[i];
//     array[i] = array[array.Length - i - 1];
//     array[array.Length - i - 1] = f;
// }
// Console.WriteLine();
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }


// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10

// [1, -5, 8, 4, -9] -> 4.33


// double[] array = new double[5];
// for (int i = 0; i < array.Length; i++)
// {
//     double number = new Random().Next(-10, 11) + new Random().NextDouble();
//     array[i] = Math.Round(number, 2);
// }
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// double r = 0; // переменная хранит в себе сумму положительных чисел массива
// int count = 0; // переменная хранит в себе количество положительных чисел

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         r += array[i];
//         count++;
//     }
// }
// double middle = r / count;// переменная хранит в себе среднее арифметическое 
// Console.WriteLine();
// Console.WriteLine($"Среднее арифметическое положительных чисел массива = {middle}");


// Задча 3. Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] arr = new int[5, 4];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(0, 11);
    }
}

void PrintArray(int[,] array) // Метод позволяет вывести массив в консоль
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++) 
    {
        Console.Write($"{array[i, j]} ");
    }
Console.WriteLine();
}
}

int summ = 0; // переменная хранит в себе сумму чисел главной диагонали 
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (j == i)
        {
           summ +=   arr[i, j];
        }

    }
}


PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Сумма чисел главной диагонали  = {summ}");