//1. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine($"Число {number} кратно 7 и 23");
// }
// else 
// {
//     Console.WriteLine($"Число {number} не кратно 7 и 23");
// }


// 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
//    номер координатной четверти плоскости, в которой находится эта точка.

// Console.Write("Введите значение по координате Х не равное нулю: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение по координате У не равное нулю: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine($"Точка с координатами {x} : {y} находится в первой координатной четверти");
// }
// if (x < 0 && y > 0)
// {
//     Console.WriteLine($"Точка с координатами {x} : {y} находится в второй координатной четверти");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine($"Точка с координатами {x} : {y} находится в третьей координатной четверти");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine($"Точка с координатами {x} : {y} находится в четвертой координатной четверти");
// }



// Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// Console.Write("Введите число от 10 до 99: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 10 && number <= 99)
// {
//     int firstDigit = number / 10;
//     int secondDigit = number % 10;
//     if (firstDigit > secondDigit)
//     {
//         Console.WriteLine($"Наибольшая цифра числа {firstDigit}");
//     }
//     if (firstDigit == secondDigit)
//     {
//         Console.WriteLine($"Цифра {secondDigit} ровна цифре {secondDigit}");
//     }
//     if (firstDigit < secondDigit)
//     {
//         Console.WriteLine($"Наибольшая цифра числа {secondDigit}");
//     }
// }
// else
// {
//     Console.WriteLine("Данное число за приделами необходимого отрезка");
// }



// Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.