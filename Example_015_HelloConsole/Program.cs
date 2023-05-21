// string path = @"D:\PyCharmProjects\HelloWorld";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }

// void CatalogInfo(string path, string indent ="")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         System.Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + "  ");
//     }

//     FileInfo[] files = catalog.GetFiles();

//     for (int i = 0; i < files.Length; i++)
//     {
//         System.Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }

// string path = @"D:\PyCharmProjects\HelloWorld";
// CatalogInfo(path);


// Ханойские блинчики
// void Towers(string with = "1", string on = "3", string some = "2", int count =4)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     System.Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }
// Towers();

// Задача матем
// string emp = String.Empty;
// string[] tree = {emp, "/", "*",  "10", "-", "+", emp, emp, "4", "2", "1", "3"};
// //                0    1    2      3    4    5    6    7    8    9    10   11
// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         System.Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }
// InOrderTraversal();


// Сравнение рекурсии и итерации
// decimal fRec = 0;
// decimal fIte = 0;

// decimal FibonacciRecursion(int n)
// {
//     fRec++;
//     return n == 0 || n == 1 ? 1 : FibonacciRecursion(n-1) +FibonacciRecursion(n-2);
// }

// decimal FibonacciIteration(int n)
// {
//     fIte++;
//     decimal result = 1;
//     decimal f0 = 1;
//     decimal f1 = 1;
//     for (int i = 0; i <= n; i++)
//     {
//         result = f0 +f1;

//         f0 = f1;
//         f1 = result;
//         fIte++;
//     }
//     return result;
// }

// //# 1 2 3 4 5 6
// //V 1 1 2 3 5 8

// Console.ReadLine();
// DateTime dt = DateTime.Now; 

// for(int n =10; n < 40; n++)
// {
//     System.Console.WriteLine($"FibonacciIteration{n} = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
//     fIte = 0;
// }
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// System.Console.WriteLine();
// Console.ReadLine();
// dt = DateTime.Now;
// for (int n = 10; n < 40; n++)
// {
//     System.Console.WriteLine($"FibonacciIteration{n} = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
//     fIte = 0;
// }
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

int i = 0;
void Rec()
{
    System.Console.WriteLine(i++);
    Rec();
}

Rec();