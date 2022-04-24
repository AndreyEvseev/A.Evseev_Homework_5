// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void Filling(int[] mas, int min, int max) // случайные значения элементов массива
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(min, max + 1);
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

void SumEvenPos(int[] mas) // Сумма элементов на нечетных позициях
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + mas[i];
        }
    }
    Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях, равна {sum}.");
    Console.WriteLine();
}

// Программа
Console.Write("Введите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
// Задается диапазон случайных значений элементов массива
int min = 1, max = 0;
while(max < min)
{
Console.Write("Задайте минимальное значение элемента массива: ");
min = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте максимальное значение элемента массива: ");
max = Convert.ToInt32(Console.ReadLine());
if(max < min) Console.WriteLine("Ошибка! Максимальное значение задано меньше минимального!");
}
Filling(arr, min, max);
Print(arr);
SumEvenPos(arr);
