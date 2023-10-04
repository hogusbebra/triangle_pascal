using System;
class Triangle
{
    static void Main()
    {
        int num;
        Console.Write("Введите размер матрицы: ");
        num = int.Parse(Console.ReadLine());
        int[,] matrix = new int[num, num];
        int[,] way = new int[num, num];

        for (int i = 0; i < num; i++)
        {
            way[i, 0] = 1;
        }
        for (int j = 0; j < num; j++)
        {
            way[0, j] = 1;
        }

        for (int i = 1; i < num; i++)
        {
            for (int j = 1; j < num; j++)
            {
                way[i, j] = way[i - 1, j] + way[i, j - 1];
            }
        }
        Console.WriteLine($"Количество путей: {way[num - 1, num - 1]}");
    }
}