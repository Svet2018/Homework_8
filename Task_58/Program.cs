// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//и
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49



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


int[,] MultArray(int [,] array1, int [,] array2)
{
    int[,] array = new int [array1.GetLength(0),array1.GetLength(1)];

    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
           array[i,j] = array1[i,j] * array2[i,j];
        }       
    } 
    PrintArray(array);
    return array;   
}


System.Console.WriteLine("Введите количество строк массива. ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива. ");
int col = Convert.ToInt32(Console.ReadLine());

int [,] newArray1 = new int [row, col];
int [,] newArray2 = new int [row, col];

System.Console.WriteLine();
System.Console.WriteLine($"Сгененрированы массивы:");
System.Console.WriteLine();
GenerateArray(newArray1);
PrintArray(newArray1);
System.Console.WriteLine();
GenerateArray(newArray2);
PrintArray(newArray2);
System.Console.WriteLine();
System.Console.WriteLine($"Произведение двух сгененрированных массивов будет равно следующему массиву:");
System.Console.WriteLine();
MultArray(newArray1, newArray2);
System.Console.WriteLine();


