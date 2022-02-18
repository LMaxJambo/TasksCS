// Написать программу замены элементов массива на противоположные

// 1. Ввод данных
// 2. Обработка данных
// 3. Вывод данных

int N = 10;
int[] a = new int[N];

void Input(int[] arr)
{
    Random ran = new Random(); // Создали объект класса Random и назвали его ran
    for (int i = 0; i < arr.Length; i++)
        arr[i] = ran.Next(1, 100);
}

void Solve(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = -arr[i];
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        System.Console.Write($"{arr[i]} ");
}

Input(a);
Print(a);
Solve(a);
System.Console.WriteLine();
Print(a);