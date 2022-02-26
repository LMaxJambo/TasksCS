// Выяснить являются ли три числа сторонами треугольника



bool IsTriangle(double x, double y, double z)
{
    return (x + y > z && x + z > y && y + z > x);
}

double a = 1, b = 4, c = 7;

//(условие)? вернуть если истина : вернуть если ложь
System.Console.WriteLine($"{a} {b} {c} - " + (IsTriangle(a, b, c)?"Это стороны треугольника":"Это не стороны треугольника"));