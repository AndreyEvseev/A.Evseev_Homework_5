// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.

void Filling(double[] mas, int min, int max) // случайные вещественные значения элементов массива
{
    int a;
    for (int i = 0; i < mas.Length; i++)
    {
        if (new Random().Next(0, 1) == 0) a = -1;
        else a = 1;
        mas[i] = new Random().Next(min, max + 1) + a * new Random().NextDouble();
    }
}

void Print(double[] mas) // вывод массива на экран
{
    for (int i = 0; i < mas.Length; i++)
    {
        if (i == mas.Length - 1)
        {
            Console.WriteLine(String.Format("{0:f3}", mas[i]) + ".");
        }
        else
        {
            if ((i + 1) % 10 == 0) 
            {
                Console.WriteLine(String.Format("{0:f3}", mas[i]) + "; ");
            }
            else 
            {
                Console.Write(String.Format("{0:f3}", mas[i]) + "; ");
            }
        } 
    }
    Console.WriteLine();
}

double MaxArray(double[] mas) // максимальное значение элементов массива
{
    double max = mas[0];
    for (int i = 1; i < mas.Length; i++)
    {
        if (max < mas[i]) max = mas[i];
    }
    Console.WriteLine("Максимальное значение элементов массива равно " + String.Format("{0:f3}", max) + ". ");
    return max;
}

double MinArray(double[] mas) // минимальное значение элементов массива
{
    double min = mas[0];
    for (int i = 1; i < mas.Length; i++)
    {
        if (min > mas[i]) min = mas[i];
    }
    Console.WriteLine("Минимальное значение элементов массива равно " + String.Format("{0:f3}", min) + ". ");
    return min;
}

void RangeArray(double[] mas) // разница между максимальным и минимальным значениями элементов массива
{
    double max = MaxArray(mas);
    double min = MinArray(mas);
    Console.WriteLine("Разница между максимальным и минимальным значениями элементов массива составляет " +  String.Format("{0:f3}", max - min) +".");
    Console.WriteLine();
}


// Программа
Console.Write("Введите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[N];
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
RangeArray(arr);
