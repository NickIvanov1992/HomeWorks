Console.Write("Привет! Введите количество элементов в одномерном массиве :");
int Amount_one = Convert.ToInt32(Console.ReadLine());

int[] Array_one = new int[Amount_one];

Console.ForegroundColor = ConsoleColor.Green;
Console.Write(Environment.NewLine + "Сгенерирован одномерный массив из следующих элементов: \n");

for (int i= 0; i <Amount_one; i++)
{
    Random rand = new Random();
    int value = rand.Next(-100, 100);
    Array_one[i] = value;
    Console.Write(Array_one[i] + " ");
}

int Amount_max = -99;
int Amount_min = 99;

int current_sum = 0;
foreach (int i in Array_one)
{
    int current_element = i + current_sum;
    current_sum = current_element;
    

    if (i > Amount_max)
        Amount_max = i;
    if (i < Amount_min)
        Amount_min = i;
    
       

    
}

int average_variable = current_sum / Amount_one;


Console.WriteLine(Environment.NewLine+$"Максимальное значение для одномерного массива =: { Amount_max}");
Console.WriteLine($"Минимальное значение для одномерного массива =: { Amount_min}");
Console.WriteLine($"Сумма элементов массива =: {current_sum}");
Console.WriteLine($"Среднее арифметическое элементов массива =: {average_variable}\n");


int count;
for (int i = 0; i < Array_one.Length - 1; i++)
{
    for (int j = i + 1; j < Array_one.Length; j++)
    {
        if (Array_one[i] < Array_one[j])
        {
            count = Array_one[i];
            Array_one[i] = Array_one[j];
            Array_one[j] = count;
        }
    }
}
Console.WriteLine("Выполним сортировку массива по убыванию. Получим:");
for (int i = 0; i < Array_one.Length; i++)
{
    Console.Write(Array_one[i] + " ");
    
}
Console.ResetColor();



Console.WriteLine("");
Console.Write(Environment.NewLine + "Введите количество элементов в двумерном массиве:");
int Amount_two = Convert.ToInt32(Console.ReadLine());

int[,] Array_two = new int[Amount_two, Amount_two];
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(Environment.NewLine + "Сгенерирована матрица из следующих элементов: \n");


for (int i = 0; i < Amount_two; i++)
{
    for (int z = 0; z< Amount_two; z++)
    {
        Random rand = new Random();
        int value = rand.Next(-100, 100);
        Array_two[i,z] = value;
        ;
        Console.Write(String.Format("{0,4}", Array_two[i, z]));
    }
    Console.WriteLine();

    
}
Amount_max = -99;
Amount_min = 99;

current_sum = 0;
foreach (int i in Array_two)
{
    int current_element = i + current_sum;
    current_sum = current_element;


    if (i > Amount_max)
        Amount_max = i;
    if (i < Amount_min)
        Amount_min = i;

}
 average_variable = current_sum / Amount_one;


Console.WriteLine(Environment.NewLine + $"Максимальное значение в матрице  =: {Amount_max}");
Console.WriteLine($"Минимальное значение в матрице =: {Amount_min}");
Console.WriteLine($"Сумма элементов массива =: {current_sum}");
Console.WriteLine($"Среднее арифметическое элементов массива =: {average_variable}\n");

Console.ResetColor();


for (int i = 0; i < Amount_two - 1; i++)
{
    for (int j = i + 1; j < Amount_two; j++)
    {
        for (int k = 0; k < Amount_two - 1; k++)
        {
            for (int l = k + 1; l < Amount_two; l++)
            {
                if (Array_two[i,k] < Array_two[j,l])
                {
                    count = Array_two[i,k];
                    Array_two[i,k] = Array_two[j,l];
                    Array_two[j,l] = count;
                }
            }
        }
    }
}
Console.WriteLine("Выполним сортировку массива по убыванию. Получим:");
for (int i = 0; i < Amount_two; i++)
{
    for (int j = 0; j < Amount_two; j++)
    {
        Console.Write(String.Format("{0,4}", Array_two[i,j] ));
    }
    Console.WriteLine();

}
Console.ResetColor();







