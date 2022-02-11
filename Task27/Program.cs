// Определить количество цифр в числе

int n = 127456;
int n1;
int count = 0;
n1 = n;
while (n != 0)
{
    n = n / 10;
    count++;
}
Console.WriteLine("{0,8} {1,8}", n1, count);