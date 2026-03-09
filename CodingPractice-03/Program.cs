using System;

// README.md를 읽고 아래에 코드를 작성하세요.




Action action = Go;

action += Right;
action += Left;

action();



static void Go()
{
    Console.WriteLine("직진");
}
static void Right()
{
    Console.WriteLine("우회전");
}
static void Left()
{
    Console.WriteLine("좌회전");
}

