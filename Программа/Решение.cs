System.Console.WriteLine("Введите количество элементов массива: \t");

string[] CreateAndShowArr(int size)
{
    string[] str = new string[size];
    for (int i = 0; i < str.Length; i++)
    {
        System.Console.WriteLine($"Введите элемент №{i + 1}");
        str[i] = Console.ReadLine()!;
    }
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.Write("\nИзначальный массив: [");
    foreach (var item in str)
    {
        Console.Write(item + ", ");
    }
    System.Console.Write("\b \b]");
    Console.ForegroundColor = ConsoleColor.White;
    return str;
}
string[] str = CreateAndShowArr(int.Parse(Console.ReadLine()!));

string[] SelectThreeDigitValues (string[] str)
{
    string[] selected = new string[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        selected[i] = str[i].Length <= 3 ? str[i] : null;
    }
    selected = selected.Where(x => x != null).ToArray();
    return selected;
}
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine($"\nОтсортированный массив: [{string.Join(", ", SelectThreeDigitValues(str))}]");
Console.ForegroundColor = ConsoleColor.White;   