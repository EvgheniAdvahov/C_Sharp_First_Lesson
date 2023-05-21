// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <=b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }


// // При Рекурсии обязательно надо продумать условие выхода
// System.Console.WriteLine(NumbersFor(1, 10));

// string NumbersRec(int a, int b)
// {
//     if (a < b) return $"{a} " + NumbersRec(a+1, b);
//     esle:
//         return String.Empty;
// }
// System.Console.WriteLine(NumbersRec(1, 10));

// // Сумма чисел от 1 до N

// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <=n; i++) result +=i;
//     return result;
// }
// System.Console.WriteLine(SumFor(4));

// int SumRec(int n)
// {
//     if(n == 0) return 0;
//     else return n + SumRec(n -1);
// }
// System.Console.WriteLine(SumRec(5));

// Факториал числа

// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *=i;
//     return result;
// }
// System.Console.WriteLine(FactorialFor(10));

// int FactorialRec(int n)
// {
//     if (n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }
// System.Console.WriteLine(FactorialRec(10));

// Вычислить A в степени n
// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *=a;
//     return result;
// }
// System.Console.WriteLine(PowerFor(2, 10));

// int PowerRec(int a, int n)
// {
//     // тернарный оператор
//     return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//     // if (n == 0 ) return 1;
//     // else return PowerRec(a, n - 1) * a;
// }
// System.Console.WriteLine(PowerRec(2, 10));

// Перебор слов

// char [] s = { 'а', 'и', 'с', 'в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         for (int k = 0; k < count; k++)
//         {
//             System.Console.WriteLine($"{n++, -5}{s[i]}{s[k]}{s[j]}");        
//         }
        
//     }
    
// }

// TO DOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
// To UNDERSTANDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD
// To UNDERSTANDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD
// To UNDERSTANDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD
// To UNDERSTANDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD
// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         System.Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length +1);
//     }
// }

// FindWords("аисв", new char[2]);
