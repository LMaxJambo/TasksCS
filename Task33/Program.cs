// Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
// Найти сумму положительных/отрицательных элементов массива

int[] a = {-1,-1,-1,-1,-1,0,1,1,1,1,1,1};
int sumPos = 0;
int sumNeg = 0;
for(int i=0; i < a.Length; i++)
{
    if(a[i] > 0) sumPos = sumPos + a[i];
    if(a[i] < 0) sumNeg = sumNeg + a[i];
}
System.Console.WriteLine(sumPos);
System.Console.WriteLine(sumNeg);