// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8


void GenerateArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] = new Random().Next(1,10);
        }       
    } 
}


void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}


void OrderedNumbers(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int n = 0; n < array.GetLength(1) - 1; n++)
      {
        if (array[i, n] < array[i, n + 1])
        {
          int num = array[i, n + 1];
          array[i, n + 1] = array[i, n];
          array[i, n] = num;
        }
      }
    }
  }
}


System.Console.WriteLine("Введите количество строк массива. ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива. ");
int col = Convert.ToInt32(Console.ReadLine());

int [,] newArray = new int [row, col];

System.Console.WriteLine($"Сгененрирован массив:");
GenerateArray(newArray);
PrintArray(newArray);
System.Console.WriteLine();
System.Console.WriteLine($"Упорадочены числа в каждой из строк массива по убыванию:");
OrderedNumbers(newArray);
PrintArray(newArray);
System.Console.WriteLine();
