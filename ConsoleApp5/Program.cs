// See https://aka.ms/new-console-template for more information

try
{
    Console.WriteLine("Введите свою дату рождения: ");
    string s = Console.ReadLine();
    string[] ss = s.Split('.');
    foreach (var sub in ss)
    {
        Console.WriteLine($"Substring: {sub}");
    }
    int day = Convert.ToInt32(ss[0]);
    int month = Convert.ToInt32(ss[1]);
    int year = Convert.ToInt32(ss[2]);

    switch (year % 12)
    {
        case 0:
            Console.WriteLine("Ваше животное - Обезьяна!");
            break;
        case 1:
            Console.WriteLine("Ваше Животное - Петух!");
            break;
        case 2:
            Console.WriteLine("Ваше Животное - Собака!");
            break;
        case 3:
            Console.WriteLine("Ваше Животное - Свинья!");
            break;
        case 4:
            Console.WriteLine("Ваше животное - Крыса!");
            break;
        case 5:
            Console.WriteLine("Ваше животное - Бык!");
            break;
        case 6:
            Console.WriteLine("Ваше жиотное - Тигр!");
            break;
        case 7:
            Console.WriteLine("Ваше животное - Кролик!");
            break;
        case 8:
            Console.WriteLine("Ваше животное - Дракон!");
            break;
        case 9:
            Console.WriteLine("Ваше животное - Змея!");
            break;
        case 10:
            Console.WriteLine("Ваше животное - Лошадь!");
            break;
        case 11:
            Console.WriteLine("Ваше животное - Коза!");
            break;
    }
    switch (year % 10)
    {
        case 0:
        case 1:
            Console.WriteLine("Вашцвет - Белый!");
            break;
        case 2:
        case 3:
            Console.WriteLine("Ваш цвет - Чёрный!");
            break;
        case 4:
        case 5:
            Console.WriteLine("Ваш цвет - Синий!");
            break;
        case 6:
        case 7:
            Console.WriteLine("Ваш цвет - Красный!");
            break;
        case 8:
        case 9:
            Console.WriteLine("Ваш цвет - Зелёный!");
            break;
    }
}
catch (FormatException ex)
{
    Console.WriteLine($"Ошибка формата: {ex.Message}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Ошибка диапазона: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}

