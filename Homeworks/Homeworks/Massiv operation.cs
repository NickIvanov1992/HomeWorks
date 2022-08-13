Console.Write("Привет! Введите количество элементов в одномерном массиве :");
int Amount_one = Convert.ToInt32(Console.ReadLine());

int[] Array_one = new int[Amount_one];                                   //  создаем одномерный массив

Console.ForegroundColor = ConsoleColor.Green;                            //  изменим цвет оформления на зеленый
Console.Write(Environment.NewLine + "Сгенерирован одномерный массив из следующих элементов: \n");   // после этой строки будет сформирован массив случайных чисел
                                      
for (int i= 0; i <Amount_one; i++)                                      //                     
{                                                                       //
    Random rand = new Random();                                         //   по очереди в цикле 
    int value = rand.Next(-100, 100);                                   //   присвоим рандомное 
    Array_one[i] = value;                                               //   значение элементам 
    Console.Write(Array_one[i] + " ");                                  //      массива
}

int Amount_max = -99;                                                   // переменные для поиска макс.
int Amount_min = 99;                                                    //      и мин. значения 
int current_sum = 0;                                                    // переменная для записи суммы всех
                                                                        //      элементов массива

foreach (int i in Array_one)                                            //  в цикле проверим все элементы массива
{
    int current_element = i + current_sum;                              //  поочереди складывем все элементы 
    current_sum = current_element;                                      //  записываем сумму в current_sum
    

    if (i > Amount_max)                                                 // находим наименьшее и наибольшее
        Amount_max = i;                                                 // значения. Результат запишем в 
    if (i < Amount_min)                                                 // соответствующие переменные
        Amount_min = i;
    
       

    
}

int average_variable = current_sum / Amount_one;                        // среднее арифметическое 


Console.WriteLine(Environment.NewLine+$"Максимальное значение для одномерного массива =: { Amount_max}");
Console.WriteLine($"Минимальное значение для одномерного массива =: { Amount_min}");
Console.WriteLine($"Сумма элементов массива =: {current_sum}");
Console.WriteLine($"Среднее арифметическое элементов массива =: {average_variable}\n");


int count;                                                             //  локальная переменная для сортировки
for (int i = 0; i < Array_one.Length - 1; i++)                         //  в этом цикле смотрим текущий элемент
{
    for (int j = i + 1; j < Array_one.Length; j++)                     //  а в этом сравниваем текущий элемент с последующим
    {
        if (Array_one[i] < Array_one[j])                               //  если текущий элемент 
        {                                                              //  меньше последующего 
            count = Array_one[i];                                      //  то меняем местами 
            Array_one[i] = Array_one[j];                               //  элементы.(т.е.сначала будет больший)
            Array_one[j] = count;
        }
    }
}
Console.WriteLine("Выполним сортировку массива по убыванию. Получим:");
for (int i = 0; i < Array_one.Length; i++)                             //  в цикле выведем полученный
{                                                                      //  сортированный массив
    Console.Write(Array_one[i] + " ");
    
}
Console.ResetColor();                                                  // отключу зеленый цвет текста консоли

 ////////////////////////////////////////////     ДВУХМЕРНЫЙ МАССИВ   ///////////////////////////////////////

Console.WriteLine("");                                                                      // пропуск строки для читабельности
Console.Write(Environment.NewLine + "Введите количество элементов в двумерном массиве:");
int Amount_two = Convert.ToInt32(Console.ReadLine());

int[,] Array_two = new int[Amount_two, Amount_two];                                         // создаем двухмерный массив
Console.ForegroundColor = ConsoleColor.Yellow;                                              // установим цвет консоли на желтый
Console.Write(Environment.NewLine + "Сгенерирована матрица из следующих элементов: \n");    // // после этой строки будет сформирован двухмерный массив случайных чисел


for (int i = 0; i < Amount_two; i++)                                                        // по очереди в цикле присвоим
{                                                                                           // рандомное значение всем элементам 
    for (int z = 0; z< Amount_two; z++)                                                     // массива по строчно 
    {
        Random rand = new Random();
        int value = rand.Next(-100, 100);
        Array_two[i,z] = value;
        ;
        Console.Write(String.Format("{0,4}", Array_two[i, z]));                             // вывод массива в консоль
    }
    Console.WriteLine();                                                                    // перенос на следующую строку для создания вида "матрицы" 

    
}
Amount_max = -99;                                                                           //  -----------------------------------
Amount_min = 99;                                                                            //    аналогично находим              !
current_sum = 0;                                                                            //    максимальное \ минимальное      !
foreach (int i in Array_two)                                                                //     значения в матрице             !
{                                                                                           //                                    !
    int current_element = i + current_sum;                                                  //      находим сумму элементов       ! 
    current_sum = current_element;                                                          //      и среднее значение            !


    if (i > Amount_max)                                                                      //                                   !
        Amount_max = i;                                                                      //                                   !
    if (i < Amount_min)                                                                      //                                   !
        Amount_min = i;                                                                      //                                   !

}
 average_variable = current_sum / Amount_one;                                                //------------------------------------


Console.WriteLine(Environment.NewLine + $"Максимальное значение в матрице  =: {Amount_max}");
Console.WriteLine($"Минимальное значение в матрице =: {Amount_min}");
Console.WriteLine($"Сумма элементов массива =: {current_sum}");
Console.WriteLine($"Среднее арифметическое элементов массива =: {average_variable}\n");

Console.ResetColor();                                                                       //  отключу желтый цвет консоли         

                                                                                            //----------------------------------------------
for (int i = 0; i < Amount_two - 1; i++)                                                    // по очереди сравниваем элементы каждой       |
{                                                                                           // строки . максимальное значение записываем в |
    for (int j = i + 1; j < Amount_two; j++)                                                // начало каждой строки                        |
    {                                                                                       //                                             |
        for (int k = 0; k < Amount_two - 1; k++)                                            //                                             |
        {                                                                                   //                                             |
            for (int l = k + 1; l < Amount_two; l++)                                        //                                             |
            {                                                                               //                                             |
                if (Array_two[i,k] < Array_two[j,l])                                        //                                             |
                {                                                                           //                                             |
                    count = Array_two[i,k];                                                 //                                             |
                    Array_two[i,k] = Array_two[j,l];                                        //                                             |
                    Array_two[j,l] = count;                                                 //                                             |
                }                                                                           //                                             |
            }                                                                               //                                             |
        }                                                                                   //                                             |
    }                                                                                       //                                             |
}                                                                                           //----------------------------------------------
Console.WriteLine("Выполним сортировку массива по убыванию. Получим:");
for (int i = 0; i < Amount_two; i++)                                                        //  вывод полученног отсортированного массива
{
    for (int j = 0; j < Amount_two; j++)
    {
        Console.Write(String.Format("{0,4}", Array_two[i,j] ));
    }
    Console.WriteLine();                                                                   //  пропуск строки для создания вида "матрица"

}








