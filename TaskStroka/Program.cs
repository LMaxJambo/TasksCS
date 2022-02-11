// переворот строки

string s = Console.ReadLine();
string s1 = string.Empty; // ""

for (int i = s.Length - 1; i >= 0; i--)
{
    s1 = s1 + s[i]; // склеивание или КОНКАТЕНАЦИЯ строк
    //System.Console.Write(s[i]);
}
Console.WriteLine(s1);