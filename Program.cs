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