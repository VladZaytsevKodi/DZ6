// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел: ");
int val = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите числа: ");  

int[] array = new int[val];//Задаем размер массива
int count = 0;
for (int i = 0; i < val; i++)//Присваиваем значение каждой ячейки массива
    {
    int k = int.Parse(Console.ReadLine()!); // Значение задавать здесь
    array[i] = k;
    if (k > 0) count++; 
    }
    Console.Write("Колиество чисел больше 0: " + count);



