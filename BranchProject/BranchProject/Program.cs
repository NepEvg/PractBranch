// See https://aka.ms/new-console-template for more information
Console.Write("введите А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("какое действие выполнить (+, -, *, /) : ");
string ans = Console.ReadLine();
switch (ans)
{
    case "+":
        Console.WriteLine(a+b );
        break;
    case "-":
        Console.WriteLine(a - b);
        break;
    case "*":
        Console.WriteLine(a * b );
        break;
    case "/":
        Console.WriteLine(a / b);
        break;
}