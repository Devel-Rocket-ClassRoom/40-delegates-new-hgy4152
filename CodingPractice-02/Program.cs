using System;
using System.Linq;

// README.md를 읽고 아래에 코드를 작성하세요.


Calculator calculator = new Calculator();

Transformer t = calculator.Multiply;

Console.WriteLine(t(5));


CarDriver car = Go.Front;
car += Go.Right;
car += Go.Left;

car();

car -= Go.Left;

car();

int[] numbers = { 1, 2, 3, 4, 5 };

Transformer math = Square;

Transform(numbers, math);

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i + 1;
}

math = Cube;
Transform(numbers, math);



static void Transform(int[] values, Transformer t)
{
    for(int i = 0; i < values.Length; i++)
    {
        values[i] = t(values[i]);
    }

    Console.WriteLine(string.Join(",", values));
}

int Square(int x) => x * x;
int Cube(int x) => x * x * x;

delegate void CarDriver();
delegate int Transformer(int x);


class Calculator
{
    public int multiplier = 3;

    public int Multiply(int x)
    {
        return x * multiplier; 
    }
}

class Go
{
    public static void Front()
    {
        Console.WriteLine("직진");
    }
    public static void Right()
    {
        Console.WriteLine("우회전");
    }
    public static void Left()
    {
        Console.WriteLine("좌회전");
    }
}