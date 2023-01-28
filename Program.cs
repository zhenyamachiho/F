string[] GetArray()
{
    Console.WriteLine("Введите количество строк:");
    int arrayLenght = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[arrayLenght];
    for (int i = 0; i < arrayLenght; i++)
    {
        Console.WriteLine($"Введите строку №{i + 1}:");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] arr = GetArray();

void GetSrtingFromArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }

    string[] arrayLessThree = new string[count];

    int a = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arrayLessThree[a] = arr[i];
            a++;
        }
    }
    Console.WriteLine();
    Console.WriteLine("Массив из строк длина которых меньше либо равна 3 символа:");
    Console.WriteLine(string.Join(", ", arrayLessThree));
}