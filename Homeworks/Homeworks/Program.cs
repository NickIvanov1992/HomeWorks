﻿bool _programm = true;                              //    переменная для активации бесконечного цикла do while

do
{
    int? number_X;                                  // переменная для 1 числа
    int? number_Y;                                  // переменная для 2 числа

    try                                                              // оператор try-catch для проверки формата данных                        
    {
        Console.WriteLine("Введите целое число X");                  // строка информации
        number_X = Convert.ToInt32(Console.ReadLine());              // присваиваем введённое значение для переменной Х. Конвертируем из строки в число                                          // вводим в консоль число "Х"

        Console.WriteLine("Введите целое число Y");                                            // строка информации
        number_Y = Convert.ToInt32(Console.ReadLine());                                        // присваиваем введённое значение для переменной Y. Конвертируем из строки в число                         

        Console.WriteLine($"Введены следующие числа : Х = {number_X} ; Y = {number_Y}");       // строка информации

        if (number_X > number_Y)                                                               //------------------------------
            Console.WriteLine("Число X больше числа Y");                                       //                             +
        if (number_X < number_Y)                                                               //сравним значения чисел       +
            Console.WriteLine("Число Y больше числа X");                                       //результат выведем на экран   +
        if (number_X == number_Y)                                                              //                             +
            Console.WriteLine("Число X равно числу Y");                                        //------------------------------

        // Поиск палиндромов //


        string? Reverse_number;                                                        // создадим строковую переменную, содержащую значение Х или Y
        char[] number_to_mass;                                                         // создадим массив для хранения знаков введенных чисел


        Reverse_number = number_X.ToString();                                          // Конвертируем число Х в строку для записи в массив
        if (!(Reverse_number == null))                                                     // Здесь компилятор выдал предупреждение о возможном значении "null". Ну я и проверил чтобы не было "0" :D
        {
            number_to_mass = Reverse_number.ToCharArray();                                 // запишем знаки введенного числа Х в массив  
            Array.Reverse(number_to_mass);                                                 // реверсируем массив значений числа Х
            Reverse_number = new string(number_to_mass);                                   // запишем в строку полученное перевернутое число Х
        }
        int Reverse_X = Convert.ToInt32(Reverse_number);                               // создаем переменную. Записываем перевернутое значение Х. Конвертируем в формат int.

        Reverse_number = number_Y.ToString();                                         // Конвертируем число Y в строку для записи в массив
        if (!(Reverse_number == null))                                                     // Здесь компилятор выдал предупреждение о возможном значении "null". Ну я и проверил чтобы не было "0" :D
        {
            number_to_mass = Reverse_number.ToCharArray();                                 // запишем знаки введенного числа Y в массив  
            Array.Reverse(number_to_mass);                                                 // реверсируем массив значений числа Y
            Reverse_number = new string(number_to_mass);                                   // запишем в строку полученное перевернутое число Y
        }
        int Reverse_Y = Convert.ToInt32(Reverse_number);                               // создаем переменную. Записываем перевернутое значение Y. Конвертируем в формат int.

        if (Reverse_X == number_X)                                                     // --------------------------------------------------------
            Console.WriteLine($"Число X = {number_X} является палиндромом");           //  сравниваем введенные в консоль значения               +
                                                                                       //  с перевернутыми значениями. Выводим информацию        +
        if (Reverse_Y == number_Y)                                                     //  в консоль о наличии палиндрома при выполнении условий +
            Console.WriteLine($"Число Y = {number_Y} является палиндромом");           // --------------------------------------------------------


        (number_X, number_Y) = (number_Y, number_X);                                                // поменяем значения переменных Х и Y местами
        Console.WriteLine($"Заменены значения переменных: Х = {number_X} ; Y = {number_Y}");        // выведем информацию о замене значений переменных в консоль 
        Console.WriteLine("**************************************************************" + "\n");

    }
    catch (FormatException)                                                                         // оператор try-catch для проверки формата данных.                
    {                                                                                               // Если введеная информация для переменных Х и Y  
        Console.WriteLine("ОШИБКА : неверный формат данных !" + "\n");                              // не соответствует типу "int", то выведем информацию 
    }                                                                                               // в консоль об ошибке, дабы избежать багов.
}
while (_programm == true);                                                                          // условие для бесконечного цикла do while
