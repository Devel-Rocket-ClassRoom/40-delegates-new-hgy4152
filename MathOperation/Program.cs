using System;

// README.md를 읽고 코드를 작성하세요.


MathOp mathOp = Add;

Console.WriteLine("=== 사칙연산 대리자 ===");
Console.WriteLine();


Console.WriteLine("[덧셈]");
Console.WriteLine($"20 + 4 = {mathOp(20, 4)}");

mathOp += Subtract;

Console.WriteLine("[뺄셈]");
Console.WriteLine($"20 - 4 = {mathOp(20, 4)}");

mathOp += Multiply;

Console.WriteLine("[곱셈]");
Console.WriteLine($"20 * 4 = {mathOp(20, 4)}");

mathOp += Divide;

Console.WriteLine("[나눗셈]");
Console.WriteLine($"20 / 4 = {mathOp(20, 4)}");





int Add(int x, int y) => x + y;
int Subtract(int x, int y) => x - y;
int Multiply(int x, int y) => x * y;
int Divide(int x, int y) => x / y;


delegate int MathOp(int x, int y);

