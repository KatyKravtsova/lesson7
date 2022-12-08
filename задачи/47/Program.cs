//Задача 47. Запросите от пользователя размерности двумерного массива. 
//Напишите метод для заполнения массива случайными числами. Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
//Округлите значения, генерируемые Random до двух знаков после запятой
/*m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

PrintArray(array);

Console.WriteLine(); 

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble()*20-10;
    }
  }
}

void PrintArray (double[,] array) 
  {
  for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 2);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}


