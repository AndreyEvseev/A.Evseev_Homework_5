// Задача 34: Задайте массив, заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве

void Filling(int[] mas) // заполнение массива случайными положительными трёхзначными числами
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(100, 1000);
    }
}

void Print(int[] mas) // вывод массива на экран
{
    for (int i = 0; i < mas.Length; i++)
    {
        if (i == mas.Length - 1)
        {
            Console.WriteLine($"{mas[i]}. ");
        }
        else
        {
            if ((i + 1) % 10 == 0) 
            {
                Console.WriteLine($"{mas[i]}; ");
            }
            else 
            {
                Console.Write($"{mas[i]}; ");
            }
        } 
    }
    Console.WriteLine();
}

int Even(int[] mas) // вывод массива на экран
{
    int num = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 0)
        {
            num += 1;
        }
    }
    Console.WriteLine($"Количество четных чисел в массиве = {num}.");
    return num;
}


Console.Write("Введите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
Filling(arr);
Print(arr);
Even(arr);
