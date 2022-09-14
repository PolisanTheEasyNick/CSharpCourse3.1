/*
 * 1.12. Вивести на екран номери всіх елементів більших заданого числа.
*/

//одновимірний

Console.WriteLine("Введіть розмірність масиву: ");
int.TryParse(Console.ReadLine(), out var n);
var a = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("a[{0}]= ", i.ToString());
    a[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Введіть число: ");
int.TryParse(Console.ReadLine(), out var num);
for (int i = 0; i < n; i++)
{
    if (a[i] > num) Console.WriteLine(i);
}

//двовимірний
Console.WriteLine("Введіть розмірність масиву: ");
int.TryParse(Console.ReadLine(), out n);
int.TryParse(Console.ReadLine(), out var m);
var a2 = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int x = 0; x < m; x++)
    {
        Console.Write("a[{0}][{1}]= ", i.ToString(), x.ToString());
        a2[i, x] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Введіть число: ");
int.TryParse(Console.ReadLine(), out num);
for (int i = 0; i < n; i++)
{
    for (int x = 0; x < m; x++)
        if (a2[i, x] > num)
            Console.WriteLine($"{i}, {x}");
}

/*
 * 2.12 Поміняти місцями перший мінімальний і максимальний останній елементи.
 */
//одновимірний
Console.WriteLine("Введіть розмірність масиву: ");
int.TryParse(Console.ReadLine(), out n);
a = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("a[{0}]= ", i.ToString());
    a[i] = int.Parse(Console.ReadLine());
}

int maxIndex = 0, minIndex = 0;
for (int i = 0; i < n; i++)
{
    if (a[i] > a[maxIndex]) maxIndex = i;
    if (a[i] < a[minIndex]) minIndex = i;
}

(a[maxIndex], a[minIndex]) = (a[minIndex], a[maxIndex]); //swap by deconstruction
Console.WriteLine("Поміняли місяцми перший мінімальний і максимальний останній елементи.");
for (int i = 0; i < n; i++)
{
    Console.Write("{0} ", a[i].ToString());
}

Console.WriteLine();

/*
 * 3.12. Підрахувати норму матриці за формулою.
 */
//двовимірний
Console.WriteLine("Введіть розмірність масиву: ");
int.TryParse(Console.ReadLine(), out n);
a2 = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int x = 0; x < n; x++)
    {
        Console.Write("a[{0}][{1}]= ", i.ToString(), x.ToString());
        a2[i, x] = int.Parse(Console.ReadLine());
    }
}

int res = 0;
for (int i = 0; i < n; i++)
{
    int max = 0;
    for (int j = 0; j < n; j++)
    {
        if (a2[i, j] > max) max = a2[i, j];
    }
    res += max;
}
Console.WriteLine($"Норма: {res}");

/*
 * 4.12. Для кожного рядка підрахувати суму елементів, що не потрапляють в заданий інтервал, і записати дані в новий масив.
 */
 //ступінчатий
Console.WriteLine("Введіть розмірність масиву: ");
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine("Введіть початок інтервалу");
int.TryParse(Console.ReadLine(), out var start);
Console.WriteLine("Введіть кінець інтервалу");
int.TryParse(Console.ReadLine(), out var end);
if (start >= end)
{
    Console.WriteLine("Не правильний інтервал.");
    return;
}
int[][] a3 = new int [n][];
for (int i = 0; i < n; i++)
{
    a3[i] = new int[i+1];
}
for (int i = 0; i < a3.Length; i++)
{
    for (int x = 0; x < a3[i].Length; x++)
    {
        Console.Write("a[{0}][{1}]= ", i.ToString(), x.ToString());
        a3[i][x] = int.Parse(Console.ReadLine());
    }
}
List<int> result = new List<int>();
int sum = 0;
for (int i = 0; i < a3.Length; i++)
{
    for (int x = 0; x < a3[i].Length; x++)
    {
        if (a3[i][x] < start && a3[i][x] > end)
        {
            result.Add(a3[i][x]);
            sum += a3[i][x];
        }
    }
}
Console.WriteLine($"Сума: {sum}");
Console.WriteLine($"Масив з елементів, які не потрапили в інтервал: ");
for (int i = 0; i < result.Capacity; i++)
{
    Console.WriteLine("{0} ", result[i].ToString());
}