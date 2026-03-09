using System;
using System.Text;

// README.md를 읽고 코드를 작성하세요.

StringProcessor processor = ToUpperCase;

Console.WriteLine("=== 문자열 가공기 ===");
Console.WriteLine();

string str = "Hello World";

Console.WriteLine($"원본: {str}");
Console.WriteLine();

ProcessAndPrint(str, processor) ;

processor = ToLowerCase;
ProcessAndPrint(str, processor);

processor = AddBrackets;
ProcessAndPrint(str, processor);

processor = Reverse;
ProcessAndPrint(str, processor) ;

void ProcessAndPrint(string input, StringProcessor processor)
{
    Console.WriteLine($"결과: {processor(input)}");
}


string ToUpperCase(string s)
{
    Console.WriteLine("[대문자 변환]");
    return s.ToUpper();
}

string ToLowerCase(string s)
{
    Console.WriteLine("[소문자 변환]");
    return s.ToLower();
}

string AddBrackets(string s)
{
    Console.WriteLine("[괄호 추가]");
    return $"[{s}]"; 
}

string Reverse(string s)
{
    Console.WriteLine("[문자열 뒤집기]");

    //StringBuilder sb = new StringBuilder(s); sb.reverse(); 할랫는데 char[] 써야하니까
    char[] chars = s.ToCharArray();

    for(int i = 0; i<chars.Length/2; i++)
    {
        char temp = chars[i];
        chars[i] = chars[chars.Length - i - 1];
        chars[chars.Length - i - 1] = temp;
    }
    s = new String(chars);
    return s;
}

delegate string StringProcessor(string input);


