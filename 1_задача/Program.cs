/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.WriteLine("Введите количество строк");
bool isParsevasizerow = int.TryParse(Console.ReadLine(), out int sizeRow);

Console.WriteLine("Введите количество столбцов");
bool isParsesizecolumn = int.TryParse(Console.ReadLine(), out int sizeColumn);

if (!isParsevasizerow || !isParsesizecolumn) { Console.WriteLine("Ошибка ввода размености, введено не число"); return; }


double[,] array = Generate2DArray(sizeRow, sizeColumn);
Console.WriteLine();
Print2DArray(array);


double[,] Generate2DArray(int value1, int value2)
{
    double[,] array = new double[value1,value2];
    Random random = new Random();
    for (int i = 0; i < value1; i++)
    {
        for (int j = 0; j < value2; j++)
        {
            array[i,j] = random.Next(0, 10);
        }
    }
    return array;
}


void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}