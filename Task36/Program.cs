// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел
int[] array = new int[10];

int[] arrEven = new int[10];
int[] arrNotEven = new int[10];

int countEven = 0;
int countNotEven = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        arrEven[countEven] = array[i];
        countEven++;
        System.Console.WriteLine($"Четные числа: {arrEven[countEven - 1]} ");
    }
    else
    {
        arrNotEven[countNotEven] = array[i];
        countNotEven++;
        System.Console.WriteLine($"НЕ четные числа: {arrNotEven[countNotEven -1]} ");
    }
}

System.Console.WriteLine($"Количество четных: {countEven}");
System.Console.WriteLine($"Количество НЕчетных: {countNotEven}");