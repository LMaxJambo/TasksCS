// Показать кубы чисел, заканчивающихся на четную цифру
int[] A = { 2, 5, 7, 4, 9, 8, 7, 12, 6, 3, 8, 2, 9 };
for (int i = 0; i < A.Length; i++)
    if (A[i] % 2 == 0)
        System.Console.WriteLine("{0} {1}", A[i], Math.Pow(A[i], 3));
