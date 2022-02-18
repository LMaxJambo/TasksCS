// Даны два числа. Показать большее и меньшее число

int a = 0;
int b = 0;
string c;

Console.WriteLine("Введите число a ");
 c = Console.ReadLine();
 a = Convert.ToInt32(c);

Console.WriteLine("Введите число b ");
 c = Console.ReadLine();
 b = Convert.ToInt32(c);

if (a > b)
{
    Console.WriteLine("Число a больше числа b");
}
else if (a < b)
{
    Console.WriteLine ("Число a меньше числа b");
}    
else 
{
    Console.WriteLine ("Число a равно числу b");
}

