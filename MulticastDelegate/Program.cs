using System;

// README.md를 읽고 아래에 코드를 작성하세요.



Action<string> action = (msg) => { };

Console.WriteLine("=== 문자열 처리 파이프라인 ===");
Console.WriteLine();

action = PrintOriginal;

Console.WriteLine("--- 단계 1: 원본 출력만 ---");
action("Hello World");
Console.WriteLine();

action += PrintUpper;

Console.WriteLine("--- 단계 2: 대문자 추가 ---");
action("Hello World");
Console.WriteLine();

action += PrintLower;
action += PrintLength;

Console.WriteLine("--- 단계 3: 소문자, 길이 추가---");
action("Hello World");
Console.WriteLine();

action -= PrintUpper;
Console.WriteLine("--- 단계 4: 대문자 제거 ---");
action("Hello World");


void PrintOriginal(string msg)
{
    Console.WriteLine($"원본: {msg}");
}

void PrintUpper(string msg)
{
    Console.WriteLine($"대문자: {msg.ToUpper()}");
}

void PrintLower(string msg)
{
    Console.WriteLine($"소문자: {msg.ToLower()}");
}

void PrintLength(string msg)
{
    Console.WriteLine($"길이: {msg.Length}");
}