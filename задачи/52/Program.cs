/*Задача 52. Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для поиска ср. арифметического значения каждого столбца.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3*/

Console.Write("Введите количество строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = GetArray(m, n);
RandomArray(m, n);
Console.WriteLine();
AverageArrayColomns(array);

int [,] GetArray(int m, int n)
{
    int [,] array = new int[m, n];
    Random arrayRandomValue = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = arrayRandomValue.Next(1, 10);
                }
            }
    return array;
}
void RandomArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 11);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void AverageArrayColomns(int[,] array)
{

    for (int j = 0; array.GetLength(1) < n; j++)

    {
        double tempValue = 0;
        for (int i = 0; array.GetLength(0) < m; i++)
        {
            tempValue = tempValue + array[i, j];
            
        }
    Console.Write($"Среднее арифметическое столбца = {(tempValue / array.GetLength(1))}");
    tempValue = 0; 
    }
   
      Console.WriteLine();
}
