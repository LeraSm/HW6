// Console.WriteLine("Hello, World!");
Console.Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.Write("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] Arraynumbers= new int [size];
int count = 0;
for (int i = 0; i < Arraynumbers.Length; i++)
{
    Console.WriteLine($"Введите {i+1}");
    Arraynumbers[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < Arraynumbers.Length; i++)
{
    if(Arraynumbers[i]>0)
    {
        count= count+1;
    }
}
Console.WriteLine($"Количество чисел являющихся больше нуля = {count}");