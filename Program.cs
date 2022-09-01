// double Distance3D()
// {
//     Console.Write("Введите координату x: ");
//     double x1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите координату y: ");
//     double y1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите координату z: ");
//     double z1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите координату x: ");
//     double x2 = Convert.ToDouble(Console.ReadLine());
//      Console.Write("Введите координату y: ");
//     double y2 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите координату z: ");
//     double z2 = Convert.ToDouble(Console.ReadLine());
//     double res = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
//     res = Math.Round(res , 2);
//     return res;
// }
// try
// {
//     Console.WriteLine(Distance3D());
// }
// catch
// {
//     Console.WriteLine("Неверно введенны координаты(Только цифры!)");
// }

// void Palindrom()
// {
//     Console.Write("Введите число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     int pal = 0, num = number;
//     while (number > 0)
//     {
//         pal = pal * 10 + number % 10; number /= 10;
//     }
//     if (num == pal)
//     {
//         Console.WriteLine("Палиндром");
//     }
//     else
//     {
//         Console.WriteLine("Не Палидром");
//     }
// }
// try
// {
//     Palindrom();
// }
// catch
// {
//     Console.WriteLine("Некорректно ввдены данные");
// }

// void SquareTableN()
// {
//     Console.Write("Введите число: ");
//     int N = Convert.ToInt32(Console.ReadLine());
//     if (N > 0)
//     {
//         for (int i = 1; i < (N + 1); i++)
//         {
//             Console.Write($"{i * i * i} , ");
//         }
//     }
//     else
//     {
//         Console.Write("Надо было вводить положительные числа");
//     }

// }
// try
// {
//     SquareTableN();
// }
// catch
// {
//     Console.WriteLine("Надо было вводить именно числа, и именно целые!");
// }