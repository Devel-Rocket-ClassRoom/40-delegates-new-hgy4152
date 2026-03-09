using System;

// README.md를 읽고 아래에 코드를 작성하세요.


SayDelegate sayDelegate = Hello;

sayDelegate();
sayDelegate.Invoke();

static void Hello()
{
    Console.WriteLine("Hello Delegate");
}

sayDelegate = Hi;
sayDelegate();

sayDelegate = new SayDelegate(Hi);
sayDelegate();

GetAreaDelegate area = GetArea;

Console.WriteLine(area(10));
Console.WriteLine(area.Invoke(10));

MathOperation pow = Math.Pow;

Console.WriteLine(pow(2, 10));


Transformer t = Calculator.Square;

Console.WriteLine(t(5));


ProgressReporter p = WriteToConsole;
p += WriteToFile;

for(int i = 0; i <= 100; i += 25)
{
    p(i);
    Console.WriteLine();
}


static void Hi()
{
    Console.WriteLine("안녕하세요");
}

static double GetArea(int r)
{
    return r * r * 3.14;
}

static void WriteToConsole(int percent)
{
    Console.WriteLine($"진행률: {percent}%"); 
}
static void WriteToFile(int percent)
{
    Console.WriteLine($"[파일 기록]: {percent}%"); 
}

Runner runner = Go;
runner += Back;

RunnerCall(runner);
RunnerCall(runner);

Action greet = () => Console.WriteLine("안녕하세요!");
greet();

Action<string> hello = (msg) => Console.WriteLine(msg);
hello("Hello, Action!");

Action<string, int> action = (msg, i) =>
{
    for (int j = 0; j < i; j++)
        Console.WriteLine(msg);
};

action("반복", 3);

Func<int> number = () => 42;
Func<int, int> square = (x) => x * x;
Func<int, int, int> add = (x, y) => x + y;
Func<int, int, string> addString = (x, y) => $"{x + y}";

Console.WriteLine(number());
Console.WriteLine(square(5));
Console.WriteLine(add(5, 5));
Console.WriteLine(addString(4, 4));

Predicate<int> IsEven = (x) => x % 2 == 0;
Predicate<int> IsPositive = (x) => x > 0;

Console.WriteLine(IsEven(4));
Console.WriteLine(IsEven(7));
Console.WriteLine(IsPositive(5));
Console.WriteLine(IsPositive(-3));

static void RunnerCall(Runner runner)
{
    Console.WriteLine("=== 실행 시작 ===");
    runner();
    Console.WriteLine("=== 실행 종료 ===");
    Console.WriteLine();
}
static void Go()
{
    Console.WriteLine("직진");
}

static void Back()
{
    Console.WriteLine("후진");
}

delegate void Runner();
delegate int Transformer(int x);
delegate double MathOperation(double a, double b);
delegate double GetAreaDelegate(int a);
delegate void SayDelegate();
delegate void ProgressReporter(int i);


class Calculator
{
    public static int Square(int x)
    {
        return x*x; 
    }
}