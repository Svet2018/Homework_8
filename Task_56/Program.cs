// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт 
//номер строки с наименьшей суммой элементов: 1 строка


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

int MinSum(int [] array)
{
    int min = array[0];
    int number = 0;
    int lengthArray = array.Length;
    for (int i = 0; i < lengthArray; i++)
    {
        if (array[i] <= min)
        {
            min = array[i];
            number = i + 1;
        }
    }
    System.Console.WriteLine($"Минимальная сумма чисел находится в строке {number} и равна = {min}.");
    return (min);
}


void ArrPrint(int [] array)
{   for(int i = 0; i < array.Length; i++){}
    MinSum(array);
}


void SumCounter(int[,] array)
{   
    int [] arrayMin = new int [array.GetLength(0)];
    int num = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;     
        for (int j = 0; j < array.GetLength(1); j++)
        {    
            sum = sum + array[i,j]; 
            arrayMin[i] = sum;            
        }
        num++;  
        System.Console.WriteLine($"Сумма чисел в строке {num} = {sum}.");       
    }
    System.Console.WriteLine();
    ArrPrint(arrayMin);
}

System.Console.WriteLine("Введите количество строк массива. ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива. ");
int col = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine($"Сгененрированный массив:");
System.Console.WriteLine();

int [,] newArray = new int [row, col];

GenerateArray(newArray);
PrintArray(newArray);

System.Console.WriteLine();
SumCounter(newArray);