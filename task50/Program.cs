// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
                array[i,j] = new Random().Next(1,10);
} 
void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();    
        }
}
void FindNumber(int[,]array, int number)
{
    bool IsFound = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int value = number;
            if (array[i,j]== value)
            {
                System.Console.Write($"{i},{j}  "); 
                IsFound = true;
            }                
        }    
    }
    if(!IsFound)
    {
        System.Console.WriteLine($"число {number} не найдено в массиве");
    }
}



Console.Clear();
System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число, которое хотите найти:");
int number = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
FindNumber(array,number);