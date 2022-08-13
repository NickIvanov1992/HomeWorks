

do                                                                                     
{
    try                                                                                 // оператор try-catch
    {                                                                                   // для проверки на наличие слова в словаре
        Console.Write("Введите слово на английском:\t");       
        
        string? str = Console.ReadLine();


        Dictionary<string, string> translator = new Dictionary<string, string>();       // инициализируем словарь
        translator.Add("pen", "ручка");                                                //  записываем слова
        translator.Add("pencil", "карандаш");
        translator.Add("dog", "собака");
        translator.Add("cat", "кот");
        translator.Add("bag", "сумка");
        translator.Add("room", "комната");
        translator.Add("car", "автомобиль");
        translator.Add("tea", "чай");
        translator.Add("banch", "скамья");
        translator.Add("desk", "стол");

        if (str != null)                                                             // компилятор просит проверку на null
        {
            string dict = translator[str];
            Console.WriteLine($"Перевод: {dict}\n");
        }
    }
    catch (KeyNotFoundException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Данное слово отсутствует \n");
        Console.ResetColor();
    }
    
}
while (true);
