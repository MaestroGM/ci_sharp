// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// System.Console.WriteLine("Введите первое целове число");
// int num1 = Convert.ToInt32( Console.ReadLine() );
// System.Console.WriteLine("Введите второе целове число");
// int num2 = Convert.ToInt32( Console.ReadLine() );

// if (num2 * num2 == num1)
// {
//     System.Console.WriteLine("да");
// }
// else
// {
//     System.Console.WriteLine("нет");
// }


// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// System.Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32( Console.ReadLine() );
// int i = - num;
// while(i < num)
// {
//     System.Console.WriteLine(i + ", ");
//     i = i + 1;
// }
// System.Console.WriteLine(i);

// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17


Console.WriteLine("Введите трехзначное целое число:");
int num1 = Convert.ToInt32( Console.ReadLine() );

int num2 = num1/100;
num1 = num1 % 10;


System.Console.WriteLine(num2+num1);
