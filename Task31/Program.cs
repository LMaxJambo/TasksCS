// 31. Задать массив из 8 элементов и вывести на экран

// int[] a = {1,2,3,4,5,6,7,8,9};
double[] a = new double[8];

// System.Console.WriteLine(a[0]);
// System.Console.WriteLine(a[9]);

for(int i=0;i<10;i++)
a[i]=new Random().Next(0,100);

for(int i=0;i<10;i++)
System.Console.Write($"{a[i]} ");