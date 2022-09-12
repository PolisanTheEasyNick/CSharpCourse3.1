using System.Globalization;

/*
 * Варіант 1.12
 * Написати програму, яка обчислює площу трикутника, заданого координатами вершин x1, y1, x2, y2, x3, y3;
 */
Console.WriteLine("Введіть x1: ");
int.TryParse(Console.ReadLine(), out var x1);
Console.WriteLine("Введіть y1: ");
int.TryParse(Console.ReadLine(), out var y1);
Console.WriteLine("Введіть x2: ");
int.TryParse(Console.ReadLine(), out var x2);
Console.WriteLine("Введіть y2: ");
int.TryParse(Console.ReadLine(), out var y2);
Console.WriteLine("Введіть x3: ");
int.TryParse(Console.ReadLine(), out var x3);
Console.WriteLine("Введіть y3: ");
int.TryParse(Console.ReadLine(), out var y3);
var square = Math.Abs(0.5 * ((x1 * y2 + x2 * y3 + x3 * y1) - (y1 * x2 + y2 * x3 + y3 * x1)));
Console.WriteLine("Результат: {0}", square.ToString("N4", CultureInfo.InvariantCulture));

/*
 * Варіант 2.12
 * Написати програму, яка визначає чи кратна числу А сума цифр двозначного числа;
 */
Console.WriteLine("Введіть число: ");
int.TryParse(Console.ReadLine(), out var num);
Console.WriteLine("Введіть A: ");
int.TryParse(Console.ReadLine(), out var a);
var first = (num / 10);
var second = (num % 10);
Console.WriteLine("Перша цифра: {0}, друга: {1}", first.ToString(), second.ToString());
var result = ((first + second) % a) == 0;
Console.WriteLine("Результат: {0}", result.ToString());


Console.WriteLine("Введіть X: ");
int.TryParse(Console.ReadLine(), out var x);
Console.WriteLine("Введіть Y: ");
int.TryParse(Console.ReadLine(), out var y);
if (x is < -40 or > 40)
    Console.WriteLine("Так");
else if (x is > -40 and < 40)
{
    if (y is > 40 or < -40)
        Console.WriteLine("Так");
    else
        Console.WriteLine("Ні");
}
else if ((x == 40) && y is <= 40 and >= -40 || (y is 40 or -40))
    Console.WriteLine("На межі");
else
    Console.WriteLine("Ні");

/*
* Варіант 4.12
* Дано розклад приймальних годин лікаря. Вивести на екран прийомні
* години лікаря в заданий день тижня (розклад придумати самостійно).
*/
Console.WriteLine("Введіть день тижня (1-7):");
int.TryParse(Console.ReadLine(), out var day);
switch (day)
{
    case 1:
    {
        Console.WriteLine("Понеділок");
        Console.WriteLine("08:00-19:00");
        break;
    }
    case 2:
    {
        Console.WriteLine("Вівторок");
        Console.WriteLine("14:00-20:00");
        break;
    }
    case 3:
    {
        Console.WriteLine("Середа");
        Console.WriteLine("08:00-19:00");
        break;
    }
    case 4:
    {
        Console.WriteLine("Четвер");
        Console.WriteLine("14:00-20:00");
        break;
    }
    case 5:
    {
        Console.WriteLine("П'ятниця");
        Console.WriteLine("08:00-19:00");
        break;
    }
    case 6:
    {
        Console.WriteLine("Субота");
        Console.WriteLine("14:00-20:00");
        break;
    }
    case 7:
    {
        Console.WriteLine("Неділя");
        Console.WriteLine("Вихідний");
        break;
    }
    default:
    {
        Console.WriteLine("Помилка у введенні дня");
        break;
    }
}

/*
* 5.12 Реалізувати функцію піднесення у квадрат частки двох цілих чисел. 
*/

double Func512(int one, int sec)
{
    return Math.Pow((double)one / sec, 2);
}

Console.WriteLine("Введіть перше число: ");
int.TryParse(Console.ReadLine(), out var firstNum);
Console.WriteLine("Введіть друге число: ");
int.TryParse(Console.ReadLine(), out var secondNum);
Console.WriteLine($"Результат: {Func512(firstNum, secondNum)}");

/*
* За введеними з клавіатури значеннями обчислити та
вивести на екран значення виразу 6.12
*/
Console.WriteLine("Введіть n: ");
int.TryParse(Console.ReadLine(), out var n);
Console.WriteLine("Введіть m: ");
int.TryParse(Console.ReadLine(), out var m);
double result612 = (m - n) * (n+1)/(n+m+1) - n*n + 5;
Console.WriteLine($"Результат: {result612}");