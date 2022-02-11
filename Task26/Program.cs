// Возведите число А в натуральную степень B используя цикл

int A = 2;
int B = 7;
int result = 1;

for (int i = 1; i <= B; i++)
{
    result = result * A;
}

System.Console.WriteLine(result);