#pragma warning disable CS8321
// Вид 1
void Method1()
{
    System.Console.WriteLine("");
}

Method1();

// Вид 2
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

Method2("Text");

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
System.Console.WriteLine(Method3());

// Вид 3
string Method4(Int16 count, char c)
{
    int i = 0;
    string result = string.Join('-', c);
    return result;
}

Method4(10, '*');

