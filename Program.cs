// Console.WriteLine("Hello, World!");
Console.Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

// Console.Write("Введите количество чисел: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] Arraynumbers= new int [size];
// int count = 0;
// for (int i = 0; i < Arraynumbers.Length; i++)
// {
//     Console.WriteLine($"Введите {i+1}");
//     Arraynumbers[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < Arraynumbers.Length; i++)
// {
//     if(Arraynumbers[i]>0)
//     {
//         count= count+1;
//     }
// }
// Console.WriteLine($"Количество чисел являющихся больше нуля = {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.Write("Введите первое значение: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе значение: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье значение: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите четвертое значение: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// int x =0;
// int y= 0;

// if ((k1 == k2) && (b1 == b2))
// {
//     Console.WriteLine("Прямые равны");
// }
// if (k1==k2)
// {
//     Console.WriteLine("Прямые параллельны");
// }
// else
// {
// x=(b2-b1)/(k1-k2);

// y=(k1*(b2-b1))/(k1-k2)+b1;
// }
// Console.WriteLine($"Координаты точки пересечения: ({x};{y})");