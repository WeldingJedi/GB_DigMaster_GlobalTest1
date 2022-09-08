// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void FinalTestWork()
{
    Console.WriteLine("Please, press 'A' for auto mode or 'M' for manual");
    ConsoleKeyInfo key = Console.ReadKey(true);

    if (key.Key == ConsoleKey.A) AutoModeStringArray();
    else if (key.Key == ConsoleKey.M) ManualModeStringArray();
    else Console.WriteLine("You need to choose the work mode correctly. Try again.");
}

void ManualModeStringArray()
{
    Console.WriteLine("Enter array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    FillStringArray(array);
    Console.WriteLine("Entered array is: ");
    PrintStringArray(array);
    Console.WriteLine("Sorted array is: ");
    SortStringArrayBy3Chars(array);
}

void AutoModeStringArray()
{
    Random random = new Random();
    int size = random.Next(1, 16);
    string[] array = new string[size];
    AutoFillStringArray(array);
    Console.WriteLine("Generated array is: ");
    PrintStringArray(array);
    Console.WriteLine("Sorted array is: ");
    SortStringArrayBy3Chars(array);
}

void AutoFillStringArray(string[] array)
{
    string[] library = {"Australia", "Austria", "Albania", "Andorra", "Argentina", "Belarus", "Belgium", "Bulgaria", "Hungary", "Germany", "Greece", "France", "India", "Egypt", "EU",
    "Israel", "Spain", "Italy", "Canada", "Czech Republic", "Cyprus", "China", "Cuba", "Norway", "Denmark", "Ecuador", "Portugal", "Russia", "Peru", "Serbia", "Turkey", "Chile", "RSA",
    "Switzerland", "Sweden", "Japan", "Moscow", "St. Petersburg", "Kazan", "N. Novgorod", "Samara", "Volgograd", "Togliatti", "Bor", "Vladivostok", "world", "hello", "PC", "VSC", "VRtech",
    "computer science", "WTF", "readme.md", "GIT", "C#", "symbol", "number", "char", "element", "array", "is", "TV", "ice", "hockey", "FIT", "SDA", "FSA", "APW", "CAPOL", "RFNM", "SAERsys",
    "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "123",
    "1001", "1002", "1003", "1004", "1005", "1006", "1007", "1008", "1009", "25598", "456879", "123658", "489621", "759826", "46258", "963245", "77589621", "12125896", "654897", ":-)",
    ":-/", ":-D", ":-*", "x_X", "o_O", "O_O", "O_o", ":D", "=)", "=D", "(=", "%)", "^_^", "8)", "lol", "rofl", "afk", "brb", "idk", "lmk", "pls", "Come with me if you want to live"};
    
    for (int i = 0; i < array.Length; i++)
    {
        Random random = new Random();
        array[i] = library[random.Next(0, 143)];
    }
}

void FillStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Enter [{i + 1}] array element: ");
        array[i] = Console.ReadLine();
    }
}

void PrintStringArray(string[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'{array[i]}', ");
    }
    Console.Write("\b\b]\n");
}

void SortStringArrayBy3Chars(string[] array)
{
    int count = 0;
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"'{array[i]}', ");
            count++;
        }
    }

    if (count > 0) Console.Write("\b\b]\n");
    else Console.Write("\b[]");
}

FinalTestWork();