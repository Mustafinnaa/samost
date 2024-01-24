using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

//первое задание, ниже закоменчено второе, посмотрите, пожалуйста

class Program
{
    static void Main()
    {
    meow:
        Console.Write("Введите пример: ");
        string a = Console.ReadLine();

        if (SequenceCorrect(a))
        {
            Console.WriteLine("Последовательность скобок корректна");
        }
        else
        {
            Console.WriteLine("Последовательность скобок некорректна");
        }
        goto meow;
    }

    static bool SequenceCorrect(string input)
    {
        if (input.Length == 0 || input[0] == ')' || input[0] == ']' || input[0] == '}')
        {
            return false;
        }

        Stack<char> bracket = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                bracket.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (bracket.Count == 0)
                {
                    return false;
                }

                char OpenBracket = bracket.Pop();
                if ((OpenBracket == '(' && c != ')') ||
                    (OpenBracket == '[' && c != ']') ||
                    (OpenBracket == '{' && c != '}'))
                {
                    return false;
                }
            }
        }

        return bracket.Count == 0;

    }

}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите первую строку: ");
//        string str1 = Console.ReadLine();

//        Console.Write("Введите вторую строку: ");
//        string str2 = Console.ReadLine();

//        int enUpperCase = 0;
//        int enLowerCase = 0;
//        int ruUpperCase = 0;
//        int ruLowerCase = 0;
//        int digits = 0;
//        int other = 0;

//        foreach (char c in str1 + str2)
//        {
//            if (char.IsLetter(c))
//            {
//                if (char.IsUpper(c))
//                {
//                    if (c >= 'A' && c <= 'Z')
//                        enUpperCase++;
//                    else if (c >= 'А' && c <= 'Я')
//                        ruUpperCase++;
//                }
//                else
//                {
//                    if (c >= 'a' && c <= 'z')
//                        enLowerCase++;
//                    else if (c >= 'а' && c <= 'я')
//                        ruLowerCase++;
//                }
//            }
//            else if (char.IsDigit(c))
//                digits++;
//            else if (c == ' ')
//                other++;
//        }

//        Console.WriteLine("EnUpperCase: " + enUpperCase);
//        Console.WriteLine("EnLowerCase: " + enLowerCase);
//        Console.WriteLine("RuUpperCase: " + ruUpperCase);
//        Console.WriteLine("RuLowerCase: " + ruLowerCase);
//        Console.WriteLine("Digits: " + digits);
//        Console.WriteLine("Other: " + other);
//    }
//}
