// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] a = new double[2, 2];
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = new Random().NextDouble() * 100;
        System.Console.Write("a[{0},{1}]={2,6:F2} ", i, j, a[i, j]);
    }
    System.Console.WriteLine();
}
