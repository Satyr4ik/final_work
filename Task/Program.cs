// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string?[] CreateArrayString(int size)
{
    string?[] array = new string?[size];
    string? text;
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент масива: ");
        text = Console.ReadLine();
        array[i] = text;
    }
    return array;
}

void PrintArray(string?[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

string?[] PrintArrayString(string?[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        int num = 0;
        num = array[i].Length;
        if (num <= 3)
        {
            if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        }
        if (i == array.Length - 1) Console.Write($"{array[i]}");
    }
    Console.Write("]");
    return array;

}
string?[] arr = CreateArrayString(3);
PrintArray(arr);
PrintArrayString(arr);

