void Pause(string message = "Press any key")
{
    System.Console.WriteLine(message);
    Console.ReadKey();

}

int Sum(int a, int b)
{
    return a + b;
}

bool OddorEven(int a)
{
    if(a%2 == 0) return true; else return false;
}

Pause();


System.Console.WriteLine();