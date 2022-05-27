// Коды по блок-схемам и словесным описаниям товарища

//(1.1)
double R1 = int.Parse(Console.ReadLine());
double R2 = int.Parse(Console.ReadLine());
double R3 = int.Parse(Console.ReadLine());
double R = 1 / (1 / R1 + 1 / R2 + 1 / R3);
Console.WriteLine(R);

//(1.2)
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
if (y < 0)
{
	Console.WriteLine("Принадлежит");
}
else
{
	Console.WriteLine("Не принадлежит");
}

//(1.3)
Console.WriteLine("Введите размерность массива");
int n = int.Parse(Console.ReadLine());
int[] mas = new int[n];
for (int i = 0; i < n; i++)
{
	Console.Write($"Введите {i + 1} элемент массива: ");
	mas[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
int idx = 0;
while (idx < mas.Length)
{
	if (mas[idx] % 2 == 0)
	{
		break;
	}
	sum = sum + mas[idx];
	idx++;
}
if (idx == mas.Length)
{
	sum = sum - mas[0] - mas[^1];
}
Console.WriteLine(sum);

//(1.4)
Console.WriteLine("Сколько знаков будет в числе (от 2х)");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
char[] y;
y = Console.ReadLine().ToCharArray();
for (int i = 0; i < n; i++)
{
	Console.WriteLine(y[i]);
}

//(1.5)
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int i = 1;
while (i * i <= n)
{
	i++;
}
Console.WriteLine(i * i);

//(1.6)
Console.WriteLine("Введите n (0 <n <27)");
int n = int.Parse(Console.ReadLine());
if (n < 0 | n == 0 | n > 27 | n == 27)
{
	Console.WriteLine("Число находится не в диапозоне");
	return;
}
else
{
	int x;
	int count = 0;
	for (int i = 100; i < 999; i++)
	{
		x = i;
		x = x / 100 + x / 10 % 10 + x % 10;
		if (x == n)
		{
			count++;
		}
	}
	Console.WriteLine(count);
	int y;
	int keks = 0;
	for (int i = 10; i < 99; i++)
	{
		y = i;
		y = y / 10 % 10 + y % 10;
		if (y + y * y == i)
		{
			keks++;
		}
	}
	Console.WriteLine(keks);
}



// Программы по условиям 5 задач

//(2.1)
using System;
using System.Globalization;

DateTime d;
GregorianCalendar cal = new GregorianCalendar();
int countD, num;
Console.Write("День: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Месяц: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Год: ");
int c = int.Parse(Console.ReadLine());
string dat = $"{c}, {b}, {a}";
if (DateTime.TryParse(dat, out d))
{
	num = cal.GetDayOfYear(d);
	Console.WriteLine($"Номер дня с начала года: {num}");
	if (cal.IsLeapYear(c))
	{
		countD = 366 - num;
	}
	else
	{
		countD = 365 - num;
	}
	Console.WriteLine($"Дней до конца года: {countD}");
}
else
{
	Console.WriteLine("Некорректная дата.");
}

//(2.2)
Console.Write("Год: ");
int c = int.Parse(Console.ReadLine());
Console.Write("Месяц: ");
int b = int.Parse(Console.ReadLine());
Console.Write("День: ");
int a = int.Parse(Console.ReadLine());
var dY = new DateTime(c, b, a);
var dG = dY.AddDays((c / 100) - ((c / 100) / 4) - 2);
Console.WriteLine($"По юлианскому календарю – {dY}");
Console.WriteLine($"По григорианскому календарю – {dG}");

//(2.3)
Console.WriteLine("Год: ");
int x = int.Parse(Console.ReadLine());
for (int i = 1; i <= 12; i++)
{
	DateTime d = new DateTime(x, i, DateTime.DaysInMonth(x, i));
	Console.WriteLine($"{d.Month} месяц: {d.Day - (7 + (int)d.DayOfWeek - 4) % 7}, четверг.");
}

//(2.4)
Random ran = new Random();
int s = 1;
Console.WriteLine("Введите число, до которого загадывать:");
int m = int.Parse(Console.ReadLine());
int x = ran.Next(s, m);
int k = ran.Next(1, 5);
Console.WriteLine($"Количество попыток:{k}");
for (int i = 1; i <= k; i++)
{
	Console.WriteLine($"Введите число из диапозона от 1 до {m} :");
	int n = int.Parse(Console.ReadLine());
	if (i == k)
	{

		Console.WriteLine("Не угадали. Попытки закончились.");
	}
	else
	{
		if (n < x)
		{
			Console.WriteLine($"Не угадали. Загаданное число больше. Осталось попыток: {k - i}");
		}
		if (n > x)
		{
			Console.WriteLine($"Не угадали. Загаданное число меньше. Осталось попыток: {k - i}");
		}
		if (n == x)
		{
			Console.WriteLine("Угадали!");
			return;
		}
	}
}

//(2.5)
int[] ar = new int[10];
Random ran = new Random();
Console.WriteLine("Начальный массив:");
for (int x = 0; x < ar.Length; x++)
{
	int y = ran.Next(1, 100);
	ar[x] = y;
	Console.WriteLine(ar[x]);
}
for (int x = ar.Length - 1; x >= 0; x--)
{
	int y = ran.Next(x);
	int z = ar[x];
	ar[x] = ar[y];
	ar[y] = z;
}
Console.WriteLine(" ");
Console.WriteLine("Конечный массив:");
for (int x = 0; x < ar.Length; x++)
{
	Console.WriteLine(ar[x]);
}